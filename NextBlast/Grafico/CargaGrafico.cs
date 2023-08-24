using NextBlast.helper;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Grafico
{
    class CargaGrafico
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();

        public PaintEventArgs perfilCarga(
           PaintEventArgs e,
           Panel panel)
        {
            return e;
        }

        public PaintEventArgs drawContornoTaladro(PaintEventArgs e, double profundidad,Panel panel)
        {
            Pen lapiz = new Pen(Color.FromArgb(125, 125, 125), 2f);
            int diam = 30;
            double top = 30, bottom = 30, left = 60, rigth = 10;
            double scX = (panel.Width - left - rigth) / 50;
            double scY = (panel.Height - top - bottom) / profundidad;

            e.Graphics.TranslateTransform((float)left, (float)(panel.Height - bottom));

            e.Graphics.DrawLine(lapiz, 0, 0, 0, -(float)(profundidad * scY));
            e.Graphics.DrawLine(lapiz, 0, -(float)(profundidad * scY), -45, -(float)(profundidad * scY));
            e.Graphics.DrawLine(lapiz, 0, 0, diam, 0);
            e.Graphics.DrawLine(lapiz, diam, 0, diam, -(float)(profundidad * scY));
            e.Graphics.DrawLine(lapiz, diam, -(float)(profundidad * scY), diam + 65, -(float)(profundidad * scY));

            return e;
        }

        public PaintEventArgs drawCarga(PaintEventArgs e,
            Panel panel, double profundidad, List<CargaModelo> carga)
        {
            Pen lapiz = new Pen(Color.FromArgb(125, 125, 125), 2f);
            int diam = 30;
            double top = 30, bottom = 30, left = 60, rigth = 10;
            double scX = (panel.Width - left - rigth) / 50;
            double scY = (panel.Height - top - bottom) / profundidad;

            double dy = 0;
            for (int i = 0; i < carga.Count; i++)
            {
                var _explosivos = objGlobal.explosivos.Where(x => x.Id == carga[i].idelemento).ToList();

                if (_explosivos.Count == 0)
                {
                    break;
                }
                ExplosivoModelo explosivo = _explosivos[0];

                Pen color = new Pen(Color.Gray);
                Font letra = new Font("Arial", 9f);

                color = new Pen(explosivo.Color);

                dy += carga[i].longitud;
                double y2 = profundidad - dy;
                double y1 = y2 + carga[i].longitud;

                RectangleF rec = new RectangleF(0, -(float)(y1 * scY), diam + 1, (float)(carga[i].longitud * scY));

                Pen lapizCota = new Pen(Color.Gray, 0.05f);
                lapizCota.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                e.Graphics.DrawLine(lapizCota, -20, -(float)(y2 * scY), diam + 20, -(float)(y2 * scY));
                e.Graphics.FillRectangle(color.Brush, rec);

                var s = e.Graphics.MeasureString(explosivo.Nombre, letra);
                double posLetra = y2 + (carga[i].longitud + s.Height / scY) * 0.5;

                color = new Pen(explosivo.Color);

                string label = "";
                if (explosivo.Tipo == 2)
                {
                    label = explosivo.Nombre;
                }
                else
                {
                    label = string.Format("{0}\n{1:N2} Kg", explosivo.Nombre, carga[i].kgexplosivo);
                }
                e.Graphics.DrawString(label, letra, color.Brush, (float)(diam + 10), -(float)(posLetra * scY));


                // AGREGAR COTAS
                lapizCota.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4);
                lapizCota.CustomEndCap = bigArrow;
                lapizCota.CustomStartCap = bigArrow;

                float posXcota = -30;

                e.Graphics.DrawLine(lapizCota, posXcota, -(float)(y1 * scY), posXcota, -(float)(y2 * scY));

                string longCarga = string.Format("{0:N2} m", carga[i].longitud);
                var tamCota = e.Graphics.MeasureString(longCarga, letra);
                double posCota = y2 + (carga[i].longitud + tamCota.Height / scY) * 0.5;

                e.Graphics.FillRectangle(new Pen(Color.Gainsboro).Brush, (float)(posXcota - tamCota.Width * 0.5),
                    -(float)(posCota * scY), tamCota.Width, tamCota.Height);

                double posletraCota = y2 + (carga[i].longitud + tamCota.Height / scY) * 0.5;
                e.Graphics.DrawString(longCarga,
                    letra, new Pen(Color.DimGray).Brush, (float)(posXcota - tamCota.Width * 0.5), -(float)(posletraCota * scY));
            }
            return e;
        }
    }
}
