using sistemasventas.VISTA.DetalleIngVistas;
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

namespace sistemasventas.VISTA.IngresoVistas
{
    public partial class IngresoListarVista : Form
    {
        public IngresoListarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresosBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoInsertarVista fr = new IngresoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarIngresosBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVistas fr = new IngresoEditarVistas(IdIngresoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarIngresosBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este ingreso?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdIngresoSeleccionado);
                dataGridView1.DataSource = bss.ListarIngresosBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DetalleIngInsertarVista.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //DetalleIngEditarVista.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
