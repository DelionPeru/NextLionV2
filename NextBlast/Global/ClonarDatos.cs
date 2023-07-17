using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Global
{
    public class ClonarDatos
    {
        public static List<TaladroModelo> clonarTaladros(List<TaladroModelo> lista)
        {
            using (var memoriaStream = new MemoryStream())
            {
                var binarioFormatter = new BinaryFormatter();
                binarioFormatter.Serialize(memoriaStream, lista);
                memoriaStream.Position = 0;

                return (List<TaladroModelo>)binarioFormatter.Deserialize(memoriaStream);
            }
        }

        public static ExplosivoModelo clonarExplosivo(ExplosivoModelo objeto)
        {
            using (var memoriaStream = new MemoryStream())
            {
                var binarioFormatter = new BinaryFormatter();
                binarioFormatter.Serialize(memoriaStream, objeto);
                memoriaStream.Position = 0;

                return (ExplosivoModelo)binarioFormatter.Deserialize(memoriaStream);
            }
        }

    }
}
