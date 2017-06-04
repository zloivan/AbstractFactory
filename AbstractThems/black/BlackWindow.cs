using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractThems.black
{
    class BlackWindow : AbstractWindow
    {
        public BlackWindow()
        {
            this.BackColor = System.Drawing.Color.Aqua;
        }
        public override void Interact(AbstractButton button)
        {
            this.Controls.Add(button);
            this.ShowDialog();
        }
    }
}
