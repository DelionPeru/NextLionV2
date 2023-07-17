using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Database
{
    public class Conexiondb
    {
        public SQLiteConnection CreateConnection()
        {
            // Create a new database connection:
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;" +
                " Version = 3; New = True; Compress = True; ");
             // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception){}

            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {
            // Tipo Taladro
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE [tipotaladro] " +
                "(id integer NOT NULL PRIMARY KEY AUTOINCREMENT,nombre text,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Configuracion Malla
            Createsql = "CREATE TABLE [setupmalla] (id integer,zoom double," +
                "pan double,angulo double,isgrilla integer,stepgrilla double," +
                "colorfondo text,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Explosivo
            Createsql = "CREATE TABLE [explosivo] (id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                "nombre text,densidad double,vod double,rws double,energia double,iscartucho integer," +
                "longitud double,diametro double,color text,unidad text,tipo integer,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Roca
            Createsql = "CREATE TABLE [explosivo] (id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                "nombre text,densidad double,vod double,rws double,energia double," +
                "iscartucho integer,longitud double,diametro double,color text,unidad text," +
                "tipo integer,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Booster
            Createsql = "CREATE TABLE [booster] (id integer,nombre text," +
                "diametro double,longitud double,densidad double," +
                "energia double,vod double,rws double,color text," +
                "costo double,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Conector
            Createsql = "CREATE TABLE [conector] (id integer,nombre text," +
                "tiempo_superficie integer,tiempo_fondo integer," +
                "tipo integer,color text,costo double," +
                "vod double,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            // Configuracion
            Createsql = "CREATE TABLE [configuracion] (id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                "tam_label_taladro double,tam_diseno_taladro double,coor_x_label_taladro double," +
                "coor_y_label_taladro double,color_label_taladro text,grosor_taladro double," +
                "tam_label_secuenciamiento double,tam_flecha_secuenciamiento double," +
                "grosor_flecha_secuenciamiento double,grosor_linea_secuenciamiento double," +
                "color_label_secuenciamiento text,color_flecha_secuenciamiento text," +
                "coor_x_label_secuenciamiento double,coor_y_label_secuenciamiento double," +
                "alfa_vpp_cercano double,k_vpp_cercano double,factor_ajuste_vpp_cercano double," +
                "tipo_colorbar_vpp_cercano integer,zoom_malla double,pan_malla double," +
                "rotacion_malla double,step_grilla_malla double,is_grilla_malla integer,color_fondo_malla text," +
                "color_grilla_malla text,tipo_letra_figura text,tam_letra_figura double," +
                "tam_letra_cota_figura double,tam_circulo_figura double,grosor_flecha_figura double," +
                "grosor_letra_figura double,grosor_linea_figura double,grosor_polilinea_figura double," +
                "grosor_circulo_figura double,grosor_poligono_figura double,grosor_cota_figura double," +
                "color_flecha_figura text,color_letra_figura text,color_linea_figura text," +
                "color_polilinea_figura text,color_circulo_figura text,color_poligono_figura text," +
                "color_cota_figura text,tam_label_electronico double,grosor_flecha_electronico double," +
                "color_label_electronico text,grosor_linea_electronico double,color_flecha_electronico text," +
                "coor_x_label_electronico double,coor_y_label_electronico double," +
                "coor_x_label_detonador_electronico double,coor_y_label_detonador_electronico double," +
                "presicion_secuenciamiento double,grosor_linea_desplazamiento double," +
                "grosor_flecha_desplazamiento double,grosor_tamano_desplazamiento double," +
                "color_flecha_desplazamiento text,tamano_letra_isolinea double,color_letra_isolinea text," +
                "grosor_linea_isolinea double,color_linea_isolinea text,maximo_detonadores_electronico double," +
                "tamano_punto_monitoreo double,tamano_letra_punto_monitoreo double,ver_resumen integer," +
                "ver_tiempo_entre_taladro integer,ver_tiempo_por_taladro integer,ver_tiempo_conexion integer," +
                "ver_tiempo_secuencia integer,ver_figura_texto integer,ver_figura_linea integer," +
                "ver_figura_polilinea integer,ver_figura_poligono integer,ver_figura_circulo integer," +
                "ver_figura_cota integer,ver_ruta_electronico integer,ver_taladro_label integer," +
                "ver_taladro_profundidad_valor integer,ver_taladro_profundidad_color integer," +
                "ver_taladro_kgexplosivo integer,ver_detonador_color integer,distancia_minima_flecha double," +
                "fecha_reporte text,hora_reporte text,elaboradopor_reporte text,revisadopor_reporte text," +
                "aprobadopor_reporte text,nrovoladura_reporte text,nivel_reporte text,malla_reporte text," +
                "vertodos_reporte integer,vergeneral_reporte integer,vertiempos_reporte integer," +
                "verportalado_reporte integer,verentretaladro_reporte integer,verprofundidades_reporte integer," +
                "verrutafametronic_reporte integer,verisolineas_reporte integer," +
                "verdesplazamiento_reporte integer,verrelief_reporte integer,verondas_reporte integer," +
                "vertexto_reporte integer,verlinea_reporte integer,verpolilinea_reporte integer," +
                "verpoligono_reporte integer,vertaladrorelleno_reporte integer,verms_reporte integer," +
                "escala1_reporte double,giro1_reporte double,dx1_reporte double,dy1_reporte double," +
                "escala2_reporte double,giro2_reporte double,dx2_reporte double,dy2_reporte double)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();


            // Cordon Detonante
            Createsql = "CREATE TABLE [cordondetonante] (id integer NOT NULL PRIMARY KEY " +
                "AUTOINCREMENT UNIQUE,nombre text,energia double,vod double,color text," +
                "costo double,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();


            // Estado Taladro
            Createsql = "CREATE TABLE [estadotaladro] (id integer,nombre text," +
                "icono binary,color text,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            


            // Plantilla de Carga
            Createsql = "CREATE TABLE [plantillacarga_detalle] (id integer NOT NULL PRIMARY KEY " +
                "AUTOINCREMENT UNIQUE,orden integer," +
                "idexplosivo integer,longitud double,cantidad double,kgexplosivo double," +
                "tipo integer,idprimado integer,idiniciador integer,tipoiniciador integer," +
                "cantidadiniciador double,iddetonador integer,cantidaddetonador double," +
                "idbackup double,cantidadbackup double,posicion double,autocalcular integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();



            // Punto de Monitoreo
            Createsql = "CREATE TABLE [puntomonitoreo] (id integer NOT NULL PRIMARY KEY " +
                "AUTOINCREMENT UNIQUE,nombre text,coorx double,coory double," +
                "coorz double,ondap double,k double,alfa double,isdelete integer)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();



        }
    }
}
