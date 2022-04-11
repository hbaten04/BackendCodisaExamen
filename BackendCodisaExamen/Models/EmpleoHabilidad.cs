using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.Models
{
    public class EmpleoHabilidad
    {
        public int idHabilidad { get; set; }
        public int idEmpleado { get; set; }
        public string nombreHabilidad { get; set; }
    }
}
