﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class DetalleVentaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from DetalleVenta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
