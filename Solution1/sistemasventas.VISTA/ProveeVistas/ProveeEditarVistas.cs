﻿using sistemasventas.VISTA.ProductoVistas;
using sistemasventas.VISTA.ProveedorVistas;
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

namespace sistemasventas.VISTA.ProveeVistas
{
    public partial class ProveeEditarVistas : Form
    {
        int idx = 0;
        Provee provee = new Provee();
        ProveeBss bss = new ProveeBss();
        public ProveeEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveeEditarVistas_Load(object sender, EventArgs e)
        {
            provee = bss.ObtenerProveeIdBss(idx);
            textBox1.Text = Convert.ToString(provee.IdProducto);
            textBox2.Text = Convert.ToString(provee.IdProveedor);
            dateTimePicker1.Value = provee.Fecha;
            textBox3.Text = Convert.ToString(provee.Precio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(textBox3.Text);

            bss.EditarProveeBss(provee);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
           ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.Nombre;
            }
        }

        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bssproveedor = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssproveedor.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
