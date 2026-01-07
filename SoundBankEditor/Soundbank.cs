using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DWARand
{
    public class Soundbank
    {
        public string Name;
        public List<FileInfo> sounds;

        //Only used during randomization, flags the bank if it was used, if not, add to surrenders.
        public int timesUsedinRand = 0;

        public Soundbank()
        {
            Name = "<Default>";

            DirectoryInfo sndbnk = new DirectoryInfo(Program.exeloc + @"\User\Speech\");

            sounds = sndbnk.GetFiles().ToList();

            List<FileInfo> toBeRemoved = new List<FileInfo>();

            foreach (var item in sounds)
            {
                if (Path.GetExtension(item.FullName).ToLower() != ".wav")
                {
                    toBeRemoved.Add(item);
                }
            }

            foreach (var item in toBeRemoved)
            {
                sounds.Remove(item);
            }
        }

        public Soundbank(string name)
        {
            Name = name;

            DirectoryInfo sndbnk = new DirectoryInfo(Program.exeloc + @"\User\Speech\" + Name);

            sounds = sndbnk.GetFiles().ToList();

            List<FileInfo> toBeRemoved = new List<FileInfo>();

            foreach (var item in sounds)
            {
                if (Path.GetExtension(item.FullName).ToLower() != ".wav")
                {
                    toBeRemoved.Add(item);
                }
            }

            foreach (var item in toBeRemoved)
            {
                sounds.Remove(item);
            }
        }
    }
}
