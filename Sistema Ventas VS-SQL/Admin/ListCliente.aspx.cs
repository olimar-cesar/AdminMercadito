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
    public partial class ListCliente : paginaBase
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
            DataSet ds = ListCliente.GetClientes();
            gridClientes.DataSource = ds.Tables[0];
            gridClientes.DataBind();
        }

        protected void gridClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarCliente")
                {
                    string sClienteId = e.CommandArgument.ToString();
                    Response.Redirect("EditCliente.aspx?Id=" + sClienteId);
                }
                else if (e.CommandName == "EliminarCliente")
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListCliente.DeleteCliente(cliente);
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