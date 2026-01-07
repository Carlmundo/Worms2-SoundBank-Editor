using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand.UI
{
    public partial class SoundsContainer : UserControl
    {
        public string displayName;
        public FileInfo sound;
        public SoundsContainer(string displayName, FileInfo sound)
        {
            InitializeComponent();
            this.displayName = displayName;
            this.sound = sound;

            soundnameLbl.Text = displayName;
        }
    }
}
