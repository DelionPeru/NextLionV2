using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Grafico
{
    public class graficos
    {
        public PaintEventArgs setupGrafica(
            PaintEventArgs e,
            Panel panel,
            float zoom,
            float dragx,
            float dragy,
            float angle)
        {
            //e.Graphics.PageUnit = System.Drawing.GraphicsUnit.Inch;
            e.Graphics.ScaleTransform(zoom, zoom);
            e.Graphics.TranslateTransform(dragx + panel.Width * 0.5f, dragy + panel.Height * 0.5f); // mover al centro del panel grafico en funcion al drag
            //e.Graphics.RotateTransform(angle);
            return e;
        }
    }
}
