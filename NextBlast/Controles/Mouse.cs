using NextBlast.Global;
using NextBlast.helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Controles
{
    public class Mouse
    {
        Conversiones conversiones = new Conversiones();
        datosGlobal objGlobal = datosGlobal.GetInstancia();

        double xmouse = 0; // Coordenada X en pixel
        double ymouse = 0; // Coordenada Y en pixel
        double coorX = 0; // Coordenada X Real
        double coorY = 0; // Coordenada Y Real
        
        Panel panelgrafico;

        public Mouse(double _xmouse,
            double _ymouse, double _coorx,double _coory, Panel _panelgrafico)
        {
            xmouse = _xmouse;
            ymouse = _ymouse;
            coorX = _coorx;
            coorY = _coory;
            panelgrafico = _panelgrafico;
        }

        public void onMouseWheel(object sender, MouseEventArgs e)
        {
            xmouse = e.X;
            ymouse = e.Y;

            var dat = getCoordenadas(
                e, 
                panelgrafico,
                (float)objGlobal.dragx, 
                (float)objGlobal.dragy, 
                (float)objGlobal.zoom,
                (float)objGlobal.angle);

            coorX = dat.Item3;
            coorY = dat.Item4;

            if (e.Delta > 0)
            {
                var n1 = ZoomIn(
                    (float)xmouse,
                    (float)ymouse, 
                    (float)objGlobal.zoom,
                    (float)objGlobal.dragx,
                    (float)objGlobal.dragy, 
                    (float)objGlobal.maxZoom);

                objGlobal.dragx = n1.Item1;
                objGlobal.dragy = n1.Item2;
                objGlobal.zoom = n1.Item3;
            }
            else
            {
                var n2 = ZoomOut(
                    (float)xmouse, 
                    (float)ymouse, 
                    (float)objGlobal.zoom,
                    (float)objGlobal.dragx, 
                    (float)objGlobal.dragy, 
                    (float)objGlobal.minZoom);

                objGlobal.dragx = n2.Item1;
                objGlobal.dragy = n2.Item2;
                objGlobal.zoom = n2.Item3;
            }

            panelgrafico.Invalidate();

        }

        public Tuple<float, float, float, float, double> getCoordenadas(
            MouseEventArgs e, 
            Panel panel, 
            float dragx,
            float dragy, 
            float zoom, 
            float angle)
        {
            float x = (float)Math.Round(e.X * Math.Pow(zoom, -1) - (dragx + panel.Width * 0.5), 3);
            float y = (float)Math.Round((dragy + panel.Height * 0.5) - e.Y * Math.Pow(zoom, -1), 3);

            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            double a = conversiones.getAzimut(0,0,x,y);

            float xx = (float)(r * Math.Cos(a + angle * Math.PI / 180));
            float yy = (float)(r * Math.Sin(a + angle * Math.PI / 180));

            return Tuple.Create(x, y, xx, yy, a);
        }

        public Tuple<float, float, float> ZoomIn(
            float xMouse, 
            float yMouse, 
            float zoom, 
            float dragx, 
            float dragy, 
            float maxZoom)
        {
            PointF p1 = new PointF(); PointF p2 = new PointF();
            p1 = scr2obj(xMouse, yMouse, zoom, dragx, dragy);
            if (zoom < maxZoom)
            {
                zoom *= 1.2f; // zoom ins
            }
            else
            {
                zoom *= 1.0f;
            }

            p2 = obj2scr(p1.X, p1.Y, zoom, dragx, dragy);

            dragx += (xMouse - p2.X) / zoom;
            dragy += (yMouse - p2.Y) / zoom;

            return Tuple.Create(dragx, dragy, zoom);
        }

        public Tuple<float, float, float> ZoomOut(
            float xMouse, 
            float yMouse, 
            float zoom, 
            float dragx, 
            float dragy, 
            float minZoom)
        {
            PointF p1 = new PointF(); PointF p2 = new PointF();
            p1 = scr2obj(xMouse, yMouse, zoom, dragx, dragy);
            if (zoom > minZoom)
            {
                zoom /= 1.2f; // zoom out
            }
            else
            {
                zoom /= 1.0f;
            }

            p2 = obj2scr(p1.X, p1.Y, zoom, dragx, dragy);

            dragx += (xMouse - p2.X) / zoom;
            dragy += (yMouse - p2.Y) / zoom;

            return Tuple.Create(dragx, dragy, zoom);
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
