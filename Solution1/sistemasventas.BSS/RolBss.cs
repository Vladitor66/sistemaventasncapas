using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.BSS;
using sistemaventas.DAL;
using sistemasventas.MODELOS;


namespace sistemasventas.BSS
{
    public class RolBss
    {

        RolDal dal = new RolDal();
        public DataTable ListarRolesBass()
        {
            return dal.ListarRolDal();
        }

        public void InsertarRolBss(rol rol)
        {
            dal.InsertarRolDal(rol);
        }

        public rol ObtenerRolIdBss(int id)
        {
            return dal.ObtenerRolId(id);
        }

        public void EditarRolBss(rol rol)
        {
            dal.EditarRolDal(rol);
        }

        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }
    }
}

    
    
