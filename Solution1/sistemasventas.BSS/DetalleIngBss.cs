﻿using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistemasventas.BSS
{
    public class DetalleIngBss
    {
       
            DetalleIngDAL dal = new DetalleIngDAL();
            public DataTable ListarDetalleIngBss()
            {
                return dal.DetalleIngDAL();
            }


        }
    }
}
