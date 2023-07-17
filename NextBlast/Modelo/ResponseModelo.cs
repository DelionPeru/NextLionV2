using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Modelo
{
    public class ResponseModelo
    {
        public bool Status { get; set; }
        public object Data { get; set; }
        public string Mensaje { get; set; }

        public ResponseModelo()
        {
            Status = false;
        }
    }
}
