using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand.UI
{
    public class DCheckedListBox : CheckedListBox
    {
        public DCheckedListBox()
        {
            DoubleBuffered = true;
        }
    }
}
