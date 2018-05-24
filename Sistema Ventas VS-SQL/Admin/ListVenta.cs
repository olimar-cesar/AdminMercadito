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
    public partial class ListVenta
    {
        public static DataSet GetVentas()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListVenta_GetVentas", dbParams);
        }

        public static int DeleteVenta(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@VentaId", SqlDbType.Decimal, 0, venta.Id),
				};
            return Convert.ToInt32( DBHelper.ExecuteScalar("usp_ListVenta_DeleteVenta", dbParams));
        }
    }
}