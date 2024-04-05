using sistemasventas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from Rol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarRolDal(rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," +
                                                     "'" + rol.Estado + "')";
            conexion.Ejecutar(consulta);
        }

        public rol ObtenerRolId(int id)
        {
            string consulta = "select * from rol where idrol = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            rol rol = new rol();
            if (tabla.Rows.Count > 0)
            {
                rol.IdRol = Convert.ToInt32(tabla.Rows[0]["idRol"]);
                rol.Nombre = tabla.Rows[0]["nombre"].ToString();
                rol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return rol;
        }

        public void EditarRolDal(rol rol)
        {
            string consulta = "update rol set nombre ='" + rol.Nombre + "'," +
                                             "estado ='" + rol.Estado + "' " +
                                    "where idrol =" + rol.IdRol;

            conexion.Ejecutar(consulta);
        }

        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
