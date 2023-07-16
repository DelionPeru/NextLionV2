using NextBlast.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Controles
{
    public class Datagrid
    {
        public void addHeader(int columnas, DataGridView dgv)
        {
            DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
            DataGridViewRow RowSample = new DataGridViewRow();
            List<string> lista = opcionesHeader();
            //dgv.CellValueChanged += new DataGridViewCellEventHandler(dgv_CellValueChanged);

            for (int i = 0; i < columnas; i++)
            {
                CellSample = new DataGridViewComboBoxCell();
                for (int j = 0; j < lista.Count; j++)
                {
                    CellSample.Items.Add(lista[j].ToString());
                }
                RowSample.Cells.Add(CellSample);
            }
            dgv.Rows.Add(RowSample);
        }



        public List<string> opcionesHeader()
        {
            // NO MOVER DE POSICION LOS ELEMENTOS 
            List<string> le = new List<string>();
            le.Add(" "); // [0]
            le.Add("LABEL");// [1]
            le.Add("X");// [2]
            le.Add("Y");// [3]
            le.Add("Z");// [4]
            le.Add("DIAMETRO");// [5]
            le.Add("PROFUNDIDAD");// [6]
            le.Add("DIP");// [7]
            le.Add("RUMBO");// [8]
            le.Add("ESPACIAMIENTO");// [9]
            le.Add("BURDEN");// [10]
            return le;
        }

        public void eliminarFilas(DataGridView dgv)
        {
            try
            {
                if (Mensaje.MsjConfirmacion("¿Deseas Eliminar Filas?","Eliminar"))
                {
                    List<int> ids = new List<int>();
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        ids.Add(item.Index);
                        dgv.Rows.RemoveAt(item.Index);
                    }

                    Mensaje.Msj("Filas Eliminadas Correctamente..", "Eliminar");
                }
            }
            catch (Exception)
            {
                Mensaje.MsjAdvertencia("Ocurrió un Error", "Advertencia");
            }            
        }
    }
}
