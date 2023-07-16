using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Negocio
{
    public class NegocioBase
    {
        OpenFileDialog ofd = new OpenFileDialog();

        public string DialogBuscadorArchivo()
        {
            ofd.Filter = "CSV (*.csv)|*.csv|Archivo de Texto (*.txt)|*.txt|Todos los Archivos|*.*";
            ofd.Title = "Seleccione el archivo ...";

            if (ofd.ShowDialog()== DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }
    }
}
