using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.Clases;
using System.Data;

namespace Admin
{
    public partial class EditDetalleVenta : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    Venta venta= new Venta();
                    venta.Id = Convert.ToInt32(Request.QueryString["VentaId"]);


                    DataSet ds = EditDetalleVenta.GetVenta(venta);
                    CargarVenta(ds.Tables[0]);
                    CargarDetalleVenta(venta.Id);
                    
                    txtStock.Attributes.Add("readonly","true");
                    
                }
            }
            catch (Exception ex)
            {
                
                messageBox.ShowMessage(ex.Message+ex.StackTrace);
            }
        }

        public void CargarVenta(DataTable dt)
        {
            txtVentaId.Text = dt.Rows[0]["Id"].ToString();
            txtCliente.Text = dt.Rows[0]["Nombre"].ToString();
            txtFechaVenta.Text = dt.Rows[0]["FechaVenta"].ToString();
            txtMonto.Text = dt.Rows[0]["MontoTotal"].ToString();


        }

        public void CargarDetalleVenta(int VentaId)
        {
            Venta venta= new Venta();
            venta.Id = VentaId;
          DataSet ds=  EditDetalleVenta.GetDetalleVenta(venta);
            DataTable dt = ds.Tables[0];
            gridDetalle.DataSource = dt;
            gridDetalle.DataBind();


        }

        protected void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            string sRes = ValidarDatos();
            if (sRes == "")
            {



                SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
                cn.Open();
                SqlTransaction trx = cn.BeginTransaction();
                try
                {
                    DetalleVenta detalle = new DetalleVenta();
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(hdnProductoId.Value);
                    DataSet dsProducto = EditProducto.GetProducto(producto);

                    detalle.Producto = producto;
                    detalle.VentaId = Convert.ToInt32(txtVentaId.Text);
                    detalle.PrecioCosto = Convert.ToDouble(dsProducto.Tables[0].Rows[0]["PrecioCosto"]);
                    detalle.PrecioVendido = Convert.ToDouble(dsProducto.Tables[0].Rows[0]["PrecioVenta"]);
                    detalle.CantidadUnidades = Convert.ToInt32(txtCantidad.Text);

                    int detalleVentaId = EditDetalleVenta.InsertarDetalle(detalle, trx, cn);
                    if (detalleVentaId > 0)
                    {
                        trx.Commit();
                        CargarDetalleVenta(Convert.ToInt32(txtVentaId.Text));
                        txtStock.Text = "";
                        txtCantidad.Text = "";
                        txtProducto.Text = "";
                        hdnProductoId.Value = "";
                    }
                    else
                    {
                        trx.Rollback();
                        messageBox.ShowMessage("No se pudo insertar el detalle, intente nuevamente");
                    }

                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    messageBox.ShowMessage(ex.Message + ex.StackTrace);
                }
                finally
                {
                    if (null != cn)
                        cn.Close();
                }

            }
            else
            {
                messageBox.ShowMessage(sRes);
            }

        }

        private string ValidarDatos()
        {
            if (hdnProductoId.Value == "")
            {
                return "Debe Seleccionar un producto para añadir a la venta";
            }
            else if(txtCantidad.Text=="")
            {
                return "Debe ingresar una cantidad";
            }
            else if(Utils.utils.ToInt(txtCantidad.Text)>Utils.utils.ToInt(txtStock.Text))
            {
                return "La cantidad que intenta vender supera el stock";
            }
            else
            {
                return "";
            }
        }

        protected void gridDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
               if (e.CommandName == "EliminarDetalle")
                {
                    DetalleVenta detalle= new DetalleVenta();
                    detalle.Id = Convert.ToInt32(e.CommandArgument.ToString());

                    if (EditDetalleVenta.EliminarDetalleVenta(detalle) > 0)
                    {
                        CargarDetalleVenta(Convert.ToInt32(txtVentaId.Text));
                    }
                    else
                    {
                        messageBox.ShowMessage("No se pudo eliminar el detalle. Intente nuevamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}