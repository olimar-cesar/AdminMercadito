using Admin.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Admin
{
    public partial class AddVenta : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta= new Venta();
                venta.Cliente.Id = Convert.ToInt32(hdnClienteId.Value);
                venta.FechaVenta = Convert.ToDateTime(txtFecha.Text);
                venta.UserId = Convert.ToInt32(this.Session["UserID"]);
               int VentaId= AddVenta.Insertar(venta);
                if (VentaId > 0)
                {
                    Response.Redirect("EditDetalleVenta.aspx?VentaId=" + VentaId.ToString(), true);
                }
            }
            catch (Exception ex)
            {
                
                messageBox.ShowMessage(ex.Message+ ex.StackTrace);
            }
        }
    }
}