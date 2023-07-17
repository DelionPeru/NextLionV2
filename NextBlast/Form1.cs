using NextBlast.Controladores.Explosivo;
using NextBlast.Controladores.Taladro;
using NextBlast.Controles;
using NextBlast.Database;
using NextBlast.diseño;
using NextBlast.Grafico;
using NextBlast.helper;
using NextBlast.vistas;
using NextBlast.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast
{
    public partial class nextblast : Form
    {
        public bool activaShit = false;
        datosGlobal objGlobal = datosGlobal.GetInstancia();
        TaladroControlador tc = new TaladroControlador();
        Conexiondb conexiondb = new Conexiondb();

        // Diseño
        diseñoInterface di = new diseñoInterface();
        sidebar side;
        panellateral panel;
        grafico grafico;
        public double xmin = 0;
        public double ymin = 0;
        public double x = 0;
        public double y = 0;
        public double xprom = 0;
        public double yprom = 0;        
        public double xmouse = 0; // Coordenada X en pixel
        public double ymouse = 0; // Coordenada Y en pixel
        public double coorXangle = 0;
        public double coorYangle = 0;
        public double coorX = 0; // Coordenada X Real
        public double coorY = 0; // Coordenada Y Real        
        public PointF pdrag = new PointF();
        public PointF p1drag = new PointF();
        public PointF p2drag = new PointF();
        public float escalaDrag = 2.0f; // -> Escala para controlar velocidad de movimiento

        ImportadorTaladroControlador itc = new ImportadorTaladroControlador();

        // Vistas
        PlantillaCargaView plantillaCargaView = new PlantillaCargaView();

        // Controles
        Mouse mouse;

        // Perforacion
        importarView importar;

        // Grafico
        TaladroGrafico taladroGrafico = new TaladroGrafico();
        graficos graficos = new graficos();
        TaladroGrafico TaladroGrafico = new TaladroGrafico();
        ExplosivoControlador explosivoControlador = new ExplosivoControlador();
        TaladroControlador taladroControlador = new TaladroControlador();

        public nextblast()
        {
            InitializeComponent();

            grafico = new grafico(panelgrafico, panelgrafico);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initDatabase();
            CheckForIllegalCrossThreadCalls = false;
            this.KeyPreview = true;

            configuracionInterfaceInicio();

            mouse = new Mouse(xmouse, ymouse, coorX, coorY, panelgrafico);
            //  Inicializar evento SCROLL DEL MOUSE
            panelgrafico.MouseWheel += new MouseEventHandler(mouse.onMouseWheel);
        }

        private void nextblast_Resize(object sender, EventArgs e)
        {
            side = new sidebar(layoutPanel);
            panel = new panellateral(
                btnperforacion, 
                btntiempos, 
                btndetonacion, 
                btnanalisis, 
                btndispositivo,
                panelTaladros,
                panelSecuencia,
                panelDetonacion,
                panelAnalisis,
                panelHardware
                );

            var r = tc.acercar(
                panelgrafico, 
                (float)objGlobal.zoom, 
                (float)objGlobal.dragx, 
                (float)objGlobal.dragy);

            objGlobal.zoom = r.Item1;
            objGlobal.dragx = r.Item2;
            objGlobal.dragy = r.Item3;    
        }


        // Database
        void initDatabase()
        {
            objGlobal.sqlite_conn = conexiondb.CreateConnection();

            // Get Explosivos
            explosivoControlador.getExplosivos();

            // Get Tipo Taladro
            taladroControlador.getAll();
        }



        // Diseño Interface
        void configuracionInterfaceInicio()
        {
            panelHerramientas.BackColor = objGlobal.primario;

            di.location(menuPrincipal);
            di.locationMenuHerramientas(panelHerramientas);
        }



        // Controles Panel lateral
        private void btnperforacion_Click(object sender, EventArgs e)
        {
            panel.updatecolor();
            panel.perforacion =!panel.perforacion;
            if (panel.perforacion)
            {
                panel.updateestado("perforacion");
                panel.check();
            }
            else
            {
                panel.updateestado("");
                panel.check();
            }
        }

        private void btntiempos_Click(object sender, EventArgs e)
        {
            panel.updatecolor();
            panel.secuencia = !panel.secuencia;
            if (panel.secuencia)
            {
                panel.updateestado("secuencia");
                panel.check();
            }
            else
            {
                panel.updateestado("");
                panel.check();
            }
        }

        private void btndetonacion_Click(object sender, EventArgs e)
        {
            panel.updatecolor();
            panel.detonacion = !panel.detonacion;
            if (panel.detonacion)
            {
                panel.updateestado("detonacion");
                panel.check();
            }
            else
            {
                panel.updateestado("");
                panel.check();
            }
        }

        private void btnanalisis_Click(object sender, EventArgs e)
        {
            panel.updatecolor();
            panel.analisis = !panel.analisis;
            if (panel.analisis)
            {
                panel.updateestado("analisis");
                panel.check();
            }
            else
            {
                panel.updateestado("");
                panel.check();
            }
        }

        private void btndispositivo_Click(object sender, EventArgs e)
        {
            panel.updatecolor();
            panel.hardware = !panel.hardware;
            if (panel.hardware)
            {
                panel.updateestado("hardware");
                panel.check();
            }
            else
            {
                panel.updateestado("");
                panel.check();
            }
        }

        private void nextblast_KeyUp(object sender, KeyEventArgs e)
        {
            activaShit = false;

            if (e.KeyData == Keys.Escape)
            {
                // Cerrar las ventanas del panel lateral
                panel.updatecolor();
                panel.updateestado("");
                panel.check();
            }
        }

        private void nextblast_KeyDown(object sender, KeyEventArgs e)
        {
            activaShit = false;
        }



        // Opciones de Perforacion
        private void btnimportar_Click(object sender, EventArgs e)
        {
            importar = new importarView();
            AddOwnedForm(importar);
            importar.ShowDialog();
        }

        private void btnNearHole_Click(object sender, EventArgs e)
        {
            tc.encontrarCercanos(objGlobal.taladros,Convert.ToDouble(txtnearhole.Value));
        }
        


        // Graficos
        private async void panelgrafico_Paint(object sender, PaintEventArgs e)
        {
            // SETUP GRAFICA
            e = graficos.setupGrafica(e, panelgrafico, (float)objGlobal.zoom,
                (float)objGlobal.dragx, (float)objGlobal.dragy, (float)objGlobal.angle);

            //e.Graphics.FillEllipse(new Pen(Color.Red).Brush,-12,-12,24,24);

            TaladroGrafico.drawTaladros(e,
                (float)coorX,
                (float)coorY,
                false,

                false,
                false,
                false,
                false,
                false);
        }



        // Mouse
        private void panelgrafico_MouseMove(object sender, MouseEventArgs e)
        {
            xmouse = e.X;
            ymouse = e.Y;

            // COORDENADAS
            var dat = mouse.getCoordenadas(
                e, 
                panelgrafico, 
                (float)objGlobal.dragx, 
                (float)objGlobal.dragy, 
                (float)objGlobal.zoom, 
                (float)objGlobal.angle);

            coorX = dat.Item1;
            coorY = dat.Item2;
        }


        // Tools Database
        private void plantillasDeCargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOwnedForm(plantillaCargaView);
            plantillaCargaView.ShowDialog();
        }

        private void nextblast_FormClosed(object sender, FormClosedEventArgs e)
        {
            objGlobal.sqlite_conn.Close();
        }
    }
}
