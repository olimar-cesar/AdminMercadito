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
    public partial class EditCompra : paginaBase
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

        private void CargarDatos(int CompraId)
        {
            Compra compra = new Compra();
            compra.Id = CompraId;
            DataSet ds = EditCompra.GetCompra(compra);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = CompraId.ToString();
            txtDescripcion.Text = dr["Descripcion"].ToString();
            txtMonto.Text = dr["Monto"].ToString().Replace(",",".");
            txtProveedor.Text = dr["ProveedorDescripcion"].ToString();
            txtFecha.Text = dr["FechaCompra"].ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {

                    Compra compra = new Compra();
                    compra.Descripcion = txtDescripcion.Text;
                    compra.FechaCompra = Convert.ToDateTime(txtFecha.Text);
                    compra.Proveedor.Nombre = txtProveedor.Text;
                    compra.NumeroTicket = txtNumeroTicket.Text;
                    compra.Monto = Utils.utils.ToDouble( txtMonto.Text);

                    if (EditCompra.Insertar(compra) > 0)
                    {
                        messageBox.ShowMessage("La compra se inserto correctamente!");
                    }

                    txtDescripcion.Text = "";
                    txtMonto.Text = "";
                    txtProveedor.Text = "";
                    txtNumeroTicket.Text = "";
                    txtFecha.Text = "";
                }
                else
                {
                   
                    Compra compra = new Compra();
                    compra.Id = Convert.ToInt32(txtId.Text);
                    compra.Descripcion = txtDescripcion.Text;
                    compra.FechaCompra = Convert.ToDateTime(txtFecha.Text);
                    compra.Proveedor.Nombre = txtProveedor.Text;
                    compra.NumeroTicket = txtNumeroTicket.Text;
                    compra.Monto = Utils.utils.ToDouble(txtMonto.Text);

                    if (EditCompra.Actualizar(compra) > 0)
                    {
                        Response.Redirect("ListCompra.aspx",false);
                    }
                }
            }
            catch (Exception ex)
            {

                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }
        }

        protected void txtNumeroTicket_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}