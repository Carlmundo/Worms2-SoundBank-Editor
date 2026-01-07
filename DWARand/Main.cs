using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand
{
    public partial class Main : Form
    {
        public Color baseClr = Color.FromArgb(128, 64, 0);
        public Color highlightClr = Color.FromArgb(193, 96, 0);
        public Color pressedClr = Color.FromArgb(84, 43, 0);

        public Main(string[] args)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomizeBtn_MouseEnter(object sender, EventArgs e)
        {
            hintsLbl.Text = "Randomize - Create a randomized soundbank";
            randomizeBtn.BackColor = highlightClr;
        }

        private void randomizeBtn_MouseLeave(object sender, EventArgs e)
        {
            hintsLbl.Text = "Hover your mouse over one of the buttons!";
            randomizeBtn.BackColor = baseClr;
        }

        private void randomizeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            randomizeBtn.BackColor = pressedClr;
        }

        private void dailyRandomizeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            dailyRandomizeBtn.BackColor = pressedClr;
        }

        private void dailyRandomizeBtn_MouseEnter(object sender, EventArgs e)
        {
            hintsLbl.Text = "Daily - New day, new soundbank!";
            dailyRandomizeBtn.BackColor = highlightClr;
        }

        private void dailyRandomizeBtn_MouseLeave(object sender, EventArgs e)
        {
            hintsLbl.Text = "Hover your mouse over one of the buttons!";
            dailyRandomizeBtn.BackColor = baseClr;
        }

        private void settingsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            settingsBtn.BackColor = pressedClr;
        }

        private void settingsBtn_MouseEnter(object sender, EventArgs e)
        {
            hintsLbl.Text = "Settings - Change settings, duh!";
            settingsBtn.BackColor = highlightClr;
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            hintsLbl.Text = "Hover your mouse over one of the buttons!";
            settingsBtn.BackColor = baseClr;
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            RandomizeDialog dialog = new RandomizeDialog();

            dialog.Show();
            this.Close();
        }

        private void dailyRandomizeBtn_Click(object sender, EventArgs e)
        {
            //Randomizer.Daily(DateTime.UtcNow.Date);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsDialog dialog = new SettingsDialog();
            dialog.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void bankeditorBtn_MouseDown(object sender, MouseEventArgs e)
        {
            bankeditorBtn.BackColor = pressedClr;
        }

        private void bankeditorBtn_Click(object sender, EventArgs e)
        {
            SoundbankEditor editor = new SoundbankEditor();

            editor.Show();
            Close();
        }

        private void bankeditorBtn_MouseEnter(object sender, EventArgs e)
        {
            hintsLbl.Text = "Bank Editor - Edit your soundbanks";
            bankeditorBtn.BackColor = highlightClr;
        }

        private void bankeditorBtn_MouseLeave(object sender, EventArgs e)
        {
            hintsLbl.Text = "Hover your mouse over one of the buttons!";
            bankeditorBtn.BackColor = baseClr;
        }

        private void dailyRandomizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Chronom chronom = new Chronom();
                chronom.ShowDialog();
            }
            else
            {
                Randomizer.Daily(DateTime.UtcNow.Date);
            }
        }

        private void helpBtn_MouseEnter(object sender, EventArgs e)
        {
            hintsLbl.Text = "Help - How to use this program";
            helpBtn.BackColor = Color.FromArgb(224, 134, 43);
        }

        private void helpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            helpBtn.BackColor = Color.FromArgb(186, 97, 7);
        }

        private void helpBtn_MouseLeave(object sender, EventArgs e)
        {
            hintsLbl.Text = "Hover your mouse over one of the buttons!";
            helpBtn.BackColor = Color.FromArgb(216, 116, 16);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpDialog dialog = new HelpDialog();
            dialog.ShowDialog();
        }
    }
}
