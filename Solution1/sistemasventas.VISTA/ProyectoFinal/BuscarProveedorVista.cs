using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasventas.VISTA.ProyectoFinal
{
    public partial class BuscarProveedorVista : Form
    {
        public BuscarProveedorVista()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void BuscarProveedorVista_Load(object sender, EventArgs e)
        {

        }
    }
}
