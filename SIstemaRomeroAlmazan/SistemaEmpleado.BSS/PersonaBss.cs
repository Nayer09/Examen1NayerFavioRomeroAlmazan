using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpleado.DAL;
using SistemaEmpleado.Modelos;

namespace SistemaEmpleado.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public Persona ObtenerPersonaIdBss(int id)
        {
            return dal.ObtenerPersonaIdDal(id);
        }
    }
}
