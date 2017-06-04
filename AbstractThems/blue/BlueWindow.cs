using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.blue
{
    class BlueWindow : AbstractWindow
    {
        public BlueWindow()
        {
           
            this.BackColor = System.Drawing.Color.Azure;
            
        }
        public override void Interact(AbstractButton button)
        {
            this.Controls.Add(button);
            this.ShowDialog();
        }
    }
}
