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
    public partial class AddProducto
    {
        public static int Insertar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    
                    DBHelper.MakeParam("@Codigo", SqlDbType.Int, 0, producto.Codigo),
                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, producto.Descripcion),
                    DBHelper.MakeParam("@TipoId", SqlDbType.Int, 0, producto.Tipo.Id),
                    //DBHelper.MakeParam("@ColorDescripcion", SqlDbType.VarChar, 0, producto.Color.Descripcion),
                    //DBHelper.MakeParam("@TalleId", SqlDbType.Int, 0, producto.Talle.Id),
                    DBHelper.MakeParam("@PrecioCosto", SqlDbType.Decimal, 0, producto.PrecioCosto),
                    DBHelper.MakeParam("@PorcGanancia", SqlDbType.Decimal, 0, producto.PorcGanancia),
                    DBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, producto.PrecioVenta),
                    DBHelper.MakeParam("@StockInicial", SqlDbType.Decimal, 0, producto.StockInicial),
                    DBHelper.MakeParam("@StockActual", SqlDbType.Decimal, 0, producto.StockActual),
                    DBHelper.MakeParam("@PorcDescuento", SqlDbType.Decimal, 0, producto.PorcDescuento),
                    DBHelper.MakeParam("@CompraId", SqlDbType.Int, 0, producto.Compra.Id),
                    
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_AddProducto_Insertar", dbParams));
        }


        public static DataSet GetTipoProductos()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("usp_AddProducto_GetTipoProductos", dbParams);
        }

        //public static DataSet GetTalles()
        //{
        //    SqlParameter[] dbParams = new SqlParameter[]
        //        {
        //        };
        //    return DBHelper.ExecuteDataSet("usp_AddProducto_GetTalles", dbParams);
        //}

    }
}