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
    public partial class ListProducto
    {
        public static DataSet GetProductos()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListProducto_GetProductos", dbParams);
        }

        public static DataSet DeleteProducto(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, producto.Id),
				};
            return DBHelper.ExecuteDataSet("usp_ListProducto_DeleteProducto", dbParams);
        }
    }
}