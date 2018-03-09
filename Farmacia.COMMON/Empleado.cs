using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON
{
    public class Empleado
    {
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string NumeroEmpleado { get; set; }
        public override string ToString()
        {
            return string.Format("{0} ({1}) {2}", NombreEmpleado, ApellidosEmpleado, NumeroEmpleado);
        }
    }
}
