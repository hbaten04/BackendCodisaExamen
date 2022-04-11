using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.Models
{
    public class EmpleadoEntity
    {
        public int idEmpleado { get; set; }
        public string nombreCompleto { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idJefe { get; set; }
        public int idArea { get; set; }
        public Byte? foto { get; set; }

    }
}
