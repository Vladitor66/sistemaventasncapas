using sistemasventas.BSS;
using sistemasventas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = persona();
        PersonaBss bss = new PersonaBss();

        public PersonaEditarVista()
        {
            idx = idx;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.nombre;
            textBox2.Text = p.apellido;
            textBox3.Text = p.telefono;
            textBox4.Text = p.ci;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text; 
            p.telefono = textBox3.Text;
            p.ci = textBox4.Text;
            bss.EditarPersonaBss(p);
            
        }
    }
}
