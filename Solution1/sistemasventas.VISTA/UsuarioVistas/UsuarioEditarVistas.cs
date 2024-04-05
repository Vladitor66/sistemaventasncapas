using sistemasventas.VISTA.PersonasVistas;
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

namespace sistemasventas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVistas : Form

    {
        int idx = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(usuario);
            MessageBox.Show("Datos Actualizados");
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }

        }

        private void UsuarioEditarVistas_Load(object sender, EventArgs e)
        {
            usuario = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = Convert.ToString(usuario.IdPersona);
            
            textBox3.Text = usuario.Contraseña;
            dateTimePicker1.Value = usuario.FechaReg;
        }
    }
}
