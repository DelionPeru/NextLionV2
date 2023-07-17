using NextBlast.helper;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Database
{
    public class TipoTaladrodb
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();

        public ResponseModelo getAll()
        {
            ResponseModelo rm = new ResponseModelo
            {
                Status = false,
                Mensaje = "Ocurrió un Error"
            };
            
            SQLiteCommand sqlite_cmd = objGlobal.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM tipotaladro WHERE isdelete =0";

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            objGlobal.tipotaladro.Clear();

            while (sqlite_datareader.Read())
            {
                try
                {
                    TipoTaladroModelo em = new TipoTaladroModelo
                    {
                        Id = sqlite_datareader.IsDBNull(0) ? 0 : sqlite_datareader.GetInt32(0),
                        Nombre = sqlite_datareader.IsDBNull(1) ? "" : sqlite_datareader.GetString(1),
                        Color = sqlite_datareader.IsDBNull(1) ? "" : sqlite_datareader.GetString(1)
                    };
                    objGlobal.tipotaladro.Add(em);
                }
                catch (Exception)
                {
                    rm = new ResponseModelo
                    {
                        Status = false,
                        Mensaje = "Ocurrió un Error al importar desde la base de datos.."
                    };
                }
            }

            rm = new ResponseModelo
            {
                Status = true,
                Mensaje = "Success"
            };

            sqlite_cmd.Dispose();
            sqlite_datareader.Close();
            //objGlobal.sqlite_conn.Close();

            return rm;
        }
    }
}
