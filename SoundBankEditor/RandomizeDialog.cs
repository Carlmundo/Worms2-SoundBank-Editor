using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand
{
    public partial class RandomizeDialog : Form
    {
        public List<Soundbank> soundbanks = new List<Soundbank>();
        public RandomizeDialog()
        {
            InitializeComponent();
        }

        private void RandomizeDialog_Load(object sender, EventArgs e)
        {
            DirectoryInfo speech = new DirectoryInfo(Program.exeloc + @"\Speech");

            var banks = speech.GetDirectories();

            foreach (var item in banks)
            {
                soundbanks.Add(new Soundbank(item.Name));
                sndbankListbox.Items.Add(item.Name);
            }
        }

        private void RandomizeDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void selallBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sndbankListbox.Items.Count; i++)
            {
                sndbankListbox.SetItemChecked(i, true);
            }
        }

        private void deselallBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sndbankListbox.Items.Count; i++)
            {
                sndbankListbox.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main(new string[0]);
            main.Show();
            Close();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            List<string> sndbnks = new List<string>();

            foreach (var item in sndbankListbox.CheckedItems)
            {
                sndbnks.Add(item.ToString());
            }

            var validation = Randomizer.validateInputs(nameBox.Text, seedBox.Text, sndbankListbox);

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

            if (!replaceChkBox.Checked)
            {
                if(Directory.Exists(Program.exeloc + @"\Speech\" + nameBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("A soundbank with the name " + nameBox.Text + " already exists, do you want to overwrite it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            Randomizer.Randomize(nameBox.Text, seedBox.Text, sndbnks);

            MessageBox.Show("Soundbank " + nameBox.Text + " successfully created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            string finalBankString = "";

            for (int i = 0; i < sndbankListbox.CheckedItems.Count; i++)
            {
                finalBankString += sndbankListbox.CheckedItems[i].ToString() + ((i != sndbankListbox.CheckedItems.Count - 1) ? Program.bankSep : "");
            }

            List<string> validation = Randomizer.validateInputs(nameBox.Text, seedBox.Text, sndbankListbox);

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

            Clipboard.SetText(@"dwarand://name=" + nameBox.Text + ";seed=" + seedBox.Text + ";sndbanks=" + finalBankString);

            MessageBox.Show("Copied your soundbank link to the clipboard", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            if (sndbankListbox.SelectedIndex < 0) return;

            var selectedBank = soundbanks[sndbankListbox.SelectedIndex];
            var selectedSound = selectedBank.sounds[Program.rnd.Next(selectedBank.sounds.Count)];
            
            SoundPlayer player = new SoundPlayer(selectedSound.FullName);
            player.Play();
            player.Dispose();
        }
    }
}
