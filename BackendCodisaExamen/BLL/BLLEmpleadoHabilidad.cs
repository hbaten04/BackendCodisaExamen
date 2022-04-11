using BackendCodisaExamen.DAO;
using BackendCodisaExamen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.BLL
{
    public class BLLEmpleadoHabilidad
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;
        public List<EmpleoHabilidad> listaHabilidades(int pIdEmpleado)
        {

            EmpleoHabilidad objEmpHabilidad = null;
            List<EmpleoHabilidad> listHabilidad = new List<EmpleoHabilidad>();
            DataTable dt = new DataTable();
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_LISTA_HABILIDAD";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdEmpleado", Valor = pIdEmpleado, Tipo = DbType.Int32, Out = false });

            dt = objExcute.Consultar(objProc);

            foreach (DataRow item in dt.Rows)
            {

                objEmpHabilidad = new EmpleoHabilidad();
                objEmpHabilidad.idHabilidad = Convert.ToInt32(item["IdHabilidad"]);
                objEmpHabilidad.idEmpleado = Convert.ToInt32(item["IdEmpleado"]);
                objEmpHabilidad.nombreHabilidad = item["NombreHabilidad"].ToString();

                listHabilidad.Add(objEmpHabilidad);
            }

            return listHabilidad;

        }
    }
}
