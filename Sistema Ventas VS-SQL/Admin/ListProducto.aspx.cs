using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.Clases;

namespace Admin
{
    public partial class ListProducto : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    CargarGrilla();
                }
                catch (Exception ex)
                {

                    messageBox.ShowMessage(ex.Message);
                }

            }
        }

        private void CargarGrilla()
        {
            DataSet ds = ListProducto.GetProductos();
            gridproductos.DataSource = ds.Tables[0];
            gridproductos.DataBind();
        }

        protected void gridproductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarProducto")
                {
                    string sProductoId = e.CommandArgument.ToString();
                    Response.Redirect("EditProducto.aspx?Id=" + sProductoId);
                }
                else if (e.CommandName == "EliminarProducto")
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListProducto.DeleteProducto(producto);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}