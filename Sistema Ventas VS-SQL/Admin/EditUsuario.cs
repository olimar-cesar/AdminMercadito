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
    public partial class EditUsuario
    {
        public static int Insertar(Usuario usuario)
        {
            int UserId = 0;
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    //DBHelper.MakeParam("@Id", SqlDbType.Int, 0, usuario.Id),
                    DBHelper.MakeParam("@UserName", SqlDbType.VarChar, 0, usuario.UserName),
                    DBHelper.MakeParam("@PerfilId", SqlDbType.Int, 0, usuario.PerfilId),
                    DBHelper.MakeParam("@password", SqlDbType.VarChar, 0, usuario.password)
				};
            UserId =  Convert.ToInt32( DBHelper.ExecuteScalar("usp_EditUsuario_Insertar", dbParams));
            return UserId;
        }

        public static int Actualizar(Usuario usuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, usuario.Id),
                    DBHelper.MakeParam("@UserName", SqlDbType.VarChar, 0, usuario.UserName),
                    DBHelper.MakeParam("@PerfilId", SqlDbType.Int, 0, usuario.PerfilId),
                    DBHelper.MakeParam("@password", SqlDbType.VarChar, 0, usuario.password)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditUser_Actualizar", dbParams));
        }

        public static DataSet GetUsuario(Usuario usuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, usuario.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditUser_GetUser", dbParams);
        }
    }
}