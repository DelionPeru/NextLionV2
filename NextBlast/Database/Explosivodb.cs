using NextBlast.Global;
using NextBlast.helper;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Database
{
    public class Explosivodb
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();
        Conversiones conversiones = new Conversiones();

        public ResponseModelo getAll()
        {
            ResponseModelo rm = new ResponseModelo {
                Status=false,
                Mensaje= "Ocurrió un Error"
            };
            
            SQLiteCommand sqlite_cmd = objGlobal.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM explosivo WHERE isdelete=0 ORDER BY tipo,iscartucho;";

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            objGlobal.explosivos.Clear();

            while (sqlite_datareader.Read())
            {
                try
                {
                    ExplosivoModelo em = new ExplosivoModelo
                    {
                        // conversiones
                        

                        Id = sqlite_datareader.IsDBNull(0) ? 0: sqlite_datareader.GetInt32(0),
                        Nombre = sqlite_datareader.IsDBNull(1)?"": sqlite_datareader.GetString(1),
                        Densidad = sqlite_datareader.GetDouble(2),
                        Vod = sqlite_datareader.GetDouble(3),
                        Rws = sqlite_datareader.GetDouble(4),
                        Energia = sqlite_datareader.GetDouble(5),
                        IsCartucho = sqlite_datareader.GetInt32(6),
                        Longitud = sqlite_datareader.GetDouble(7),
                        Diametro = sqlite_datareader.GetDouble(8),
                        Color = conversiones.getColor(sqlite_datareader.GetString(9)),
                        Unidad = sqlite_datareader.GetString(10),
                        Tipo = sqlite_datareader.GetInt32(11),
                        Costo = sqlite_datareader.GetDouble(12)
                    };  
                    objGlobal.explosivos.Add(em);
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
            sqlite_cmd.Cancel();
            sqlite_datareader.Close();
            //objGlobal.sqlite_conn.Close();

            return rm;
        }
    }
}
