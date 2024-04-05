using sistemasventas.VISTA.DetalleIngVistas;
using sistemasventas.VISTA.DetalleVentaVistas;
using sistemasventas.VISTA.ProveedorVistas;
using sistemasventas.VISTA.ProveeVistas;
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

namespace sistemasventas.VISTA.ProductoVistas
{
    public partial class ProductoListarVistas : Form
    {
        public ProductoListarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoInsertarVistas fr = new ProductoInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
           ProductoEditarVistas fr = new ProductoEditarVistas (IdProductoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este producto?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(IdProductoSeleccionado);
                dataGridView1.DataSource = bss.ListarProductosBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DetalleIngInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void ProductoListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosBass();
        }
    }
}
