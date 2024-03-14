using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaventas.DAL;
using sistemasventas.BSS;

namespace sistemasventas.BSS
{
    public class PersonaBss
    {
        PersonaDAL dal= new PersonaDAL();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }


    }
}
