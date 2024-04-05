using sistemasventas.VISTA.IngresoVistas;
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

namespace sistemasventas.VISTA.ProveedorVistas
{
    public partial class ProveedorListarVista : Form
    {
        public ProveedorListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button2_Click(object sender, EventArgs e)
        {
           ProveeInsertarVistas fr = new ProveeInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedoresBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVistas fr = new ProveeEditarVistas(IdProveedorSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedoresBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este proveedor?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdProveedorSeleccionado);
                dataGridView1.DataSource = bss.ListarProveedoresBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IngresoInsertarVista.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVistas.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeInsertarVistas.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVistas.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void ProveedorListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedoresBass();
        }
    }
}
