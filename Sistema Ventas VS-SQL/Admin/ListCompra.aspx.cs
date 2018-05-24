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
    public partial class ListCompra : paginaBase
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
            DataSet ds = ListCompra.GetCompras();
            gridCompras.DataSource = ds.Tables[0];
            gridCompras.DataBind();
        }

        protected void gridCompras_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarCompra")
                {
                    string sCompraId = e.CommandArgument.ToString();
                    Response.Redirect("EditCompra.aspx?Id=" + sCompraId);
                }
                else if (e.CommandName == "EliminarCompra")
                {
                    Compra compra = new Compra();
                    compra.Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListCompra.DeleteCompra(compra);
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