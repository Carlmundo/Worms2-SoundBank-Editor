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
    public partial class DailySettings : UserControl
    {
        public List<DailySoundbank> temp = new List<DailySoundbank>();
        public DailySettings(List<DailySoundbank> banks)
        {
            InitializeComponent();
            DoubleBuffered = true;

            temp = banks;
        }

        private void DailySettings_Load(object sender, EventArgs e)
        {
            sndbanksChckBox.DisplayMember = "Name";
            sndbanksChckBox.ValueMember = "Name";
            foreach (var item in OptionsHandler.options.dailySoundbanks)
            {
                sndbanksChckBox.Items.Add(item, item.Enabled);
            }
        }

        private void sndbanksChckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                temp[e.Index].Enabled = true;
            else
                temp[e.Index].Enabled = false;
        }

        private void selallBnt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sndbanksChckBox.Items.Count; i++)
            {
                sndbanksChckBox.SetItemChecked(i, true);
            }
        }

        private void deselallBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sndbanksChckBox.Items.Count; i++)
            {
                sndbanksChckBox.SetItemChecked(i, false);
            }
        }
    }
}
