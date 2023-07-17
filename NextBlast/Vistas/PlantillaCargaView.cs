using NextBlast.Global;
using NextBlast.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Vistas
{
    public partial class PlantillaCargaView : Form
    {
        grafico grafico;
        datosGlobal objGlobal = datosGlobal.GetInstancia();

        public PlantillaCargaView()
        {
            InitializeComponent();
        }

        private void PlantillaCargaView_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = objGlobal.primario;
            lbversion.Text = InformacionSoftware.version;
            grafico = new grafico(panelgrafico, panelgrafico);

            loadTiposTaladros();
        }

        void loadTiposTaladros()
        {
            cmbtipotaladro.Items.Add("");

            for (int i = 0; i < objGlobal.tipotaladro.Count; i++)
            {
                cmbtipotaladro.Items.Add(objGlobal.tipotaladro[i].Nombre);
            }
        }

        void validadorCajas()
        {
            if (txtdiametro.Value!=0 && txtprofundidad.Value!=0)
            {
                btnagregarCarguio.Enabled = true;
                btneliminaatCarguio.Enabled = true;
            }
            else
            {
                btnagregarCarguio.Enabled = false;
                btneliminaatCarguio.Enabled = false;
            }
        }

        private void txtdiametro_ValueChanged(object sender, EventArgs e)
        {
            validadorCajas();
        }

        private void txtprofundidad_ValueChanged(object sender, EventArgs e)
        {
            validadorCajas();
        }

        private void txtdiametro_KeyUp(object sender, KeyEventArgs e)
        {
            validadorCajas();
        }

        private void txtprofundidad_KeyUp(object sender, KeyEventArgs e)
        {
            validadorCajas();
        }
    }
}
