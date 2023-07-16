using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Modelo
{
    public class TaladroModelo
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Coorx_cresta_t { get; set; }
        public double Coory_cresta_t { get; set; }
        public double Coorz_cresta_t { get; set; }
        public double Coorx_cresta_r { get; set; }
        public double Coory_cresta_r { get; set; }
        public double Coorz_cresta_r { get; set; }
        public double Coorx_piso_t { get; set; }
        public double Coory_piso_t { get; set; }
        public double Coorz_piso_t { get; set; }
        public double Coorx_piso_r { get; set; }
        public double Coory_piso_r { get; set; }
        public double Coorz_piso_r { get; set; }
        public double Rumbo { get; set; }
        public double Dip { get; set; }
        public double Altura { get; set; }
        public double Sobreperfo { get; set; }
        public double Profundidad_t { get; set; }
        public double Profundidad_r { get; set; }
        public double Burden_t { get; set; }
        public double Espaciamiento_t { get; set; }
        public double Burden_r { get; set; }
        public double Espaciamiento_r { get; set; }
        public double Diametro { get; set; }
        public bool Agua { get; set; }
        public double MetrosAgua { get; set; }
        public bool Visible { get; set; }
        public bool Inicio { get; set; }
        public int IdtipoTaladro { get; set; }
        public int IdestadoTaladro { get; set; }
        public int Idgeomecnica { get; set; }
        public bool Seleccionado { get; set; }
        public int Idevento { get; set; } // VOD, Densidad
        public int Isdelete { get; set; }
        public bool Near { get; set; }

        public double Coorx_cresta_t_design { get; set; }
        public double Coory_cresta_t_design { get; set; }
        public double Coorx_piso_t_design { get; set; }
        public double Coory_piso_t_design { get; set; }

        public TaladroModelo(){
            Diametro = 270;
            Visible = true;
            Seleccionado = false;
            Isdelete = 0;
            IdtipoTaladro = 1; // Produccion
            Profundidad_t = 10;
            Altura = 10;
            Agua = false;
            MetrosAgua = 0;
            IdestadoTaladro = 1; // Perforado
            Near = false;
        }
    }
}
