using NextBlast.Controles;
using NextBlast.Global;
using NextBlast.helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Negocio.Taladro
{
    public class ImportadorTaladroNegocio : NegocioBase
    {
        char separador = ' ';
        Datagrid datagrid = new Datagrid();

        public List<string[]> importarTaladros()
        {
            List<string[]> filas = new List<string[]>();

            // Obtener el path del archivo
            string path = DialogBuscadorArchivo();
            if (path=="")
            {
                return filas;
            }

            List<string> Rows = new List<string>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(separador);

                    Rows.Add(line);
                }
            }

            for (int i = 0; i < Rows[Rows.Count-2].Length; i++)
            {
                if (Rows[Rows.Count - 2][i] == ';')
                {
                    separador = ';';
                    break;
                }
                if (Rows[Rows.Count - 2][i] == ',')
                {
                    separador = ',';
                    break;
                }
            }


            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(separador);

                    filas.Add(values);
                }
            }

            return filas;
        }

        public int validarEtiquetasRepetidas(DataGridView dgv)
        {
            int cantidad = 0;
            int iLabel = -1;

            var l = dgv.Rows[0].Cells.Cast<DataGridViewCell>().ToList();
            try { iLabel = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[1]); } catch { }

            if (iLabel!=-1)
            {
                List<string> list = dgv.Rows
                           .OfType<DataGridViewRow>()
                           .Where(x => x.Cells[iLabel].Value != null)
                           .Select(x => x.Cells[iLabel].Value.ToString())
                           .ToList();

                List<string> result = list.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(x => x.Key)
                            .ToList();

                cantidad = result.Count();
            }

            return cantidad;
        }

        public int validartaladroscortos(DataGridView dgv)
        {
            int cantidad = 0;
            int iProfundidad = -1;

            try
            {
                var l = dgv.Rows[0].Cells.Cast<DataGridViewCell>().ToList();
                try { iProfundidad = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[6]); } catch { }

                if (iProfundidad!=-1)
                {
                    List<string> list = dgv.Rows
                               .OfType<DataGridViewRow>()
                               .Where(x => x.Cells[iProfundidad].Value != null)
                               .Select(x => x.Cells[iProfundidad].Value.ToString())
                               .ToList();

                    List<double> result = new List<double>();

                    for (int i = 1; i < list.Count; i++)
                    {
                        try
                        {
                            if (Convert.ToDouble(list[i]) < 4)
                            {
                                result.Add(Convert.ToDouble(list[i]));
                            }
                        }
                        catch (Exception)
                        { }
                                            
                    }

                    cantidad = result.Count();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return cantidad;
        }
    }
}
