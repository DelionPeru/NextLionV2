using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.diseño
{
    public class diseñoInterface
    {
        public void posicionMenu(Panel panel, Form principal)
        {
            float w = (principal.Width - panel.Width) / 2;
            float h = (principal.Height - panel.Height) / 2;

            panel.Location = new Point((int)w, (int)h);
        }

        public MenuStrip location(MenuStrip menu)
        {
            int ancho = 0;

            for (int i = 0; i < menu.Items.Count; i++)
            {
                ancho += menu.Items[i].Width;
            }

            menu.Padding = new Padding((menu.Width - ancho) / 2, 2, 0, 2);

            return menu;
        }

        public FlowLayoutPanel locationMenuHerramientas(FlowLayoutPanel menu)
        {
            int ancho = 0;

            for (int i = 1; i < menu.Controls.Count; i++)
            {
                ancho += menu.Controls[i].Width;
            }

            menu.Controls[0].Width = Convert.ToInt32((menu.Width - ancho) * 0.5);
            //menu.Padding = new Padding((menu.Width - ancho) / 2, 2, 0, 2);

            return menu;
        }

        public void sidebar(Panel paneltaladro)
        {

        }
    }
}
