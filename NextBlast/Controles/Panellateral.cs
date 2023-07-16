using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.diseño
{
    public class panellateral
    {
        public bool perforacion = false;
        public bool secuencia = false;
        public bool detonacion = false;
        public bool analisis = false;
        public bool hardware = false;

        Button btnperforacion;
        Button btnsecuencia;
        Button btndetonacion;
        Button btnanalisis;
        Button btnhardware;
        Panel paneltaladros;
        Panel panelsecuencia;
        Panel paneldetonacion;
        Panel panelanalisis;
        Panel panelhardware;

        public panellateral(
            Button _btnperf,
            Button _btnsec,
            Button _btndet, 
            Button _btnana, 
            Button _btnhard,
            Panel _paneltaladros,
            Panel _panelsecuencia,
            Panel _paneldetonacion,
            Panel _panelanalisis,
            Panel _panelhardware
            )
        {
            btnperforacion = _btnperf;
            btnsecuencia = _btnsec;
            btndetonacion = _btndet;
            btnanalisis = _btnana;
            btnhardware = _btnhard;
            paneltaladros = _paneltaladros;
            panelsecuencia = _panelsecuencia;
            paneldetonacion = _paneldetonacion;
            panelanalisis = _panelanalisis;
            panelhardware = _panelhardware;

            paneltaladros.Location = new Point(66,16);
            panelsecuencia.Location = new Point(66,16);
            paneldetonacion.Location = new Point(66,16);
            panelanalisis.Location = new Point(66,16);
            panelhardware.Location = new Point(66,16);
        }

        public void check()
        {
            if (perforacion)
            {
                btnperforacion.BackColor = Color.FromArgb(0, 21, 66);
                paneltaladros.Visible = true;
            }
            else if (secuencia)
            {
                btnsecuencia.BackColor = Color.FromArgb(0, 21, 66);
                panelsecuencia.Visible = true;
            }
            else if(detonacion)
            {
                btndetonacion.BackColor = Color.FromArgb(0, 21, 66);
                paneldetonacion.Visible = true;
            }
            else if(analisis)
            {
                btnanalisis.BackColor = Color.FromArgb(0, 21, 66);
                panelanalisis.Visible = true;
            }
            else if(hardware)
            {
                btnhardware.BackColor = Color.FromArgb(0, 21, 66);
                panelhardware.Visible = true;
            }
        }

        public void updateestado(string boton)
        {
            if (boton == "perforacion")
            {
                secuencia = false;
                detonacion = false;
                analisis = false;
                hardware = false;

                panelsecuencia.Visible = false;
                paneldetonacion.Visible = false;
                panelanalisis.Visible = false;
                panelhardware.Visible = false;
            }
            else if (boton == "secuencia")
            {
                perforacion = false;
                detonacion = false;
                analisis = false;
                hardware = false;

                paneltaladros.Visible = false;
                paneldetonacion.Visible = false;
                panelanalisis.Visible = false;
                panelhardware.Visible = false;
            }
            else if (boton == "detonacion")
            {
                perforacion = false;
                secuencia = false;
                analisis = false;
                hardware = false;

                paneltaladros.Visible = false;
                panelsecuencia.Visible = false;
                panelanalisis.Visible = false;
                panelhardware.Visible = false;
            }
            else if (boton == "analisis")
            {
                perforacion = false;
                secuencia = false;
                detonacion = false;
                hardware = false;

                paneltaladros.Visible = false;
                panelsecuencia.Visible = false;
                paneldetonacion.Visible = false;
                panelhardware.Visible = false;
            }
            else if (boton == "hardware")
            {
                perforacion = false;
                secuencia = false;
                detonacion = false;
                analisis = false;

                paneltaladros.Visible = false;
                panelsecuencia.Visible = false;
                paneldetonacion.Visible = false;
                panelanalisis.Visible = false;
            }
            else
            {
                perforacion = false;
                secuencia = false;
                detonacion = false;
                analisis = false;
                hardware = false;

                paneltaladros.Visible = false;
                panelsecuencia.Visible = false;
                paneldetonacion.Visible = false;
                panelanalisis.Visible = false;
                panelhardware.Visible = false;
            }
        }

        public void updatecolor()
        {
            btnperforacion.BackColor = Color.FromArgb(0, 65, 120);
            btnsecuencia.BackColor = Color.FromArgb(0, 65, 120);
            btndetonacion.BackColor = Color.FromArgb(0, 65, 120);
            btnanalisis.BackColor = Color.FromArgb(0, 65, 120);
            btnhardware.BackColor = Color.FromArgb(0, 65, 120);
        }
    }
}
