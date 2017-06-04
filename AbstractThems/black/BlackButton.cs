using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.black
{
    class BlackButton:AbstractButton
    {
        public BlackButton()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.Text = "Это черная кнопка";
            this.ForeColor = System.Drawing.Color.White;
        }
    }
}
