using NextBlast.Controladores.Taladro;
using NextBlast.Controles;
using NextBlast.Global;
using NextBlast.helper;
using NextBlast.Negocio.Taladro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.vistas
{
    public partial class importarView : Form
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();
        ImportadorTaladroControlador itc = new ImportadorTaladroControlador();
        Datagrid datagrid = new Datagrid();
        nextblast principal;

        public importarView()
        {
            InitializeComponent();
        }

        private void importarView_Load(object sender, EventArgs e)
        {
            panel1.BackColor = objGlobal.primario;
            lbversion.Text = InformacionSoftware.version;
            principal = Owner as nextblast;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            itc.importarCSV(dgvdatos);
        }

        private void btndeleterow_Click(object sender, EventArgs e)
        {
            datagrid.eliminarFilas(dgvdatos);
        }

        private void dgvdatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            itc.validar(lbetiquetasrepetidas, lbtaladroscortos, dgvdatos);
        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itc.validar(lbetiquetasrepetidas, lbtaladroscortos, dgvdatos);
        }

        private void dgvdatos_KeyUp(object sender, KeyEventArgs e)
        {
            itc.validar(lbetiquetasrepetidas, lbtaladroscortos, dgvdatos);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (itc.cargarTaladros(
                dgvdatos, 
                objGlobal.taladros, 
                chbxTaladroAdicional.Checked, 
                Color.AliceBlue))
            {
                principal.panelgrafico.Invalidate();
                this.Close();
            }
            else
            {
                Mensaje.Msj("Hubo un error al cargar datos de pozos..");
            }
        }
    }
}
