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

        public void InsEmpleado(Empleado empleado)
        {
            datos.InsEmpleado(empleado);
        }
        public void InsEmpleadoAutoincremental(Empleado empleado)
        {

            var empleados = datos.GetEmpleados(string.Empty, string.Empty);
            int max = empleados[empleados.Count - 1].Id;
            empleado.Id = max + 1;
            datos.InsEmpleado(empleado);
        }
    }
}
