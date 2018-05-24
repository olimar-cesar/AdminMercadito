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
    public partial class EditProveedor : paginaBase
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

        private void CargarDatos(int proveedorid)
        {
            Proveedor proveedor= new Proveedor();
            proveedor.Id = proveedorid;
           DataSet ds= EditProveedor.GetProveedor(proveedor);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = proveedorid.ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDomicilio.Text = dr["Domicilio"].ToString();
            txtTelefono.Text = dr["Tel"].ToString();
            txtEmail.Text = dr["Email"].ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {

                    Proveedor prov = new Proveedor();
                    prov.Nombre = txtNombre.Text;
                    prov.Domicilio = txtDomicilio.Text;
                    prov.Telefono = txtTelefono.Text;
                    prov.Email = txtEmail.Text;


                    if (EditProveedor.Insertar(prov) > 0)
                    {
                        messageBox.ShowMessage("El Proveedor se inserto correctamente!");
                    }
                }
                else
                {
                    Proveedor prov = new Proveedor();
                    prov.Id = Convert.ToInt32(txtId.Text);
                    prov.Nombre = txtNombre.Text;
                    prov.Domicilio = txtDomicilio.Text;
                    prov.Telefono = txtTelefono.Text;
                    prov.Email = txtEmail.Text;

                    if (EditProveedor.Actualizar(prov) > 0)
                    {
                       Response.Redirect("ListProveedor.aspx");
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