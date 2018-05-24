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
    public partial class ListCompra
    {
        public static DataSet GetCompras()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListCompra_GetCompras", dbParams);
        }

        public static DataSet DeleteCompra(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compra.Id),
				};
            return DBHelper.ExecuteDataSet("usp_ListCompra_DeleteCcompra", dbParams);
        }
    }
}