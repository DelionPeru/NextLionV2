using NextBlast.Controles;
using NextBlast.Global;
using NextBlast.helper;
using NextBlast.Modelo;
using NextBlast.Negocio.Taladro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Controladores.Taladro
{
    public class ImportadorTaladroControlador
    {
        ImportadorTaladroNegocio itn = new ImportadorTaladroNegocio();
        Datagrid datagrid = new Datagrid();
        Conversiones conversiones = new Conversiones();
        datosGlobal datosGlobal = datosGlobal.GetInstancia();

        public void importarCSV(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<string[]> datos = itn.importarTaladros();

            if (datos.Count>0)
            {
                int column = 0;
                List<int> columnas = new List<int>();
                for (int i = 0; i < datos.Count; i++)
                {
                    columnas.Add(datos[i].Count());
                }

                column = columnas.Max();

                if (dgv.Columns.Count == 0)
                {
                    for (int i = 0; i < column; i++)
                    {
                        dgv.Columns.Add("", "");
                    }
                }
                datagrid.addHeader(column, dgv);

                for (int i = 0; i < datos.Count(); i++)
                {
                    dgv.Rows.Add(datos[i]);
                }
            }
            else
            {
                Mensaje.Msj("No existen Datos..","Datos");
            }
        }

        public void validar(Label repetidos,Label cortos,DataGridView dgv)
        {
            int cantidadLabel = itn.validarEtiquetasRepetidas(dgv);
            int cantidadCortos = itn.validartaladroscortos(dgv);

            if (cantidadLabel > 0)
            {
                repetidos.Text = "- Taladros con Etiqueta/Label Repetidos :" + cantidadLabel.ToString();
            }
            else
            {
                repetidos.Text = "No existen taladros repetidos";
            }

            if (cantidadCortos > 0)
            {
                cortos.Text = "- Taladros < 4m :" + cantidadCortos.ToString();
            }
            else
            {
                cortos.Text = "No existen taladros < 4m";
            }
        }

        public bool cargarTaladros(DataGridView dgvdatos, List<TaladroModelo> taladros,
            bool taladrosAdicionales, Color colorTaladro)
        {
            bool result = false;

            if (ValidaHeader(dgvdatos))
            {
                try
                {
                    if (!taladrosAdicionales)
                    {
                        taladros.Clear(); // limpia lista de taladros
                    }
                    TaladroModelo tal;
                    List<DataGridViewCell> fila;
                    int iLabel = -1, iCoorx = -1, iCoory = -1, iCota = -1, iDiam = -1,
                        iProf = -1, iRumbo = -1, iDip = -1,
                        iEsp = -1, iBur = -1;

                    // Obtener Posiciones
                    var l = dgvdatos.Rows[0].Cells.Cast<DataGridViewCell>().ToList();
                    try { iLabel = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[1]); } catch { }
                    try { iCoorx = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[2]); } catch { }
                    try { iCoory = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[3]); } catch { }
                    try { iCota = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[4]); } catch { }
                    try { iDiam = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[5]); } catch { }
                    try { iProf = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[6]); } catch { }
                    try { iRumbo = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[8]); } catch { }
                    try { iDip = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[7]); } catch { }
                    try { iEsp = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[9]); } catch { }
                    try { iBur = l.FindIndex(x => x.Value != null && x.Value.ToString() == datagrid.opcionesHeader()[10]); } catch { }

                    for (int i = 1; i < dgvdatos.Rows.Count; i++)
                    {
                        try
                        {
                            tal = new TaladroModelo();

                            fila = new List<DataGridViewCell>(); // instancia fila tipo datagridviewcell
                            fila = dgvdatos.Rows[i].Cells.Cast<DataGridViewCell>().ToList(); // convierte los datos de la fila en una lista

                            if (iLabel != -1) tal.Label = fila[iLabel].Value.ToString();

                            if (iCoorx != -1) tal.Coorx_cresta_t = Convert.ToDouble(fila[iCoorx].Value);

                            if (iCoory != -1) tal.Coory_cresta_t = Convert.ToDouble(fila[iCoory].Value);

                            if (iCota != -1) tal.Coorz_cresta_t = Convert.ToDouble(fila[iCota].Value);

                            if (iDiam != -1) tal.Diametro = Convert.ToDouble(fila[iDiam].Value);

                            if (iProf != -1) tal.Profundidad_t = Convert.ToDouble(fila[iProf].Value);

                            if (iRumbo != -1) tal.Rumbo = Convert.ToDouble(fila[iRumbo].Value);

                            if (iDip != -1) tal.Dip = Convert.ToDouble(fila[iDip].Value);

                            if (iEsp != -1) tal.Espaciamiento_t = Convert.ToDouble(fila[iEsp].Value);

                            if (iBur != -1) tal.Burden_t = Convert.ToDouble(fila[iBur].Value);

                            if (tal.Coorx_cresta_t>0 && tal.Coory_cresta_t>0)
                            {
                                if (tal.Coorx_piso_t == 0 && tal.Coory_piso_t == 0 && tal.Coorz_piso_t == 0 && tal.Profundidad_t != 0)
                                {
                                    var r = conversiones.Convertir(tal, tal.Rumbo, tal.Dip, tal.Profundidad_t);
                                    tal.Coorx_piso_t = r.Item1;
                                    tal.Coory_piso_t = r.Item2;
                                    tal.Coorz_piso_t = r.Item3;
                                }
                                else if (tal.Coorx_piso_t != 0 && tal.Coory_piso_t != 0 && tal.Coorz_piso_t != 0 && tal.Profundidad_t == 0)
                                {
                                    tal.Profundidad_t = conversiones.Convertir(tal, tal.Profundidad_t);
                                    tal.Rumbo = conversiones.getAzimut(tal.Coorx_piso_t, tal.Coory_piso_t, tal.Coorx_cresta_t, tal.Coory_cresta_t);
                                    tal.Dip = conversiones.getBuzamiento(tal.Coorx_cresta_t, tal.Coory_cresta_t, tal.Coorz_cresta_t,
                                        tal.Coorx_piso_t, tal.Coory_piso_t, tal.Coorz_piso_t);
                                }
                                else
                                {
                                    tal.Coorx_piso_t = tal.Coorx_cresta_t;
                                    tal.Coory_piso_t = tal.Coory_cresta_t;
                                    tal.Coorz_piso_t = tal.Coorz_cresta_t;
                                }

                                taladros.Add(tal);
                            }                           
                        }
                        catch (Exception)
                        {

                        }
                   
                    }


                    // Obtener parámetros iniciales para panelGráfico
                    if (taladros.Count>0)
                    {
                        datosGlobal.xmin = taladros.Select(x => x.Coorx_cresta_t).ToList().Min();
                        datosGlobal.ymin = taladros.Select(y => y.Coory_cresta_t).ToList().Min();
                        datosGlobal.xprom = taladros.Select(x => x.Coorx_cresta_t).ToList().Average();
                        datosGlobal.yprom = taladros.Select(y => y.Coory_cresta_t).ToList().Average();

                        int idHole = taladros.Select(t=>t.Id).ToList().Max()+1;

                        foreach (var hole in taladros)
                        {
                            hole.Id = idHole;
                            hole.Coorx_cresta_t_design = hole.Coorx_cresta_t - datosGlobal.xprom;
                            hole.Coory_cresta_t_design = hole.Coory_cresta_t - datosGlobal.yprom;
                            hole.Coorx_piso_t_design = hole.Coorx_piso_t - datosGlobal.xprom;
                            hole.Coory_piso_t_design = hole.Coory_piso_t - datosGlobal.yprom;

                            idHole++;
                        }
                    }
                }
                catch (Exception)
                {  }
            
                result = true;
            }
            return result;
        }

        public bool ValidaHeader(DataGridView dgvdatos)
        {
            bool condi = new bool();
            int columnas = dgvdatos.Columns.Count;

            //------------- ENCONTRAR CABECERA PRINCIPAL ---------------------
            try
            {
                List<DataGridViewCell> fila = new List<DataGridViewCell>();
                fila = dgvdatos.Rows[0].Cells.Cast<DataGridViewCell>().ToList();
                var c = fila.Where(x => x.Value != null).ToList();


                if (c.Exists(x => x.Value.Equals(datagrid.opcionesHeader()[1])) &&
                    c.Exists(x => x.Value.Equals(datagrid.opcionesHeader()[2])) &&
                    c.Exists(x => x.Value.Equals(datagrid.opcionesHeader()[3])))
                {
                    //----------------- ENCONTRAR REPETIDOS ---------------------------------
                    if (c.Select(x => x.Value).Distinct().ToList().Count() == c.Count())
                    {
                        condi = true;
                    }
                    else
                    {
                        condi = false;
                    }
                }
                else
                {
                    condi = false;
                }
            }
            catch (Exception)
            {
                condi = false;
            }

            return condi;
        }
    }
}
