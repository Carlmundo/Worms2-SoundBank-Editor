using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand.Settings
{
    public partial class CoreSettings : UserControl
    {
        public SettingsDialog dialog;
        public CoreSettings(SettingsDialog dialog)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.dialog = dialog;

            registerCheckbox.Checked = dialog.registerOnStartup;
            logCheckbox.Checked = dialog.randomizerLog;
        }

        private void registerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dialog.registerOnStartup = registerCheckbox.Checked;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegistryHandler.Register();

            MessageBox.Show("Registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void unregisterBtn_Click(object sender, EventArgs e)
        {
            RegistryHandler.Unregister();

            MessageBox.Show("Unregistered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dialog.randomizerLog = logCheckbox.Checked;
        }
    }
}
