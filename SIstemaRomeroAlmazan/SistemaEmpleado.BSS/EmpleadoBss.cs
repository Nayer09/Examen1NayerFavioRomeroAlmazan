using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpleado.DAL;
using SistemaEmpleado.Modelos;
using SistemaEmpleado.DAL;

namespace SistemaEmpleado.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarUsuarioBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }

        public Empleado ObtenerEmpleadoIdBss(int id)
        {
            return dal.ObtenerEmpleadoIdDal(id);
        }

        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }

        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
