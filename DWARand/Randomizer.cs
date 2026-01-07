using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DWARand
{
    public static class Randomizer
    {
        public static XmlDocument template = new XmlDocument();
        public static XmlNode templateNode;

        public static List<TemplateBank> templateBanks = new List<TemplateBank>();
        public static void Initialize()
        {
            template.Load(Program.exeloc + @"\DWARand Template.xml");
            templateNode = template.SelectSingleNode("DWARandTemplate");

            foreach (XmlNode item in templateNode.ChildNodes)
            {
                var nameNode = item.ChildNodes[0];
                var friendlyNameNode = item.ChildNodes[1];
                var descriptionNode = item.ChildNodes[2];

                TemplateBank bank = new TemplateBank() { name = nameNode.InnerText, friendlyName = friendlyNameNode.InnerText, description = descriptionNode.InnerText };
                templateBanks.Add(bank);
            }
        }

        public static List<string> validateInputs(string name, string seed, CheckedListBox sndbankListbox)
        {
            List<string> invalidationMessages = new List<string>();

            var invalidChars = Path.GetInvalidPathChars().ToList();
            invalidChars.Add('*');
            invalidChars.Add('/');
            invalidChars.Add('\\');
            invalidChars.Add(':');

            if (invalidChars.Any(name.Contains) || string.IsNullOrWhiteSpace(name))
            {
                invalidationMessages.Add("Invalid soundbank name\n");
            }

            if (string.IsNullOrWhiteSpace(seed))
            {
                invalidationMessages.Add("Empty seed textbox\n");
            }

            if (sndbankListbox.CheckedItems.Count == 0)
            {
                invalidationMessages.Add("No selected soundbanks\n");
            }

            return invalidationMessages;
        }

        public static List<string> validateProtInputs(string name, string seed, List<string> banks)
        {
            List<string> invalidationMessages = new List<string>();

            var invalidChars = Path.GetInvalidPathChars().ToList();
            invalidChars.Add('*');
            invalidChars.Add('/');
            invalidChars.Add('\\');

            if (invalidChars.Any(name.Contains) || string.IsNullOrWhiteSpace(name))
            {
                invalidationMessages.Add("Invalid soundbank name\n");
            }

            if (string.IsNullOrWhiteSpace(seed))
            {
                invalidationMessages.Add("Empty seed\n");
            }

            if (banks.Count == 0)
            {
                invalidationMessages.Add("No selected soundbanks\n");
            }

            return invalidationMessages;
        }

        public static void Randomize(string name, string seed, List<string> sndbanks)
        {
            var banksUsed = "";
            for (int i = 0; i < sndbanks.Count; i++)
            {
                banksUsed += sndbanks[i] + "#" + i + ((i != sndbanks.Count - 1) ? ", " : "");
            }

            LogHandler.Log("[Info] Randomization started");
            LogHandler.Log("[Info] Name: " + name + " Seed: " + seed + " Soundbanks: " + banksUsed);

            Random rnd = GetRNG(seed);

            //Copy the template list
            Queue lcTemplatequeue = new Queue(templateBanks);

            //Create a new soundbank
            Directory.CreateDirectory(Program.exeloc + @"\User\Speech\" + name);

            //Load the selected soundbanks
            List<Soundbank> sndbnks = new List<Soundbank>();

            foreach (var item in sndbanks)
            {
                sndbnks.Add(new Soundbank(item));
            }

            while(lcTemplatequeue.Count > 0)
            {
                string targetfile = (lcTemplatequeue.Dequeue() as TemplateBank).name;

                var selectedBankId = rnd.Next(sndbnks.Count);

                Soundbank bank = sndbnks[selectedBankId];


                LogHandler.Log("[Info] Selected bank: " + bank.Name + "#" + selectedBankId);

                if (bank.sounds.Count == 0)
                {
                    LogHandler.Log("[Warning] Soundbank " + bank.Name + "#" + selectedBankId + " has been skipped");
                    continue;
                }

                sndbnks[selectedBankId].timesUsedinRand += 1;

                var selectedSoundId = rnd.Next(bank.sounds.Count);

                var sound = bank.sounds[selectedSoundId];

                LogHandler.Log("[Info] Selected sound: " + sound.Name + "#" + selectedSoundId);


                if (File.Exists(Program.exeloc + @"\User\Speech\" + name + @"\" + targetfile))
                {
                    File.SetAttributes(Program.exeloc + @"\User\Speech\" + name + @"\" + targetfile, FileAttributes.Normal);
                }
                File.Copy(sound.FullName, Program.exeloc + @"\User\Speech\" + name + @"\" + targetfile, true);
            }

            string surrenders = "";

            foreach (var item in sndbnks)
            {
                LogHandler.Log("[Leaderboard] " + item.Name + ": " + item.timesUsedinRand);

                if (item.timesUsedinRand == 0)
                {
                    surrenders += " " + item.Name + ",";
                }
            }

            if (!string.IsNullOrWhiteSpace(surrenders))
            {
                surrenders = surrenders.Remove(surrenders.Length - 1);

                LogHandler.Log("[Surrenders] Surrendered banks:" + surrenders);
            }

            LogHandler.Log("[Info] Randomization ended");

            LogHandler.SaveLog();
        }

        private static Random GetRNG(string seed)
        {
            var algo = SHA1.Create();
            var hash = BitConverter.ToInt32(algo.ComputeHash(Encoding.UTF8.GetBytes(seed)), 0);
            return new Random(hash);
        }

        internal static void Daily(DateTime date)
        {
            List<string> sndbnks = new List<string>();

            var banks = OptionsHandler.options.dailySoundbanks.Where(x => x.Enabled == true).ToList();

            if(banks.Count <= 1)
            {
                MessageBox.Show("Not enough soundbanks selected for Daily. Please go into the settings panel and select at least 2 soundbanks which you want to use in the Daily Randomizer.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime sysDate;

            if (date != null)
            {
                sysDate = date;
            }
            else
            {
                sysDate = DateTime.UtcNow.Date;
            }

            string normalizedDate = sysDate.Day.ToString() + "." + sysDate.Month.ToString() + "." + sysDate.Year.ToString();

            var rnd = GetRNG(normalizedDate);

            int banksCount = rnd.Next(2, banks.Count);

            for (int i = 0; i < banksCount; i++)
            {
                int taken = rnd.Next(banks.Count);
                sndbnks.Add(banks[taken].Name);
                banks.RemoveAt(taken);
            }

            if (Directory.Exists(Program.exeloc + @"\User\Speech\Daily"))
            {
                DialogResult dialogResult = MessageBox.Show("A soundbank with the name Daily already exists, do you want to overwrite it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            

            Randomizer.Randomize("Daily", normalizedDate, sndbnks);

            MessageBox.Show("Soundbank Daily successfully created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
