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
    public partial class SaveBankDialog : Form
    {
        public string bankName;
        public bool confirm = false;

        public SaveBankDialog(string name)
        {
            InitializeComponent();

            nameBox.Text = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            bankName = nameBox.Text;

            var invalidChars = Path.GetInvalidPathChars().ToList();
            invalidChars.Add('*');
            invalidChars.Add('/');
            invalidChars.Add('\\');

            if (invalidChars.Any(bankName.Contains) || string.IsNullOrWhiteSpace(bankName))
            {
                MessageBox.Show("Invalid Soundbank name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            confirm = true;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            confirm = false;
            Close();
        }
    }
}
