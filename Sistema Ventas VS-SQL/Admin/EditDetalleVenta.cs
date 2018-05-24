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
    public partial class EditDetalleVenta
    {
        public static DataSet GetVenta(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, venta.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditDetalleVenta_GetVenta", dbParams);
        }

        public static DataSet GetDetalleVenta(Venta venta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, venta.Id),
				};
            return DBHelper.ExecuteDataSet("usp_EditDetalleVenta_GetDetalleVenta", dbParams);
        }


        public static int InsertarDetalle(DetalleVenta detalle, SqlTransaction trx, SqlConnection cn)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    // , , , , , 
                    DBHelper.MakeParam("@ProductoId", SqlDbType.Int, 0, detalle.Producto.Id),
                    DBHelper.MakeParam("@CantidadUnidades", SqlDbType.Int, 0, detalle.CantidadUnidades),
                    DBHelper.MakeParam("@Descuento", SqlDbType.Decimal, 0, detalle.PorcDescuento),
                    DBHelper.MakeParam("@PrecioCosto", SqlDbType.Decimal, 0, detalle.PrecioCosto),
                    DBHelper.MakeParam("@PrecioVendido", SqlDbType.Decimal, 0, detalle.PrecioVendido),
                    DBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, detalle.VentaId),
				};
            int DetalleVentaId = Convert.ToInt32(DBHelper.ExecuteScalar("usp_AddVenta_InsertarDetalle", dbParams, trx, cn));
            if (DetalleVentaId > 0)
            {
                if (DisminuirStock(detalle, trx, cn) == 0)
                {
                    throw new Exception("Hubo un error en la disminucion de stock " + detalle.Producto.Descripcion);
                }
            }

            return DetalleVentaId;
        }


        public static int DisminuirStock(DetalleVenta detalle, SqlTransaction trx, SqlConnection cn)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    // , , , , , 
                    DBHelper.MakeParam("@ProductoId", SqlDbType.Int, 0, detalle.Producto.Id),
                    DBHelper.MakeParam("@CantidadUnidades", SqlDbType.Int, 0, detalle.CantidadUnidades),
                   
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_AddVenta_DisminuirStock", dbParams, trx, cn));


        }


        public static int EliminarDetalleVenta(DetalleVenta detalle)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@DetalleVentaId", SqlDbType.Int, 0, detalle.Id),
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditDetalleVenta_EliminarDetalleVenta", dbParams));
        }

    }
}