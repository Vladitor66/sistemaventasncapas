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

namespace sistemasventas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngListarVistas : Form
    {
        public DetalleIngListarVistas()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button2_Click(object sender, EventArgs e)
        {
            DetalleIngInsertarVistas fr = new DetalleIngInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesIngBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdDetalleIngSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVistas fr = new DetalleIngEditarVistas(IdDetalleIngSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesIngBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdDetalleIngSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este detalle?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdDetalleIngSeleccionado);
                dataGridView1.DataSource = bss.ListarDetallesIngBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleIngListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesIngBass();
        }
    }
}
