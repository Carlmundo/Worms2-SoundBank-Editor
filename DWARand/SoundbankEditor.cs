using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DWARand.UI;
using System.Media;

namespace DWARand
{
    public partial class SoundbankEditor : Form
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        SoundPlayer player;

        List<Soundbank> soundbanks = new List<Soundbank>();

        public Soundbank selectedBank;

        public int savedTTSIndex = 0;
        public SoundbankEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo speech = new DirectoryInfo(Program.exeloc + @"\User\Speech");

            soundbanks.Add(new Soundbank());

            var banks = speech.GetDirectories();

            foreach (var item in banks)
            {
                soundbanks.Add(new Soundbank(item.Name));
            }

            foreach (var item in soundbanks)
            {
                sndbankBox.Items.Add(item.Name);
            }

            sndbankBox.SelectedIndex = 0;

            foreach (var item in Randomizer.templateBanks)
            {
                dSoundListbox.Items.Add(new SoundDisplay() { displayName = item.friendlyName, name = item.name, description = item.description, sound = new SoundInfo(new FileInfo(Program.exeloc + @"\User\Speech\" + item.name)) , defaultSound = true });
            }

            dSoundListbox.SelectedIndex = 0;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Directory.Exists(Program.exeloc + @"\DWARand Temp"))
                Directory.Delete(Program.exeloc + @"\DWARand Temp", true);

            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void sndbankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBank = soundbanks[sndbankBox.SelectedIndex];

            if (sndbankBox.SelectedIndex == 0)
            {
                deleteBtn.Enabled = false;
                restoreBtn.Enabled = false;
                ttsBtn.Enabled = false;
            }
            else
            {
                deleteBtn.Enabled = true;
                ttsBtn.Enabled = true;
            }

            foreach (var item in dSoundListbox.Items)
            {
                var displayItem = (SoundDisplay)item;

                if(sndbankBox.SelectedIndex == 0)
                {
                    displayItem.sound = new SoundInfo(new FileInfo(Program.exeloc + @"\User\Speech\" + displayItem.name));
                    displayItem.defaultSound = true;
                }
                else
                {
                    if (File.Exists(Program.exeloc + @"\User\Speech\" + sndbankBox.Text + @"\" + displayItem.name))
                    {
                        displayItem.sound = new SoundInfo(new FileInfo(Program.exeloc + @"\User\Speech\" + sndbankBox.Text + @"\" + displayItem.name));
                        displayItem.defaultSound = false;
                    }
                    else
                    {
                        displayItem.sound = new SoundInfo(new FileInfo(Program.exeloc + @"\User\Speech\" + displayItem.name));
                        displayItem.defaultSound = true;
                    }

                }


                
            }

            if (dSoundListbox.SelectedIndex >= 0)
            {
                var curItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];

                if (curItem.defaultSound)
                {
                    restoreBtn.Enabled = false;
                }
                else
                {
                    restoreBtn.Enabled = true;
                }
            }

            dSoundListbox.Refresh();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (dSoundListbox.SelectedItem == null) return;

            var displayItem = (dSoundListbox.SelectedItem as SoundDisplay);
            player = new SoundPlayer((dSoundListbox.SelectedItem as SoundDisplay).sound.FullName);
            player.Play();
            player.Dispose();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                var displayItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];

                displayItem.sound = new SoundInfo(new FileInfo(openDialog.FileName));
                displayItem.defaultSound = false;
                dSoundListbox.Refresh();
            }
        }

        private void saveasBtn_Click(object sender, EventArgs e)
        {
            SaveBankDialog dialog = new SaveBankDialog(sndbankBox.SelectedIndex != 0 ? sndbankBox.Text : "");
            dialog.ShowDialog();
            if (dialog.confirm)
            {
                Directory.CreateDirectory(Program.exeloc + @"\User\Speech\" + dialog.bankName);
                foreach (var item in dSoundListbox.Items)
                {
                    var displayItem = (SoundDisplay)item;

                    if (!displayItem.defaultSound && File.Exists(displayItem.sound.FullName) && displayItem.sound.FullName != Program.exeloc + @"\User\Speech\" + dialog.bankName + @"\" + displayItem.name)
                    {
                        File.Copy(displayItem.sound.FullName, Program.exeloc + @"\User\Speech\" + dialog.bankName + @"\" + displayItem.name, true);
                    }
                }

                DirectoryInfo speech = new DirectoryInfo(Program.exeloc + @"\User\Speech");

                soundbanks.Clear();
                sndbankBox.Items.Clear();

                soundbanks.Add(new Soundbank());

                var banks = speech.GetDirectories();

                foreach (var item in banks)
                {
                    soundbanks.Add(new Soundbank(item.Name));
                }

                for (int i = 0; i < soundbanks.Count; i++)
                {
                    sndbankBox.Items.Add(soundbanks[i].Name);
                }

                sndbankBox.SelectedIndex = sndbankBox.Items.IndexOf(dialog.bankName);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete " + sndbankBox.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Directory.Delete(Program.exeloc + @"\User\Speech\" + sndbankBox.Text, true);

                DirectoryInfo speech100 = new DirectoryInfo(Program.exeloc + @"\User\Speech");

                soundbanks.Clear();
                sndbankBox.Items.Clear();

                soundbanks.Add(new Soundbank());

                var banks = speech100.GetDirectories();

                foreach (var item in banks)
                {
                    soundbanks.Add(new Soundbank(item.Name));
                }

                for (int i = 0; i < soundbanks.Count; i++)
                {
                    sndbankBox.Items.Add(soundbanks[i].Name);
                }

                sndbankBox.SelectedIndex = 0;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            var displayItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];

            displayItem.defaultSound = true;
            if(File.Exists(Program.exeloc + @"\User\Speech\" + sndbankBox.Text + @"\" + displayItem.sound.Name))
                File.Delete(Program.exeloc + @"\User\Speech\" + sndbankBox.Text + @"\" + displayItem.sound.Name);
            displayItem.sound = new SoundInfo(new FileInfo(Program.exeloc + @"\User\Speech\" + displayItem.name));

            dSoundListbox.Refresh();
        }

        private void dSoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var displayItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];

            if (displayItem.defaultSound)
            {
                restoreBtn.Enabled = false;
            }
            else
            {
                restoreBtn.Enabled = true;
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Program.exeloc + @"\DWARand Temp"))
                Directory.Delete(Program.exeloc + @"\DWARand Temp", true);

            Main main = new Main(new string[0]);
            main.Show();
            Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            var displayItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];
            MessageBox.Show(displayItem.description, displayItem.displayName + " - Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ttsBtn_Click(object sender, EventArgs e)
        {
            var displayItem = (SoundDisplay)dSoundListbox.Items[dSoundListbox.SelectedIndex];
            TTSDialog dialog = new TTSDialog(displayItem, savedTTSIndex);

            dialog.ShowDialog();

            if (dialog.confirm)
            {
                dSoundListbox.Items[dSoundListbox.SelectedIndex] = dialog.displayItem;
                savedTTSIndex = dialog.savedIndex;

                dSoundListbox.Refresh();
            }
        }
    }
}
