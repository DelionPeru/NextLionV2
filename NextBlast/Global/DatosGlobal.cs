﻿using NextBlast.Global;
using NextBlast.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBlast.helper
{
    public class datosGlobal
    {
        private static datosGlobal _Instancia = null;
        public static datosGlobal GetInstancia()
        {
            if (_Instancia == null) { _Instancia = new datosGlobal(); }
            return _Instancia;
        }
        
        public datosGlobal() { }

        public Color primario = Color.FromArgb(0, 65, 120);
        public bool sidebarExpand = true;

        public double xmin = 0;
        public double ymin = 0;
        public double xprom = 0;
        public double yprom = 0;

        public Configuracion configuracion = new Configuracion();

        public double zoom = 1;
        public double dragx = 0;
        public double dragy = 0;
        public double angle = 0;
        public double maxZoom = 600;
        public double minZoom = 0.02;

        // Listas
        public List<TaladroModelo> taladros = new List<TaladroModelo>();
        public List<int> indicestaladros_cercanos = new List<int>();
    }
}
