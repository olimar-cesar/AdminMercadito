using Admin.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Admin
{
    public partial class Login
    {
        public static DataSet ValidarLogin(string sUserName, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUserName),
                    DBHelper.MakeParam("@Contrasena", SqlDbType.VarChar, 0, sPassword)
				};
            return DBHelper.ExecuteDataSet("usp_Login_ValidarLogin", dbParams);
        }
    }
}