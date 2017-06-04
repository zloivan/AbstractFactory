using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.blue
{
    class BlueButton:AbstractButton
    {
        public BlueButton()
        {
            this.BackColor = System.Drawing.Color.Blue;
            this.Dock = System.Windows.Forms.DockStyle.None;
            
            this.Text = "Это синяя кнопка";
        }
    }
}
