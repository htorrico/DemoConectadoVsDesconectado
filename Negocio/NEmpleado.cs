using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        DEmpleado datos = new DEmpleado();
        public List<Empleado> GetEmpleados(string Nombres, string Apellidos)
        {
            return datos.GetEmpleados(Nombres,Apellidos);
        }
    }
}
