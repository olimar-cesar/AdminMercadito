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
    public partial class EditUsuario : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int Usuarioid = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(Usuarioid);
                }
                txtId.Attributes.Add("readonly", "true");
            }
        }

        private void CargarDatos(int Usuarioid)
        {
            Usuario usuario= new Usuario();
            usuario.Id = Usuarioid;
           DataSet ds= EditUsuario.GetUsuario(usuario);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = Usuarioid.ToString();
            txtUsuario.Text = dr["UserName"].ToString();
            txtPerfilId.Text = dr["PerfilId"].ToString();
            txtPassword.Text = dr["password"].ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {

                    Usuario user = new Usuario();
                    user.UserName = txtUsuario.Text;
                    user.PerfilId = Convert.ToInt32(txtPerfilId.Text);
                    user.password = txtPassword.Text;


                    if (EditUsuario.Insertar(user) > 0)
                    {
                        messageBox.ShowMessage("El Usuario se insertó correctamente!");
                    }
                }
                else
                {
                    Usuario user = new Usuario();
                    user.Id = Convert.ToInt32(txtId.Text);
                    user.UserName = txtUsuario.Text;
                    user.PerfilId = Convert.ToInt32(txtPerfilId.Text);
                    user.password = txtPassword.Text;

                    if (EditUsuario.Actualizar(user) > 0)
                    {
                       Response.Redirect("ListUsuario.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                
                  messageBox.ShowMessage(ex.Message+ex.StackTrace);
            }

        }
    }
}