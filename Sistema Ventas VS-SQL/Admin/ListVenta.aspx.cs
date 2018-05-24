using Admin.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class ListVenta :paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {

                    gridVentas.DataSource = ListVenta.GetVentas().Tables[0];
                    gridVentas.DataBind();

                }
            }
            catch (Exception ex)
            {
                
                messageBox.ShowMessage(ex.Message+ex.StackTrace);
            }
        }

        protected void gridVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarDetalles")
                {
                    string sVentaId = e.CommandArgument.ToString();
                    Response.Redirect("EditDetalleVenta.aspx?VentaId=" + sVentaId);
                }
                else if (e.CommandName == "EliminarVenta")
                {
                    Venta venta= new Venta();
                    string sVentaId = e.CommandArgument.ToString();
                    venta.Id = Convert.ToInt32(sVentaId);
                   int cantidadAfectada= ListVenta.DeleteVenta(venta);
                    if (cantidadAfectada == -1)
                    {
                        messageBox.ShowMessage("Esta venta aun tiene detalles, por lo tanto no se puede eliminar.");
                    }
                    else
                    {
                        messageBox.ShowMessage("La venta ha sido eliminada");
                        gridVentas.DataSource = ListVenta.GetVentas().Tables[0];
                        gridVentas.DataBind();
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