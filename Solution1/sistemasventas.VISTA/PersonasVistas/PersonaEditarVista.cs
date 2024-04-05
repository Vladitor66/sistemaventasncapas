
using sistemasventas.MODELOS;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {

        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        private int idPersonaSeleccionada;

        public PersonaEditarVista()
        {
            int idx = 0;
            InitializeComponent();
        }

        public PersonaEditarVista(int idPersonaSeleccionada)
        {
            this.idPersonaSeleccionada = idPersonaSeleccionada;
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerIdBss(idx);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido;
            textBox3.Text = persona.Telefono;
            textBox4.Text = persona.Ci;
            textBox5.Text = persona.Correo;
            textBox6.Text = persona.Estado;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = textBox3.Text;
            persona.Ci = textBox4.Text;
            persona.Correo = textBox5.Text;
            persona.Estado = textBox6.Text;

            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos Actualizados");

        }
    }
}
