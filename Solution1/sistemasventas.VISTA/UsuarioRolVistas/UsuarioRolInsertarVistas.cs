using sistemasventas.BSS;
using sistemasventas.MODELOS;
using sistemasventas.VISTA.RolVistas;
using sistemasventas.VISTA.UsuarioVistas;
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

namespace sistemasventas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVistas : Form
    {
        public UsuarioRolInsertarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = IdUsuarioSeleccionado;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            usuarioRol.Estado = textBox3.Text;

            bss.InsertarUsuarioRolBss(usuarioRol);
            MessageBox.Show("Se guardo correctamente el Usuario Rol");
        }
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssusuario = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)
        {

            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssusuario.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox1.Text = usuario.NombreUser;
            }
        }
        public static int IdRolSeleccionado = 0;
        RolBss bssrol = new RolBss();
        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                rol rol = bssrol.ObtenerRolIdBss(IdRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }
        }
    }
}
