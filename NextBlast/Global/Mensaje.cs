using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Global
{
    public class Mensaje
    {
        public static void Msj(string mensaje, string titulo = "")
        {
            MessageBox.Show(mensaje, titulo);
        }

        public static void MsjInformacion(string mensaje, string titulo = "")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsjError(string mensaje, string archivo, Exception e, bool verMensaje = true, string titulo = "Ha ocurrido un inconveniente")
        {
            if (verMensaje)
            {
                string mensajeFinal = "";
                if (InformacionSoftware.isProduccion)
                {
                    mensajeFinal = mensaje;
                }
                else
                {
                    mensajeFinal = mensaje + "\n" + e.Message + "\n" + e.StackTrace;
                }
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Error error = new Error
            //{
            //    id = 0,
            //    accion = "i",
            //    codigo = string.Format("{0:N8}", e.HResult),
            //    detalle = e.StackTrace,
            //    estado = EstadoConstante.activo,
            //    linea = 0,
            //    mensaje = e.Message,
            //    tipo = 2
            //};

            //ErrorControlador errorControlador = new ErrorControlador();
            //errorControlador.saveError(error);
        }

        public static void MsjAdvertencia(string mensaje, string titulo = "")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsjExclamacion(string mensaje, string titulo = "")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool MsjConfirmacion(string mensaje, string titulo = "")
        {
            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
