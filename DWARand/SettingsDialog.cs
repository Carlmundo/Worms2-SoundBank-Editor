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
    public partial class SettingsDialog : Form
    {
        public List<DailySoundbank> tempDailySoundbanks = new List<DailySoundbank>();
        public bool registerOnStartup;
        public bool randomizerLog;
        public SettingsDialog()
        {
            InitializeComponent();
            tempDailySoundbanks = new List<DailySoundbank>(OptionsHandler.options.dailySoundbanks);
            registerOnStartup = OptionsHandler.options.registerOnStartup;
            randomizerLog = OptionsHandler.options.randomizerLog;
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new CoreSettings(this));
        }

        private void dailyBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new DailySettings(tempDailySoundbanks));
            contentPanel.Controls.RemoveAt(0);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            OptionsHandler.options.dailySoundbanks = tempDailySoundbanks;
            OptionsHandler.options.registerOnStartup = registerOnStartup;
            OptionsHandler.options.randomizerLog = randomizerLog;
            OptionsHandler.Save();

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new AboutSettings());
            contentPanel.Controls.RemoveAt(0);
        }

        private void coreBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(new CoreSettings(this));
            contentPanel.Controls.RemoveAt(0);
        }
    }
}
