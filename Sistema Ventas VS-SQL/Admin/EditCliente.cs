using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Admin.Clases;
using Admin.Classes;

namespace Admin
{
    public partial class EditCliente
    {
        public static int Insertar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, cliente.Email)
				};
            return  Convert.ToInt32( DBHelper.ExecuteScalar("usp_EditCliente_Insertar", dbParams));
        }

        public static int Actualizar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                      DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, cliente.Email)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCliente_Actualizar", dbParams));
        }

        public static DataSet GetCliente(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditCliente_GetCliente", dbParams);
        }
    }
}