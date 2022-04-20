using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }

        public int Jefe { get; set; }

    }
}
