using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.helper
{
    public class grafico
    {
        public Panel _panelgrafico;
        public Panel _panelColorbarRelief;

        public grafico(Panel panelgrafico, Panel panelColorbarRelief)
        {
            _panelgrafico = panelgrafico;
            _panelColorbarRelief = panelColorbarRelief;
            setupInicio();
        }

        public void setupInicio()
        {
            //---------------- Activa Doble Buffered ---------------------------------            

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           _panelgrafico, new object[] { true });

            //---------------- Activa Doble Buffered ---------------------------------            

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           _panelColorbarRelief, new object[] { true });
        }
    }
}
