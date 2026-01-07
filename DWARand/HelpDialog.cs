using DWARand.Settings;
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
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new LauncherHelp());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void randHelp_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new RandomizerHelp());
            contentPanel.Controls.RemoveAt(0);
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new LauncherHelp());
            contentPanel.Controls.RemoveAt(0);
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new DailyHelp());
            contentPanel.Controls.RemoveAt(0);
        }

        private void bankedBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new SoundbankEditorHelp());
            contentPanel.Controls.RemoveAt(0);
        }
    }
}
