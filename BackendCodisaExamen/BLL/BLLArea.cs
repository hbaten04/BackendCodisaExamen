using BackendCodisaExamen.DAO;
using BackendCodisaExamen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.BLL
{
    public class BLLArea
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;
        public void upsert(AreaEntity areaEntity, string pOp)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_MANTENIMIENTO_AREA";

            objProc.Parametros.Add(new DParametro { Nombre = "pOp", Valor = pOp, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pNombre", Valor = areaEntity.nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pDescripcion", Valor = areaEntity.descripcion, Tipo = DbType.String, Out = false });




            objExcute.Upsert(objProc);

        }
    }
}
