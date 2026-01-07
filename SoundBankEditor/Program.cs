using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand
{
    static class Program
    {
        public static string exeloc = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string bankSep = ",";
        public static Random rnd = new Random();

        [STAThread]
        static void Main(string[] args)
        {
            var validation = CheckIntegrity();

            if (validation.Count > 0)
            {
                string invalidationMessage = "Something went wrong...\n";
                foreach (var item in validation)
                {
                    invalidationMessage += item;
                }
                MessageBox.Show(invalidationMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Randomizer.Initialize();
            OptionsHandler.Initialize();
            if (OptionsHandler.options.registerOnStartup)
            {
                RegistryHandler.Register();
            }

            if (args.Count() > 0)
            {
                var processed = args[0].Replace("%20", " ");
                processed = processed.Substring(10);
                processed = processed.TrimEnd('/');

                if (!string.IsNullOrWhiteSpace(processed))
                {
                    ParseInput(processed);
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Main main = new Main(args);
            main.Show();
            Application.Run();
        }

        public static List<string> CheckIntegrity()
        {
            List<string> invalidationMessages = new List<string>();
            if (!Directory.Exists(exeloc + @"\Speech"))
            {
                invalidationMessages.Add("Speech directory not found, is DWARand in the Worms Armageddon directory?\n");
            }

            if (!File.Exists(exeloc + @"\DWARand Template.xml"))
            {
                invalidationMessages.Add("DWARand Template.xml not found\n");
            }

            return invalidationMessages;
        }

        static Dictionary<string, ProtVar> vars = new Dictionary<string, ProtVar>();

        static void ParseInput(string processed)
        {
            //Example input:
            //dwarand://name=soundbank;seed=test123;sndbanks=some bank, some bank 2
            var split = processed.Split(';');

            try
            {
                for (int i = 0; i < split.Length; i++)
                {
                    var firstVar = split[i].Split('=');

                    vars.Add(firstVar[0], new ProtVar(firstVar[0], firstVar[1]));
                }
            }
            catch
            {
                MessageBox.Show("Invalid parameter string, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create daily
            if (vars.Keys.First() == "daily")
            {
                string value = vars["daily"].varValue.FirstOrDefault();

                if (value == "today" || string.IsNullOrWhiteSpace(value))
                {
                    Randomizer.Daily(DateTime.Today);
                }
                else
                {
                    DateTime date = DateTime.Parse(value);
                    Randomizer.Daily(date);
                }
                return;
            }
            else
            {
                if (!vars.ContainsKey("name"))
                {
                    MessageBox.Show("Soundbank name input not found, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!vars.ContainsKey("seed"))
                {
                    MessageBox.Show("Seed input not found, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!vars.ContainsKey("sndbanks"))
                {
                    MessageBox.Show("Soundbanks input not found, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string bnkName = vars["name"].varValue.FirstOrDefault();
                string seed = vars["seed"].varValue.FirstOrDefault();
                List<string> banks = new List<string>();

                if (Directory.Exists(Program.exeloc + @"\Speech\" + bnkName))
                {
                    DialogResult dialogResult = MessageBox.Show("A soundbank with the name " + bnkName + " already exists, do you want to overwrite it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                foreach (var item in vars["sndbanks"].varValue)
                {
                    if (!Directory.Exists(Program.exeloc + @"\Speech\" + item))
                    {
                        MessageBox.Show("Soundbank " + item + " is missing! Aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    banks.Add(item);
                }

                List<string> validation = Randomizer.validateProtInputs(bnkName, seed, banks);

                if (validation.Count > 0)
                {
                    string invalidationMessage = "Something went wrong...\n";
                    foreach (var item in validation)
                    {
                        invalidationMessage += item;
                    }
                    MessageBox.Show(invalidationMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                try
                {
                    Randomizer.Randomize(bnkName, seed, banks);
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(e.StackTrace);
                }

                MessageBox.Show("Soundbank " + bnkName + " successfully created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
