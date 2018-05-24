using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.Clases;
using eWorld.UI;

namespace Admin
{
    public partial class EditCliente : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int ClienteId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(ClienteId);
                }
                txtId.Attributes.Add("readonly", "true");
            }
        }

        private void CargarDatos(int ClienteId)
        {
            Cliente cliente= new Cliente();
            cliente.Id = ClienteId;
           DataSet ds= EditCliente.GetCliente(cliente);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = ClienteId.ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDomicilio.Text = dr["Domicilio"].ToString();
            txtTelefono.Text = dr["Telefono"].ToString();
            txtEmail.Text = dr["Email"].ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {

                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;

                  
                    if (EditCliente.Insertar(cliente) > 0)
                    {
                        messageBox.ShowMessage("El cliente se insertó correctamente!");
                    }

                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(txtId.Text);
                    cliente.Nombre = txtNombre.Text;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;

                    if (EditCliente.Actualizar(cliente) > 0)
                    {
                       Response.Redirect("ListCliente.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                
                  messageBox.ShowMessage(ex.Message+ex.StackTrace);
            }

        }

        protected void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }
    }
}