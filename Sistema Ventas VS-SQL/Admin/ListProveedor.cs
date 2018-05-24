using Admin.Clases;
using Admin.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Admin
{
    public partial class ListProveedor
    {
        public static DataSet GetProveedores()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListProveedores_GetProveedores", dbParams);
        }

        public static int DeleteProveedores(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Id", SqlDbType.Decimal, 0, proveedor.Id),
				};
            return Convert.ToInt32( DBHelper.ExecuteScalar("usp_ListVenta_DeleteVenta", dbParams));
        }
    }
}