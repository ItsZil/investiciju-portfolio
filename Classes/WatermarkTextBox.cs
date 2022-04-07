using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace investiciju_portfolio.Classes
{
    public class WatermarkTextBox : TextBox
    {
        string hint;
        public string Hint
        {
            get { return hint; }
            set { hint = value; this.Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                if (!this.Focused && string.IsNullOrEmpty(this.Text)
                    && !string.IsNullOrEmpty(this.Hint))
                {
                    using (var g = this.CreateGraphics())
                    {
                        TextRenderer.DrawText(g, this.Hint, this.Font,
                            this.ClientRectangle, SystemColors.GrayText, this.BackColor, 
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.Left);
                    }
                }
            }
        }
    }
}
