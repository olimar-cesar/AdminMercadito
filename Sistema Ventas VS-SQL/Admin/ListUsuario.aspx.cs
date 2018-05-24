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
    public partial class ListUsuario : paginaBase
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
            DataSet ds = ListUsuario.GetUsuario();
            gridUsuarios.DataSource = ds.Tables[0];
            gridUsuarios.DataBind();
        }

        protected void gridUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarUsuario")
                {
                    string sUsuarioid = e.CommandArgument.ToString();
                    Response.Redirect("EditUsuario.aspx?Id=" + sUsuarioid);
                }
                else if (e.CommandName == "EliminarUsuario")
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(e.CommandArgument.ToString());
                    ListUsuario.DeleteUsuario(usuario);
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