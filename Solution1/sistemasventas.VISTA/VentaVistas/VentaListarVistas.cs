using sistemasventas.VISTA.DetalleVentaVistas;
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

namespace sistemasventas.VISTA.VentaVistas
{
    public partial class VentaListarVistas : Form
    {
        public VentaListarVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaInsertarVistas fr = new VentaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVistas fr = new VentaEditarVistas(IdVentaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar esta venta?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdVentaSeleccionada);
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaEditarVistas.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVistas.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
