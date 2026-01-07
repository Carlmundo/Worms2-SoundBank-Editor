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
using System.Speech.Synthesis;
using System.Threading;

namespace DWARand
{
    public partial class TTSDialog : Form
    {
        SpeechSynthesizer preview = new SpeechSynthesizer();
        SpeechSynthesizer recorder = new SpeechSynthesizer();

        public string bankName;
        public bool confirm = false;

        public SoundDisplay displayItem;

        public int savedIndex = 0;
        public TTSDialog(SoundDisplay disItem, int saved = 0)
        {
            InitializeComponent();

            displayItem = disItem;
            savedIndex = saved;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (InstalledVoice v in preview.GetInstalledVoices())
            {
                voicesBox.Items.Add(v.VoiceInfo.Name);
            }

            if(voicesBox.Items.Count > 0)
            {
                voicesBox.SelectedIndex = savedIndex;
            }
            else
            {
                MessageBox.Show("No installed TTS Voices detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (previewPrompt != null)
            {
                preview.SpeakAsyncCancel(previewPrompt);
            }

            try
            {
                recorder.SelectVoice(voicesBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Something went wrong while loading the selected TTS Voice, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            recordSpeech(inputBox.Text);

            displayItem.defaultSound = false;
            displayItem.sound = new SoundInfo(new FileInfo(output));

            confirm = true;

            recorder.SetOutputToNull();

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                preview.SelectVoice(voicesBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Something went wrong while loading the selected TTS Voice, aborting.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread thr = new Thread(new ParameterizedThreadStart(previewSpeech));
            thr.Start(inputBox.Text);
        }

        Prompt previewPrompt;

        void previewSpeech(object words)
        {
            if(previewPrompt != null)
            {
                preview.SpeakAsyncCancel(previewPrompt);
            }

            previewPrompt = preview.SpeakAsync(words.ToString());
        }

        string output;
        void recordSpeech(object words)
        {
            Directory.CreateDirectory(Program.exeloc + @"\DWARand Temp\TTS");
            output = Program.exeloc + @"\DWARand Temp\TTS\" + Program.rnd.Next() + " " + displayItem.name + " ";
            recorder.SetOutputToWaveFile(output);
            recorder.Speak(words.ToString());
        }

        private void voicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            savedIndex = voicesBox.SelectedIndex;
        }
    }
}
