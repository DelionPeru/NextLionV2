using NextBlast.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBlast.diseño
{
    public class sidebar
    {
        datosGlobal objGlobal = datosGlobal.GetInstancia();
        FlowLayoutPanel _side = new FlowLayoutPanel();

        public sidebar(FlowLayoutPanel side)
        {
            _side = side;
        }

        public void expandir()
        {
            if (objGlobal.sidebarExpand)
            {
                _side.Width = _side.MaximumSize.Width;
                objGlobal.sidebarExpand = false;
                //side.Width -= 10;
                //if (side.Width == side.MinimumSize.Width)
                //{
                //    expand = false;
                //    //time.Stop();
                //}

            }
            else
            {
                _side.Width = _side.MinimumSize.Width;
                objGlobal.sidebarExpand = true;
                //side.Width += 10;
                //if (side.Width == side.MaximumSize.Width)
                //{
                //    expand = true;
                //    //time.Stop();
                //}
            }
        }

        public bool expandirDatabase(bool databaseExpand, Panel side, Timer time)
        {
            bool expand = databaseExpand;

            if (expand)
            {
                side.Height -= 10;
                if (side.Height == side.MinimumSize.Height)
                {
                    expand = false;
                    time.Stop();
                }

            }
            else
            {
                side.Height += 10;
                if (side.Height == side.MaximumSize.Height)
                {
                    expand = true;
                    time.Stop();
                }
            }

            return expand;
        }

        public List<bool> closeAll(bool close, bool dataBaseExpand, Panel side, Timer time)
        {
            List<bool> lista = new List<bool>();
            if (close)
            {
                side.Height -= 10;
                if (side.Height == side.MinimumSize.Height)
                {
                    time.Stop();
                    close = !close;
                    dataBaseExpand = false;
                    lista.Add(close);
                    lista.Add(dataBaseExpand);
                }
            }
            else
            {
                close = !close;
                time.Stop();
                lista.Add(close);
                lista.Add(dataBaseExpand);
            }

            return lista;
        }

        public List<bool> expandAll(bool close, bool dataBaseExpand, bool expandSidebar,
            FlowLayoutPanel sideBar, Panel databasePanel, Timer time)
        {
            List<bool> lista = new List<bool>();

            if (!expandSidebar) // Si el sidebar está cerrado
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    expandSidebar = true;
                    lista.Add(expandSidebar);
                }
            }

            if (!dataBaseExpand) // si el database está cerrado
            {
                databasePanel.Height += 10;
                if (databasePanel.Height == databasePanel.MaximumSize.Height)
                {
                    dataBaseExpand = true;
                    lista.Add(dataBaseExpand);
                    lista.Add(!close);
                    time.Stop();
                }
            }

            return lista;
        }
    }
}
