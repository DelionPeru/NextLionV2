using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Modelo
{
    public class TipoTaladroModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<PointF> puntos = new List<PointF>();
        public int Isdelete { get; set; }
    }
}
