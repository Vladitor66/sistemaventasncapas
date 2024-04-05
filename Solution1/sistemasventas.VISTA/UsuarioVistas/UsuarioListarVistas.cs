using sistemasventas.VISTA.UsuarioRolVistas;
using sistemasventas.VISTA.VentaVistas;
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

namespace sistemasventas.VISTA.UsuarioVistas
{
    public partial class UsuarioListarVistas : Form
    {
        public UsuarioListarVistas()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVistas fr = new UsuarioInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVistas fr = new UsuarioEditarVistas(IdUsuarioSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este usuario?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           VentaInsertarVistas.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVistas.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVistas.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolInsertarVistas.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void UsuarioListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuariosBass();
        }
    }
}
