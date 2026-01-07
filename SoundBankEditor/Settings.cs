using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DWARand
{
    public class Options
    {
        public List<DailySoundbank> dailySoundbanks = new List<DailySoundbank>();

        public bool registerOnStartup = true;
        public bool randomizerLog = true;

        public Options() { }
    }

    public class OptionsHandler
    {
        public static Options options;
        public static XmlSerializer serializer;
        public static void Initialize()
        {
            serializer = new XmlSerializer(typeof(Options));
            FileStream stream;

            if (File.Exists(Program.exeloc + @"\DWARand Settings.xml"))
            {
                stream = File.OpenRead(Program.exeloc + @"\DWARand Settings.xml");
                options = (Options)serializer.Deserialize(stream);
                stream.Close();

                ValidateBanks();
            }
            else
            {
                options = new Options();
                InitOptions();
                stream = File.Create(Program.exeloc + @"\DWARand Settings.xml");
                serializer.Serialize(stream, options);
                stream.Close();
            }
            
        }

        public static void ValidateBanks()
        {
            //Remove soundbanks from the options file that don't exist anymore
            List<DailySoundbank> toRemove = new List<DailySoundbank>();
            foreach (var item in options.dailySoundbanks)
            {
                if(!Directory.Exists(Program.exeloc + @"\Speech\" + item.Name))
                {
                    toRemove.Add(item);
                }
            }

            foreach (var item in toRemove)
            {
                options.dailySoundbanks.Remove(item);
            }

            //Find any new ones?
            DirectoryInfo speech = new DirectoryInfo(Program.exeloc + @"\Speech");

            var banks = speech.GetDirectories();

            foreach (var item in banks)
            {
                if(!options.dailySoundbanks.Any(x => x.Name == item.Name))
                {
                    DailySoundbank sndbnk = new DailySoundbank(item.Name, false);
                    options.dailySoundbanks.Add(sndbnk);
                }
            }

            options.dailySoundbanks.Sort();

            Save();
        }

        public static void InitOptions()
        {
            DirectoryInfo speech = new DirectoryInfo(Program.exeloc + @"\Speech");

            var banks = speech.GetDirectories().ToList();

            foreach (var item in banks)
            {
                options.dailySoundbanks.Add(new DailySoundbank(item.Name, true));
            }
        }

        public static void Save()
        {
            FileStream stream;
            stream = File.Create(Program.exeloc + @"\DWARand Settings.xml");
            serializer.Serialize(stream, options);
            stream.Close();
        }
    }


    public class DailySoundbank : IComparable
    {
        public string Name { get; set; }
        public bool Enabled;

        public DailySoundbank(string name, bool enabled)
        {
            Name = name;
            Enabled = enabled;
        }

        public DailySoundbank() { }

        public int CompareTo(object obj)
        {
            return string.Compare(Name, (obj as DailySoundbank).Name);
        }
    }
}
