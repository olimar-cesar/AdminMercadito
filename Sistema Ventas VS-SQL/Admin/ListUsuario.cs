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
    public partial class ListUsuario
    {
        public static DataSet GetUsuario()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_ListUser_GetUser", dbParams);
        }

        public static DataSet DeleteUsuario(Usuario user)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, user.Id),
				};
            return DBHelper.ExecuteDataSet("usp_ListUser_DeleteUser", dbParams);
        }
    }
}