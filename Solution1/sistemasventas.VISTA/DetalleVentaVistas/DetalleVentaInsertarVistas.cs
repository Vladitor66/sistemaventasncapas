﻿using sistemasventas.VISTA.ProductoVistas;
using sistemasventas.VISTA.VentaVistas;
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

namespace sistemasventas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVistas : Form
    {
        public DetalleVentaInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.IdVenta = IdVentaSeleccionada;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            detalleVenta.SubTotal = Convert.ToDecimal(textBox5.Text);
            detalleVenta.Estado = textBox6.Text;

            bss.InsertarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Se guardo correctamente el Detalle Venta");
        }
        public static int IdVentaSeleccionada = 0;
        VentaBss bssventa = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssventa.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = Convert.ToString(venta.IdVenta);
            }
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
