using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Modelo
{
    public class CargaModelo
    {
        public int id { get; set; }
        public int idtaladro { get; set; }
        public int idelemento { get; set; }
        public int iscalcular { get; set; }
        public int isexplosivo { get; set; }
        public double longitud { get; set; }
        public double kgexplosivo { get; set; }
        public double unidades { get; set; }
    }
}
