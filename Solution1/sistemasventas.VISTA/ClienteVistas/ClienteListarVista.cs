using sistemasventas.VISTA.PersonasVistas;
using sistemasventas.VISTA.UsuarioVistas;
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


namespace sistemasventas.VISTA.ClienteVistas
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientesBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVistas fr = new UsuarioInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBass();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este cliente?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionado);
                dataGridView1.DataSource = bss.ListarClientesBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //VentaEditarVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           // VentaEditarVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
