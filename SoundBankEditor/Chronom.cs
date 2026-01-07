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
    public partial class Chronom : Form
    {
        public bool confirm = false;

        public Chronom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> btns = Controls.OfType<Button>().ToList();

            btns = btns.Where(x => x.Name.StartsWith("d")).ToList();

            foreach (var item in btns)
            {
                var behind = Convert.ToInt32(item.Name.Substring(1));

                var date = DateTime.UtcNow.Date.AddDays(-behind);

                item.Tag = date;

                string normalizedDate = date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString();

                item.Text = normalizedDate;

                item.Click += Item_Click;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            var btn = (sender as Button);

            Randomizer.Daily((DateTime)btn.Tag);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            ChronomCustom dialog = new ChronomCustom();
            dialog.ShowDialog();
            if (dialog.confirm)
            {
                Randomizer.Daily(dialog.date);
            }
        }
    }
}
