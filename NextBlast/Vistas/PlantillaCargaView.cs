using NextBlast.Global;
using NextBlast.Grafico;
using NextBlast.helper;
using NextBlast.Modelo;
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
        ComboBox CB = new ComboBox();
        CargaGrafico cargaGrafico = new CargaGrafico();
        List<CargaModelo> carga = new List<CargaModelo>();

        public PlantillaCargaView()
        {
            InitializeComponent();
        }

        private void PlantillaCargaView_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = objGlobal.primario;
            lbversion.Text = InformacionSoftware.version;
            grafico = new grafico(panelgrafico, panelgrafico);

            dgvCarguio.EditingControlShowing += 
                new DataGridViewEditingControlShowingEventHandler(dgvCarguio_EditingControlShowing);

            loadTiposTaladros();
            loadExplosivos();

            panelgrafico.Invalidate();
        }

        void dgvCarguio_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox comboBox = e.Control as ComboBox;

            if (comboBox != null)
            {
                comboBox.SelectedIndexChanged -= new EventHandler(comboBox_SelectedIndexChanged);

                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }

        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;
            int rowSelected = dgvCarguio.CurrentRow.Index;
            ExplosivoModelo explosivo = new ExplosivoModelo();

            // Buscar explosivo
            if (selectedIndex>0)
            {
                explosivo = objGlobal.explosivos[selectedIndex];
                autocalcular(rowSelected,explosivo);
                //MessageBox.Show("Fila Seleccionada = " + dgvCarguio.CurrentRow);
            }
        }

        void loadTiposTaladros()
        {
            cmbtipotaladro.Items.Add("");

            for (int i = 0; i < objGlobal.tipotaladro.Count; i++)
            {
                cmbtipotaladro.Items.Add(objGlobal.tipotaladro[i].Nombre);
            }
        }        

        void loadExplosivos()
        {
            for (int i = 0; i < objGlobal.explosivos.Count; i++)
            {
                CB.Items.Add(objGlobal.explosivos[i].Nombre);
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

        void addRowCarguio()
        {             
            if (Convert.ToDouble(txtdiametro.Value)!=0 && Convert.ToDouble(txtprofundidad.Value)!=0)
            {
               // double l = autocalcularLongitud();

                CargaModelo cm = new CargaModelo
                {
                    idelemento = -1,
                    idtaladro = -1,
                    iscalcular = -1,
                    isexplosivo = -1,
                    kgexplosivo = -1,
                    longitud = -1,
                    unidades = -1
                };

                if (dgvCarguio.Rows.Count==0)
                {
                    cm.id = 0;
                }
                else
                {
                    cm.id = carga[carga.Count-1].id + 1;
                }
                carga.Add(cm);

                dgvCarguio.Rows.Add(dgvCarguio.Rows.Count + 1, "", false, 0, 0);
                ((DataGridViewComboBoxColumn)dgvCarguio.Columns[1]).DataSource = CB.Items;
            }
            else
            {
                Mensaje.MsjAdvertencia("Falta agregar información de Diámetro o Profundiadad", "Advertencia");
            }
        }

        private void btnagregarCarguio_Click(object sender, EventArgs e)
        {
            addRowCarguio();
            dgvCarguio.Invalidate();
        }

        public void eventoCheck(int index)
        {           
            for (int i = 0; i < dgvCarguio.Rows.Count; i++)
            {
                if (i != index)
                {
                    dgvCarguio.Rows[i].Cells[2].Value = false;
                }
            }
            dgvCarguio.Rows[index].Cells[2].Value = Convert.ToBoolean(dgvCarguio.Rows[index].Cells[2].Value) == true ? false : true;
            //autocalcular();
        }

        private void dgvCarguio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int rowSelected = dgvCarguio.CurrentRow.Index;
            dgvCarguio.ClearSelection();

            try
            {
                autocalcular(rowSelected);

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                    e.ColumnIndex == 2 && e.RowIndex >= 0)
                {
                    int index = dgvCarguio.CurrentRow.Index;
                    eventoCheck(index);
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.ColumnIndex == 4 && e.RowIndex >= 0)
                {
                    //int index = dgvCarguio.CurrentRow.Index;
                    //if (profundidadDiferente && taladroBase.Idtaladro == -1)
                    //{
                    //    _mensajeGlobal.MsjInformacion("Seleccione el taladro base para configurar sus cargas");
                    //    return;
                    //}
                    //editarCarga(index);
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                   e.ColumnIndex == 5 && e.RowIndex >= 0)
                {
                    //int index = dgvCarguio.CurrentRow.Index;

                    //deleteRowCarguio(index);
                    ////deleteRowPrimado(index);
                }
            }
            catch (Exception err)
            {
                Mensaje.Msj(err.Message, "editTaladroview");
            }

            panelgrafico.Invalidate();
        }

        private void dgvCarguio_KeyDown(object sender, KeyEventArgs e)
        {
            dgvCarguio.ClearSelection();
        }

        void autocalcular(int row, ExplosivoModelo explosivo)
        {
            //dgvCarguio.DefaultCellStyle.BackColor = Color.Gainsboro;

            dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.Gainsboro;
            dgvCarguio.Rows[row].Cells[4].Style.BackColor = Color.Gainsboro;

            double val1 = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
            double val2 = Convert.ToDouble(dgvCarguio.Rows[row].Cells[4].Value);
            if (val1 == 0)
            {
                dgvCarguio.Rows[row].Cells[3].Value = 0;
            }
            if (val2 == 0)
            {
                dgvCarguio.Rows[row].Cells[4].Value = 0;
            }

            double longitud = -1;
            double kgexplosivo = -1;
            double diametro = Convert.ToDouble(txtdiametro.Value);
            double profundidad = Convert.ToDouble(txtprofundidad.Value);
            double unidades = 0;
            int iscalcular = -1;

            if (explosivo != null)
             {
                // Pregunta por el tipo de carguio
                if (rblongitud.Checked)
                {
                    dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                    dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                    dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                    if (explosivo.IsCartucho == 1)
                    {
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Unidades";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 un";

                        unidades = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                        longitud = unidades * explosivo.Longitud;
                        kgexplosivo = Math.PI * Math.Pow(explosivo.Diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                    }
                    else
                    {
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Metros";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 m";

                        if (explosivo.Tipo==1)
                        {
                            longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                            kgexplosivo = Math.PI * Math.Pow(diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                        }
                        else
                        {
                            longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                        }
                    }
                                       
                    if (longitud > 0)
                    {
                        dgvCarguio.Rows[row].Cells[4].Value = Math.Round(kgexplosivo, 2);
                    }
                }

                if (rbmasa.Checked)
                {
                    if (explosivo.Tipo == 1) // Explosivo
                    {
                        if (explosivo.IsCartucho == 1)
                        {
                            dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                            //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Unidades";
                            //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 un";

                            dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                            dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                            unidades = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                            longitud = unidades * explosivo.Longitud;
                            kgexplosivo = Math.PI * Math.Pow(explosivo.Diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                        }
                        else
                        {
                            dgvCarguio.Rows[row].Cells[4].ReadOnly = false;
                            //dgvCarguio.Rows[row].Cells[4].ToolTipText = "Kg Explosivo";
                            //dgvCarguio.Rows[row].Cells[4].Style.Format = "Kg";

                            dgvCarguio.Rows[row].Cells[3].ReadOnly = true;
                            dgvCarguio.Rows[row].Cells[4].Style.BackColor = Color.White;

                            kgexplosivo = Convert.ToDouble(dgvCarguio.Rows[row].Cells[4].Value);
                            longitud = kgexplosivo / (Math.PI * Math.Pow(diametro * 0.001, 2) * explosivo.Densidad * 1000 * 0.25);
                            if (kgexplosivo > 0)
                            {
                                dgvCarguio.Rows[row].Cells[3].Value = Math.Round(longitud, 2);
                            }
                        }

                    }

                    if (explosivo.Tipo == 2)
                    {
                        dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Metros";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 m";

                        dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                        dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                        longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                    }
                }
            }
            else
            {
                longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
            }

            int isexplosivo = 0;
            // Pasar información a lista carga
            carga[row].idelemento = explosivo.Id;
            carga[row].iscalcular = iscalcular;
            if (explosivo.Tipo==1)
            {
                isexplosivo = 1;
            }
            carga[row].isexplosivo = isexplosivo;
            carga[row].kgexplosivo = kgexplosivo;
            carga[row].longitud = longitud;
            carga[row].unidades = unidades;
        }

        void autocalcular(int row)
        {
            //dgvCarguio.DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.Gainsboro;            
            dgvCarguio.Rows[row].Cells[4].Style.BackColor = Color.Gainsboro;

            double val1 = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
            double val2 = Convert.ToDouble(dgvCarguio.Rows[row].Cells[4].Value);
            if (val1==0)
            {
                dgvCarguio.Rows[row].Cells[3].Value = 0;
            } 
            if (val2==0)
            {
                dgvCarguio.Rows[row].Cells[4].Value = 0;
            }

            ExplosivoModelo explosivo = new ExplosivoModelo();
            double longitud = -1;
            double kgexplosivo = -1;
            double diametro = Convert.ToDouble(txtdiametro.Value);
            double profundidad = Convert.ToDouble(txtprofundidad.Value);
            double unidades = 0;
            string explo = dgvCarguio.Rows[row].Cells[1].Value.ToString();
            int iscalcular = Convert.ToBoolean(dgvCarguio.Rows[row].Cells[2].Value) == true ? 1 : 0;

            if (explo != "")
            {
                explosivo = objGlobal.explosivos.Where(e => e.Nombre == explo).ToList().Count > 0 ?
                    objGlobal.explosivos.Where(e => e.Nombre == explo).ToList()[0] : new ExplosivoModelo();
            }

            if (explosivo != null)
            {
                // Pregunta por el tipo de carguio
                if (rblongitud.Checked)
                {
                    dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                    dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                    dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                    if (explosivo.IsCartucho == 1)
                    {
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Unidades";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 un";

                        unidades = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                        longitud = unidades * explosivo.Longitud;
                        kgexplosivo = Math.PI * Math.Pow(explosivo.Diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                    }
                    else
                    {
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Metros";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 m";

                        longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                        kgexplosivo = Math.PI * Math.Pow(diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                    }
                }

                if (rbmasa.Checked)
                {
                    if (explosivo.Tipo == 1) // Explosivo
                    {
                        if (explosivo.IsCartucho == 1)
                        {
                            dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                            //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Unidades";
                            //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 un";

                            dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                            dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                            unidades = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
                            longitud = unidades * explosivo.Longitud;
                            kgexplosivo = Math.PI * Math.Pow(explosivo.Diametro * 0.001, 2) * explosivo.Densidad * longitud * 1000 * 0.25;
                        }
                        else
                        {
                            dgvCarguio.Rows[row].Cells[4].ReadOnly = false;
                            //dgvCarguio.Rows[row].Cells[4].ToolTipText = "Kg Explosivo";
                            //dgvCarguio.Rows[row].Cells[4].Style.Format = "Kg";

                            dgvCarguio.Rows[row].Cells[3].ReadOnly = true;
                            dgvCarguio.Rows[row].Cells[4].Style.BackColor = Color.White;

                            kgexplosivo = Convert.ToDouble(dgvCarguio.Rows[row].Cells[4].Value);
                            longitud = kgexplosivo / (Math.PI * Math.Pow(diametro * 0.001, 2) * explosivo.Densidad * 1000 * 0.25);
                            if (kgexplosivo > 0)
                            {
                                dgvCarguio.Rows[row].Cells[3].Value = Math.Round(longitud, 2);
                            }
                        }

                    }

                    if (explosivo.Tipo == 2)
                    {
                        dgvCarguio.Rows[row].Cells[3].ReadOnly = false;
                        //dgvCarguio.Rows[row].Cells[3].ToolTipText = "Metros";
                        //dgvCarguio.Rows[row].Cells[3].Style.Format = "0.0 m";

                        dgvCarguio.Rows[row].Cells[4].ReadOnly = true;
                        dgvCarguio.Rows[row].Cells[3].Style.BackColor = Color.White;

                        longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);

                    }
                }
            }

            else
            {
                longitud = Convert.ToDouble(dgvCarguio.Rows[row].Cells[3].Value);
            }

            int isexplosivo = 0;
            // Pasar información a lista carga
            carga[row].idelemento = explosivo.Id;
            carga[row].iscalcular = iscalcular;
            if (explosivo.Tipo == 1)
            {
                isexplosivo = 1;
            }
            carga[row].isexplosivo = isexplosivo;
            carga[row].kgexplosivo = kgexplosivo;
            carga[row].longitud = longitud;
            carga[row].unidades = unidades;
        }

        private void dgvCarguio_KeyDown_1(object sender, KeyEventArgs e)
        {
            int rowSelected = dgvCarguio.CurrentRow.Index;
            autocalcular(rowSelected);
        }

        private void dgvCarguio_KeyUp(object sender, KeyEventArgs e)
        {
            int rowSelected = dgvCarguio.CurrentRow.Index;
            autocalcular(rowSelected);
        }

        private void rbmasa_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvCarguio.Rows.Count>0)
            {
                int rowSelected = dgvCarguio.CurrentRow.Index;
                autocalcular(rowSelected);
            }
        }

        private void rblongitud_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvCarguio.Rows.Count>0)
            {
                int rowSelected = dgvCarguio.CurrentRow.Index;
                autocalcular(rowSelected);
            }
        }

        private void dgvCarguio_MouseUp(object sender, MouseEventArgs e)
        {
            int rowSelected = dgvCarguio.CurrentRow.Index;
            autocalcular(rowSelected);
        }

        private void panelgrafico_Paint(object sender, PaintEventArgs e)
        {
            cargaGrafico.drawContornoTaladro(
                e,
                Convert.ToDouble(txtprofundidad.Value),
                panelgrafico
                );
        }

        private void btneliminaatCarguio_Click(object sender, EventArgs e)
        {
            if (dgvCarguio.Rows.Count>0)
            {
                dgvCarguio.Rows.RemoveAt(dgvCarguio.Rows.Count-1);
                carga.RemoveAt(carga.Count-1);
            }
        }
    }
}
