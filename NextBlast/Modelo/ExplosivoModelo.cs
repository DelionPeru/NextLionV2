using NextBlast.Global;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Modelo
{
    public class ExplosivoModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Densidad { get; set; }
        public double Vod { get; set; }
        public double Rws { get; set; }
        public double Energia { get; set; }
        public int IsCartucho { get; set; }
        public double Longitud { get; set; }
        public double Diametro { get; set; }
        public string Color { get; set; }
        public string Unidad { get; set; }
        public int Tipo { get; set; }
        public double Costo { get; set; }
        public bool IsDelete { get; set; }

        public ExplosivoModelo()
        {
            IsDelete = false;
            Tipo = 1;
        }

        public ExplosivoModelo Clonar()
        {
            return ClonarDatos.clonarExplosivo(this);
        }
    }
}
