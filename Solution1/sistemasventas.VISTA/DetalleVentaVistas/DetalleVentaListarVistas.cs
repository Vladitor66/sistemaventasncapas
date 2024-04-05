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

namespace sistemasventas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaListarVistas : Form
    {
        public DetalleVentaListarVistas()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesVentaBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVistas fr = new DetalleVentaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVistas fr = new DetalleVentaEditarVistas(IdDetalleVentaSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este detalle venta?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(IdDetalleVentaSeleccionado);
                dataGridView1.DataSource = bss.ListarDetallesVentaBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
