using sistemasventas.VISTA.ProductoVistas;
using sistemasventas.VISTA.ProveedorVistas;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasventas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVistas : Form
    {
        public ProveeInsertarVistas()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(textBox3.Text);

            bss.InsertarProveeBss(provee);
            MessageBox.Show("Se guardo correctamente el Provee");
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bssproveedor = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssproveedor.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
