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
    public partial class ListCliente
    {
        public static DataSet GetClientes()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListCliente_GetClientes", dbParams);
        }

        public static DataSet DeleteCliente(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),
				};
            return DBHelper.ExecuteDataSet("usp_ListCliente_DeleteCliente", dbParams);
        }
    }
}