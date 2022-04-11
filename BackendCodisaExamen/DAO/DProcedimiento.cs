using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.DAO
{
    public class DProcedimiento
    {
        public string NombreProcedimiento;

        public List<DParametro> Parametros = new List<DParametro>();
    }
}
