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
    public partial class Autocomplete
    {
        public static DataSet GetProveedores(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("usp_Autocomplete_GetProveedores", dbParams);
        }
    }
}