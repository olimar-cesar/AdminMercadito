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
    public partial class EditProveedor
    {
        public static int Insertar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, proveedor.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, proveedor.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, proveedor.Email)
				};
            return  Convert.ToInt32( DBHelper.ExecuteScalar("usp_EditProveedor_Insertar", dbParams));
        }

        public static int Actualizar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                      DBHelper.MakeParam("@Id", SqlDbType.Int, 0, proveedor.Id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, proveedor.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, proveedor.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, proveedor.Email)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditProveedor_Actualizar", dbParams));
        }

        public static DataSet GetProveedor(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, proveedor.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditProveedor_GetProveedor", dbParams);
        }
    }
}