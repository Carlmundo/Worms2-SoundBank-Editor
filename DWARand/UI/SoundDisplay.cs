using ByteSizeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWARand.UI
{
    public class SoundDisplay
    {
        public string displayName;
        public SoundInfo sound;
        public bool defaultSound;
        public string name;

        public string description;
    }

    public class SoundInfo
    {
        public string FullName;
        public string Name;
        public long Length;

        public SoundInfo(FileInfo info)
        {
            FullName = info.FullName;
            Name = info.Name;
            Length = info.Length;
        }
    }

    public class DSoundListbox : ListBox
    {
        public DSoundListbox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 16;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                var displayItem = Items[e.Index] as SoundDisplay;

                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                Brushes.Yellow : new SolidBrush(e.BackColor);

                Color textColor = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                Color.Red : Color.Cyan;


                e.Graphics.FillRectangle(brush, e.Bounds);

                if (!displayItem.defaultSound)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, 6, e.Bounds.Y + 3, 27, 10);
                    e.Graphics.DrawRectangle(Pens.White, 6, e.Bounds.Y + 3, 27, 10);
                }


                var textRect = e.Bounds;
                textRect.X += 37;

                var sizeRect = e.Bounds;
                sizeRect.X -= 16;

                ByteSize fileSize = new ByteSize();

                if (displayItem.sound != null)
                {
                    fileSize = ByteSize.FromBytes(displayItem.sound.Length);
                }

                
                TextRenderer.DrawText(e.Graphics, displayItem.displayName, e.Font, textRect, textColor, TextFormatFlags.Left);
                if (displayItem.sound != null)
                    TextRenderer.DrawText(e.Graphics, fileSize.KiloBytes.ToString() + "k", e.Font, sizeRect, textColor, TextFormatFlags.Right);
            }
            e.DrawFocusRectangle();
        }
    }
}
