using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.BSS;
using sistemaventas.DAL;


namespace sistemasventas.BSS
{
    public class RolBss
    {

            RolDal dal = new RolDAL();
            public DataTable ListarRolBss()
            {
                return dal.ListarRolDAL();
            }
        }
    }

    
    
