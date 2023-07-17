using NextBlast.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Controladores.Explosivo
{
    public class ExplosivoControlador
    {
        Explosivodb explosivodb = new Explosivodb();

        public void getExplosivos()
        {
            explosivodb.getAll();
        }
    }
}
