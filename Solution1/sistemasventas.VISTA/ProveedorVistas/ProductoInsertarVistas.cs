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

namespace sistemasventas.VISTA.ProveedorVistas
{
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProductoInsertarVistas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = textBox1.Text;
            proveedor.Telefono = textBox2.Text;
            proveedor.Direccion = textBox3.Text;
            proveedor.Estado = textBox4.Text;

            bss.InsertarProveedorBss(proveedor);
            MessageBox.Show("Se guardo correctamente al Proveedor");
        }
    }
}
