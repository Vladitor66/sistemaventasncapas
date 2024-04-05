using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasventas.BSS;
using sistemasventas.VISTA.ClienteVistas;
using SistemasVentas.BSS;

namespace sistemasventas.VISTA.ProyectoFinal
{
    public partial class AdministradorPersonaVista : Form
    {
        public AdministradorPersonaVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonasBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonasBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionado);

            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonasBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este cliente?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdClienteSeleccionado);
                dataGridView1.DataSource = bss.ListarPersonasBass();
            }
        }
    }
}
