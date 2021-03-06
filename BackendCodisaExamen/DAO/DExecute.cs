using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodisaExamen.DAO
{
    public class DExecute : DConexion
    {
        public void Upsert(DProcedimiento procedimiento)
        {
            try
            {
                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                foreach (var item in procedimiento.Parametros)
                {
                    cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                }
                cmd.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Consultar(DProcedimiento procedimiento)
        {
            DataTable dtlDatos = new DataTable("datos");
            try
            {

                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                if (procedimiento.Parametros != null)
                {
                    foreach (var item in procedimiento.Parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                    }
                }

                SqlDataAdapter msqDta = new SqlDataAdapter(cmd);
                msqDta.Fill(dtlDatos);

                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtlDatos;
        }
    }
}
