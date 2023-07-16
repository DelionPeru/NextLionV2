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
        }
    }
}
