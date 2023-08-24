using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Global
{
    public class Conversiones
    {
        public double Convertir(TaladroModelo taladro, double profundidad)
        {
            profundidad = Math.Sqrt(Math.Pow(taladro.Coorx_cresta_t - taladro.Coorx_piso_t, 2) +
                Math.Pow(taladro.Coory_cresta_t - taladro.Coory_piso_t, 2) +
                Math.Pow(taladro.Coorz_cresta_t - taladro.Coorz_piso_t, 2));

            return profundidad;
        }

        public Tuple<double, double, double> Convertir(
            TaladroModelo taladro,
            double azimut, 
            double buzamiento,
            double profundidad)
        {
            azimut = azimut * Math.PI / 180;
            buzamiento = buzamiento * Math.PI / 180;
            double l1 = profundidad * Math.Sin(buzamiento);
            taladro.Coorx_piso_t = taladro.Coorx_cresta_t + l1 * Math.Cos(azimut);
            taladro.Coory_piso_t = taladro.Coory_cresta_t + l1 * Math.Sin(azimut);
            taladro.Coorz_piso_t = taladro.Coorz_cresta_t + profundidad * Math.Cos(buzamiento);

            return Tuple.Create(taladro.Coorx_piso_t, taladro.Coory_piso_t, taladro.Coorz_piso_t);
        }

        // (FINAL,CENTRO)
        public double getAzimut(double _x1, double _y1, double _x2, double _y2)
        {
            double angulo_giro = 0;

            if (_x1 > _x2 && _y1 > _y2)
            {
                angulo_giro = Math.Atan((_y2 - _y1) / (_x2 - _x1));
            }
            if (_x1 < _x2 && _y1 > _y2)
            {
                angulo_giro = Math.PI - Math.Abs(Math.Atan((_y2 - _y1) / (_x2 - _x1)));
            }
            if (_x1 < _x2 && _y1 < _y2)
            {
                angulo_giro = Math.PI + Math.Abs(Math.Atan((_y2 - _y1) / (_x2 - _x1)));
            }
            if (_x1 > _x2 && _y1 < _y2)
            {
                angulo_giro = 2 * Math.PI - Math.Abs(Math.Atan((_y2 - _y1) / (_x2 - _x1)));
            }
            if (Math.Round(_x1, 2) == Math.Round(_x2, 2) && _y1 > _y2)
            {
                angulo_giro = Math.PI / 2;
            }
            if (_x1 < _x2 && Math.Round(_y1, 2) == Math.Round(_y2, 2))
            {
                angulo_giro = Math.PI;
            }
            if (Math.Round(_x1, 2) == Math.Round(_x2, 2) && _y1 < _y2)
            {
                angulo_giro = 1.5 * Math.PI;
            }
            if (_x1 > _x2 && Math.Round(_y1, 2) == Math.Round(_y2, 2))
            {
                angulo_giro = 2 * Math.PI;
            }

            return angulo_giro;
        }

        public double getBuzamiento(double _x1, double _y1, double _z1, double _x2, double _y2, double _z2)
        {
            double angle = 0;
            double r = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));

            angle = Math.Atan(r / Math.Abs(_z2 - _z1));
            double a = Math.Atan(r / Math.Abs(_z2 - _z1)) * 180 / Math.PI;

            return angle;
        }

        public Color getColor(string color)
        {
            string[] data = color.Split(',');
            Color mycolor = Color.FromArgb(
                Convert.ToInt32(data[0]),
                Convert.ToInt32(data[1]),
                Convert.ToInt32(data[2]),
                Convert.ToInt32(data[3])
                );

            return mycolor;
        }
    }
}
