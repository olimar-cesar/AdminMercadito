using Admin.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class ListProveedor :paginaBase
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
            DataSet ds = ListProveedor.GetProveedores();
            gridClientes.DataSource = ds.Tables[0];
            gridClientes.DataBind();
        }

        protected void gridClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarProveedor")
                {
                    string sClienteId = e.CommandArgument.ToString();
                    Response.Redirect("EditProveedor.aspx?Id=" + sClienteId);
                }
                else if (e.CommandName == "EliminarProveedor")
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListProveedor.DeleteProveedores(proveedor);
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