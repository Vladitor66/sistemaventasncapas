﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasventas.MODELOS;
using sistemasventas.BSS;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;

namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.Ci = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.InsertarPersonaBss(p);
            MessageBox.Show("se guardo correctamente");
        }

        private void PersonaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
