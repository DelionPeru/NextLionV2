using NextBlast.Global;
using NextBlast.helper;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Controladores.Taladro
{
    public class TaladroControlador
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();
        
        public void encontrarCercanos(
            List<TaladroModelo> taladros,
            double distancia)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < taladros.Count; i++)
            {
                for (int j = 0; j < taladros.Count; j++)
                {
                    if (taladros[i].Label != taladros[j].Label)
                    {
                        double r = Math.Pow(
                            Math.Pow(taladros[i].Coorx_cresta_t - taladros[j].Coorx_cresta_t, 2) +
                            Math.Pow(taladros[i].Coory_cresta_t - taladros[j].Coory_cresta_t, 2) +
                            Math.Pow(taladros[i].Coorz_cresta_t - taladros[j].Coorz_cresta_t, 2)
                            , 0.5f);

                        if (r <= distancia)
                        {
                            indices.Add(i);
                        }
                    }
                }
            }

            objGlobal.indicestaladros_cercanos = indices.Distinct().ToList();

            if (objGlobal.indicestaladros_cercanos.Count == 0)
            {
                Mensaje.Msj("No existen Pozos menores a " + distancia.ToString() + " m");
            }
        }

        public bool taladroEncontrado(
            PointF p,
            float diametro,
            float xMouse,
            float yMouse)
        {
            bool condi = false;
            RectangleF rec = new RectangleF(p.X - 0.5f * diametro, p.Y - 0.5f * diametro, diametro, diametro);
            condi = rec.Contains(xMouse, yMouse);
            return condi;
        }

        public Tuple<float, float, float> acercar(
            Panel panelGrafico,
            float zoom,
            float dragx,
            float dragy)
        {
            PointF p1 = new PointF();
            PointF p2 = new PointF();

            for (int i = 0; i < 30; i++)
            {
                float cx = panelGrafico.Bounds.Width * 0.5f;
                float cy = panelGrafico.Bounds.Height * 0.5f;

                p1 = scr2obj(cx, cy, zoom, dragx, dragy);

                zoom *= 1.1f; // zoom in

                p2 = obj2scr(p1.X, p1.Y, zoom, dragx, dragy);

                dragx += (cx - p2.X) / zoom;
                dragy += (cy - p2.Y) / zoom;
            }

            return Tuple.Create(zoom, dragx, dragy);
        }

        public PointF scr2obj(
            float sx, 
            float sy, 
            float zoom, 
            float dragx, 
            float dragy)
        {
            PointF punto = new PointF();
            punto.X = ((sx / zoom) - dragx);
            punto.Y = ((sy / zoom) - dragy);
            return punto;
        }

        public PointF obj2scr(
            float ox, 
            float oy, 
            float zoom, 
            float dragx, 
            float dragy)
        {
            PointF punto = new PointF();
            punto.X = ((dragx + ox) * zoom);
            punto.Y = ((dragy + oy) * zoom);
            return punto;
        }
    }
}
