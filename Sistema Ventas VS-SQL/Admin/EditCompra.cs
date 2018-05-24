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
    public partial class EditCompra
    {
        public static int Insertar(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, compra.Descripcion),
                    DBHelper.MakeParam("@FechaCompra", SqlDbType.Date, 0, compra.FechaCompra),
                    DBHelper.MakeParam("@Proveedor", SqlDbType.VarChar, 0, compra.Proveedor.Nombre),
                    DBHelper.MakeParam("@NumerTicket", SqlDbType.VarChar, 0, compra.NumeroTicket),
                    DBHelper.MakeParam("@Monto", SqlDbType.Decimal, 0, compra.Monto),
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCompra_Insertar", dbParams));
        }

        public static int Actualizar(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                      DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compra.Id),
                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, compra.Descripcion),
                    DBHelper.MakeParam("@FechaCompra", SqlDbType.Date, 0, compra.FechaCompra),
                    DBHelper.MakeParam("@Proveedor", SqlDbType.VarChar, 0, compra.Proveedor.Nombre),
                    DBHelper.MakeParam("@NumerTicket", SqlDbType.VarChar, 0, compra.NumeroTicket),
                    DBHelper.MakeParam("@Monto", SqlDbType.Decimal, 0, compra.Monto),
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCompra_Actualizar", dbParams));
        }

        public static DataSet GetCompra(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compra.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditCompra_GetCompra", dbParams);
        }
    }
}