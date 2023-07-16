using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.Global
{
    public class Configuracion
    {
        public double TamSimulacion = 10;
        //public bool verTiempoEntreTaladro = true;
        //public bool verTiempoPorTaladro = true;
        //public bool verTiempoConexion = true;
        //public bool verRutaFametronic = true;

        public Color colorDefaultTaladro { get; set; }
        public Color colorTaladroSeleccionado { get; set; }

        public double idConfiguracion { get; set; }
        public double tamLabelTaladro { get; set; }     // TamLabel
        public double tamDisenoTaladro { get; set; }    // TamTaladro
        public double coorXLabelTaladro { get; set; }   // Poslabelx
        public double coorYLabelTaladro { get; set; }   // Poslabely
        public Color colorLabelTaladro { get; set; }
        public double grosorTaladro { get; set; }
        public double tamLabelSecuenciamiento { get; set; }
        public double tamFlechaSecuenciamiento { get; set; }
        public double grosorFlechaSecuenciamiento { get; set; }
        public double grosorLineaSecuenciamiento { get; set; }
        public Color colorLabelSecuenciamiento { get; set; }
        public Color colorFlechaSecuenciamiento { get; set; }
        public double alfaVppCercano { get; set; }
        public double betaVppCercano { get; set; }
        public double factorAjusteVppCercano { get; set; }
        public string tipoColorbarVppCercano { get; set; }
        public double zoomMalla { get; set; }
        public double panMalla { get; set; }
        public double rotacionMalla { get; set; }
        public double stepGrillaMalla { get; set; }
        public bool isGrillaMalla { get; set; }
        public Color colorFondoMalla { get; set; }
        public Color colorGrillaMalla { get; set; }
        public string tipoLetraFigura { get; set; }
        public double tamLetraFigura { get; set; }
        public double tamLetraCotaFigura { get; set; }
        public double grosorFlechaFigura { get; set; }
        public double grosorLetraFigura { get; set; }
        public double grosorLineaFigura { get; set; }
        public double grosorPolilineaFigura { get; set; }
        public double grosorCirculoFigura { get; set; }
        public double grosorPoligonoFigura { get; set; }
        public double grosorCotaFigura { get; set; }
        public Color colorFlechaFigura { get; set; }
        public Color colorLetraFigura { get; set; }
        public Color colorLineaFigura { get; set; }
        public Color colorPolilineaFigura { get; set; }
        public Color colorCirculoFigura { get; set; }
        public Color colorPoligonoFigura { get; set; }
        public Color colorCotaFigura { get; set; }
        public double tamLabelFametronic { get; set; }
        public Color colorLabelFametronic { get; set; }
        public double grosorLineaFametronic { get; set; }
        public double grosorFlechaFametronic { get; set; }
        public Color colorFlechaFametronic { get; set; }
        public double presicionSecuenciamiento { get; set; }

        public double grosorLineaDesplazamiento { get; set; }
        public double grosorFlechaDesplazamiento { get; set; }
        public double grosorTamanoDesplazamiento { get; set; }
        public Color colorFlechaDesplazamiento { get; set; }
        public double tamanoLetraIsolinea { get; set; }
        public Color colorLetraIsolinea { get; set; }
        public double grosorLineaIsolinea { get; set; }
        public Color colorLineaIsolinea { get; set; }

        public double coorXLabelSecuenciamiento { get; set; }
        public double coorYLabelSecuenciamiento { get; set; }
        public double coorXLabelFametronic { get; set; }
        public double coorYLabelFametronic { get; set; }
        public double coorXLabelDetonadorFametronic { get; set; }
        public double coorYLabelDetonadorFametronic { get; set; }
        public double tamCirculoFigura { get; set; }

        public int maximoDetonadoresFametronic { get; set; }
        public double tamanoPuntoMonitoreo { get; set; }
        public double tamanoLetraPuntoMonitoreo { get; set; }

        public bool verResumen { get; set; }
        public bool verTiempoEntreTaladro { get; set; }
        public bool verTiempoPorTaladro { get; set; }
        public bool verTiempoConexion { get; set; }
        public bool verTiempoSecuencia { get; set; }
        public bool verFiguraTexto { get; set; }
        public bool verFiguraLinea { get; set; }
        public bool verFiguraPolilinea { get; set; }
        public bool verFiguraPoligono { get; set; }
        public bool verFiguraCirculo { get; set; }
        public bool verFiguraCota { get; set; }
        public bool verRutaFametronic { get; set; }
        public bool verTaladroLabel { get; set; }
        public bool verTaladroProfundidadValor { get; set; }
        public bool verTaladroProfundidadColor { get; set; }
        public bool verTaladroKgexplosivo { get; set; }
        public bool verDetonadorColor { get; set; }

        public double distanciaMinimaFlecha = 40;

        private double defaultDouble = 0.1;

        // Variables Norte
        public float sizeNorte { get; set; }
        //public Pen penFlechaNorte { get; set; }

        public PointF puntoNorte { get; set; }
        public float sizeLetraNorte { get; set; }
        public List<PointF> coordenadasNorte { get; set; }

        public float v_a = 6f;
        public float v_b = 6f;
        public float v_c = -6f;

        public bool verPlanos = true;


        // PARA REPORTE
        public string fecha_reporte { get; set; }
        public string hora_reporte { get; set; }
        public string elaboradopor_reporte { get; set; }
        public string revisadopor_reporte { get; set; }
        public string aprobadopor_reporte { get; set; }
        public string nrovoladura_reporte { get; set; }
        public string nivel_reporte { get; set; }
        public string malla_reporte { get; set; }

        public bool vertodos_reporte { get; set; }
        public bool vergeneral_reporte { get; set; }
        public bool vertiempos_reporte { get; set; }
        public bool verportalado_reporte { get; set; }
        public bool verentretaladro_reporte { get; set; }
        public bool verprofundidades_reporte { get; set; }
        public bool verrutafametronic_reporte { get; set; }
        public bool verisolineas_reporte { get; set; }
        public bool verdesplazamiento_reporte { get; set; }
        public bool verrelief_reporte { get; set; }
        public bool verondas_reporte { get; set; }
        public bool vertexto_reporte { get; set; }
        public bool verlinea_reporte { get; set; }
        public bool verpolilinea_reporte { get; set; }
        public bool verpoligono_reporte { get; set; }
        public bool vertaladrorelleno_reporte { get; set; }
        public bool verms_reporte { get; set; }

        public double escala1_reporte = 0.5;
        public double giro1_reporte = 0;
        public double dx1_reporte = 0;
        public double dy1_reporte = 0;

        public double escala2_reporte = 0.5;
        public double giro2_reporte = 0;
        public double dx2_reporte = 0;
        public double dy2_reporte = 0;



        public Configuracion()
        {
            colorDefaultTaladro = Color.Black;
            colorTaladroSeleccionado= Color.Blue; 
            idConfiguracion = 0;
            tamLabelTaladro = 0.7;
            tamDisenoTaladro = 10;
            coorXLabelTaladro = 0;
            coorYLabelTaladro = 0;
            colorLabelTaladro = Color.Black;
            grosorTaladro = 0.01;
            tamLabelSecuenciamiento = 8;
            tamFlechaSecuenciamiento = defaultDouble;
            grosorFlechaSecuenciamiento = defaultDouble;
            grosorLineaSecuenciamiento = defaultDouble;
            colorLabelSecuenciamiento = Color.Black;
            colorFlechaSecuenciamiento = Color.Black;
            alfaVppCercano = 1.5;
            betaVppCercano = 1.5;
            factorAjusteVppCercano = 1.5;
            tipoColorbarVppCercano = "";
            zoomMalla = 1;
            panMalla = 1;
            rotacionMalla = 0;
            stepGrillaMalla = defaultDouble;
            isGrillaMalla = false;
            colorFondoMalla = Color.Black;
            colorGrillaMalla = Color.Black;
            tipoLetraFigura = "Arial";
            tamLetraFigura = 8;
            grosorFlechaFigura = defaultDouble;
            grosorLetraFigura = defaultDouble;
            grosorLineaFigura = defaultDouble;
            grosorPolilineaFigura = defaultDouble;
            grosorCirculoFigura = defaultDouble;
            grosorPoligonoFigura = defaultDouble;
            colorFlechaFigura = Color.Black;
            colorLetraFigura = Color.Black;
            colorLineaFigura = Color.Black;
            colorPolilineaFigura = Color.Black;
            colorCirculoFigura = Color.Black;
            colorPoligonoFigura = Color.Black;
            tamLabelFametronic = 8;
            colorLabelFametronic = Color.Black;
            grosorFlechaFametronic = defaultDouble;
            colorFlechaFametronic = Color.Black;

            tamCirculoFigura = 8;

            grosorLineaDesplazamiento = defaultDouble;
            grosorFlechaDesplazamiento = defaultDouble;
            grosorTamanoDesplazamiento = defaultDouble;
            colorFlechaDesplazamiento = Color.Red;
            tamanoLetraIsolinea = defaultDouble;
            colorLetraIsolinea = Color.Red;
            grosorLineaIsolinea = defaultDouble;
            colorLineaIsolinea = Color.Red;

            coorXLabelSecuenciamiento = 0;
            coorXLabelSecuenciamiento = 0;
            coorXLabelFametronic = 0;
            coorXLabelFametronic = 0;
            coorXLabelDetonadorFametronic = 0;
            coorXLabelDetonadorFametronic = 0;

            maximoDetonadoresFametronic = 500;
            tamanoPuntoMonitoreo = 350;
            tamanoLetraPuntoMonitoreo = 0.8;

            verResumen = false;
            verTiempoEntreTaladro = true;
            verTiempoPorTaladro = true;
            verTiempoConexion = true;
            verTiempoSecuencia = false;
            verFiguraTexto = true;
            verFiguraLinea = true;
            verFiguraPolilinea = true;
            verFiguraPoligono = true;
            verFiguraCirculo = true;
            verFiguraCota = true;
            verRutaFametronic = true;
            verTaladroLabel = true;
            verTaladroProfundidadValor = false;
            verTaladroProfundidadColor = false;
            verTaladroKgexplosivo = false;
            verDetonadorColor = true;


            sizeNorte = 40f;
            //penFlechaNorte = new Pen(Color.Firebrick, 4f);
            puntoNorte = new PointF(2.5f, -30 + v_c);
            sizeLetraNorte = 10.5f;
            coordenadasNorte = cargaCoordenadasNorte();

            distanciaMinimaFlecha = 40;
        }

        public List<PointF> cargaCoordenadasNorte()
        {
            coordenadasNorte = new List<PointF>();
            coordenadasNorte.Add(new PointF(0, 0 + v_a + v_c));                   //P1
            coordenadasNorte.Add(new PointF(v_b * 1.5f, v_b + v_a + v_c));        //P2
            coordenadasNorte.Add(new PointF(0, -v_b * 2f + v_a + v_c));           //P3
            coordenadasNorte.Add(new PointF(-(v_b * 1.5f), v_b + v_a + v_c));     //P4

            return coordenadasNorte;
        }
    }
}
