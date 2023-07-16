using NextBlast.Controladores.Taladro;
using NextBlast.Global;
using NextBlast.helper;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.Grafico
{
    public class TaladroGrafico
    {
        ImportadorTaladroControlador itc = new ImportadorTaladroControlador();
        TaladroControlador tc = new TaladroControlador();
        datosGlobal objGlobal = datosGlobal.GetInstancia();

        // TALADROS
        public async Task drawTaladros(
            PaintEventArgs e,
            float coorX, 
            float coorY, 
            bool verProyeccion,
            bool simularDetonacion, 
            bool seleccionarsuperficiesecuencia,
            bool seleccioarfondosecuencia,
            bool seleccionarsuperficiesecuenciaLibre, 
            bool seleccioarfondosecuenciaLibre)
        {
            Pen lapiz = new Pen(objGlobal.configuracion.colorDefaultTaladro,
                (float)objGlobal.configuracion.grosorTaladro);

            for (int i = 0; i <objGlobal.taladros.Count; i++)
            {
                double r = 0;
                if (objGlobal.taladros[i].Diametro != 0) r = (objGlobal.taladros[i].Diametro * 0.001 + objGlobal.configuracion.tamDisenoTaladro * 0.01) * 0.5; else r = objGlobal.configuracion.tamDisenoTaladro * 0.5 * 0.01;

                // TALADRO ENCONTRADO ------- --------------------------------------------------------------------
                bool condi = tc.taladroEncontrado(new PointF((float)(objGlobal.taladros[i].Coorx_cresta_t),
                    (float)(objGlobal.taladros[i].Coory_cresta_t_design)), (float)(2.2 * r), coorX, coorY);

                if (condi)
                {
                    lapiz = new Pen(objGlobal.configuracion.colorTaladroSeleccionado,
                (float)objGlobal.configuracion.grosorTaladro);

                    r += 0.1f;
                }

                // -----------------------------------------------------------------------------------------------    

                // superior
                RectangleF rec = new RectangleF((float)(objGlobal.taladros[i].Coorx_cresta_t_design - r),
                    -(float)(objGlobal.taladros[i].Coory_cresta_t_design + r), (float)(2 * r), (float)(2 * r));

                // proyeccion taladro
                //PointF p1 = new PointF((float)(taladros[i].Coorx_cresta_t_design),
                //    -(float)(taladros[i].Coory_cresta_t_design));

                //PointF p2 = new PointF((float)(taladros[i].Coorx_piso_t_design),
                //    -(float)(taladros[i].Coory_piso_t_design));

                //string l1 = Math.Round(taladros[i].Coorx_cresta_t_design, 2).ToString();
                //string l2 = Math.Round(taladros[i].Coory_cresta_t_design, 2).ToString();

                //e.Graphics.DrawString(taladros[i].label, new Font("Arial", (float)tamLabel * 0.01f), lapizDefault.Brush,
                //    new PointF((float)(taladros[i].Coorx_cresta_t_design + 0.80 * r + disXLabel * 0.01f),
                //    -(float)(taladros[i].Coory_cresta_t_design + 0.80 * r + disYLabel * 0.01f)));

                if (objGlobal.configuracion.verTaladroLabel)
                {
                    e.Graphics.DrawString(
                        objGlobal.taladros[i].Label,
                        new Font("Arial", (float)objGlobal.configuracion.tamLabelTaladro), 
                        new SolidBrush(objGlobal.configuracion.colorLabelTaladro),
                        new PointF((float)(objGlobal.taladros[i].Coorx_cresta_t_design + 0.80 * r + objGlobal.configuracion.coorXLabelTaladro * 0.01f),
                        -(float)(objGlobal.taladros[i].Coory_cresta_t_design + 0.80 * r + objGlobal.configuracion.coorYLabelTaladro * 0.01f)));
                }

                //if (verProfundidad)
                //{
                //    string prof = string.Format("{0:N2} m", taladros[i].Profundidad_t);
                //    var font = new Font("Arial", (float)tamLabel);
                //    var sizeProf = e.Graphics.MeasureString(prof, font);
                //    e.Graphics.DrawString(prof, font, new SolidBrush(taladros[i].colorProfundidad),
                //        new PointF((float)(taladros[i].Coorx_cresta_t_design - (sizeProf.Width / 2)),
                //        -(float)(taladros[i].Coory_cresta_t_design + r + sizeProf.Height)));
                //}

                //if (verKgTaladro)
                //{
                //    var kg = (from c in carga where c.Idtaladro == taladros[i].Idtaladro && c.tipo != 2 select c.Kgexplosivo).Sum();

                //    string Kg = string.Format("{0:N2} kg", kg);
                //    var fontKg = new Font("Arial", (float)tamLabel);
                //    var sizeProf = e.Graphics.MeasureString(Kg, fontKg);
                //    e.Graphics.DrawString(Kg, fontKg, lapizDefault.Brush,
                //        new PointF((float)(taladros[i].Coorx_cresta_t_design - (sizeProf.Width / 2)),
                //        -(float)(taladros[i].Coory_cresta_t_design - r * 1.2)));
                //}


                //// --------- DIBUJAR  -------------------------------------------------------------
                e.Graphics.DrawEllipse(lapiz, rec);
            }
        }
    }
}
