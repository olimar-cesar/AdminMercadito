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
    public partial class EditProducto : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //ddlTalle.DataValueField = "Id";
                //ddlTalle.DataTextField = "Descripcion";

                //ddlTalle.DataSource = AddProducto.GetTalles().Tables[0];
                //ddlTalle.DataBind();

                ddlTipo.DataValueField = "Id";
                ddlTipo.DataTextField = "Descripcion";
                ddlTipo.DataSource = AddProducto.GetTipoProductos().Tables[0];
                ddlTipo.DataBind();
                
                if (Request.QueryString["Id"] != null)
                {
                    int ProductoId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(ProductoId);
                }
                txtId.Attributes.Add("readonly", "true");

            }

        }

        private void CargarDatos(int ProductoId)
        {
            Producto producto = new Producto();
            producto.Id = ProductoId;
            DataSet ds = EditProducto.GetProducto(producto);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = ProductoId.ToString();
            //											
            txtCodigo.Text = dr["Codigo"].ToString();
            txtDescripcion.Text = dr["Descripcion"].ToString();
            ddlTipo.SelectedValue = dr["TipoId"].ToString();
            //txtColor.Text = dr["ColorDescripcion"].ToString();
            //ddlTalle.SelectedValue = dr["TalleId"].ToString();
            txtPrecioCosto.Text = dr["PrecioCosto"].ToString();
            txtPorcGanancia.Text = dr["PorcGanancia"].ToString();
            txtPrecioVenta.Text = dr["PrecioVenta"].ToString();
            txtStockActual.Text = dr["StockActual"].ToString();
            txtPorcDescuento.Text = dr["PorcDescuento"].ToString();
            txtCompra.Text = dr["CompraDescripcion"].ToString();
            hdnCompraId.Value = dr["CompraId"].ToString();

            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();

                producto.Id = Utils.utils.ToInt( txtId.Text);

                producto.Codigo = Utils.utils.ToInt(txtCodigo.Text);


                producto.Descripcion = txtDescripcion.Text;
                producto.Tipo.Id =Utils.utils.ToInt( ddlTipo.SelectedValue);
                //producto.Talle.Id = Utils.utils.ToInt(ddlTalle.SelectedValue);
                //producto.Color.Descripcion = txtColor.Text;
                producto.PrecioCosto = Utils.utils.ToDouble(txtPrecioCosto.Text);
                producto.PorcGanancia = Utils.utils.ToDouble(txtPorcGanancia.Text);
                producto.PrecioVenta = Utils.utils.ToDouble(txtPrecioVenta.Text);
                producto.StockActual = Utils.utils.ToDouble(txtStockActual.Text);
                producto.PorcDescuento = Utils.utils.ToDouble(txtPorcDescuento.Text);
                producto.Compra.Id = Utils.utils.ToInt( hdnCompraId.Value);

                string sResultado = "";
                if (producto.PrecioCosto == 0)
                    sResultado = sResultado + "Precio Costo<br>";
                if (producto.PrecioVenta == 0)
                    sResultado = sResultado + "Precio Venta<br>";
                if (producto.PorcGanancia == 0)
                    sResultado = sResultado + "Porcentaje de Ganancia<br>";
                if (producto.StockActual == 0)
                    sResultado = sResultado + "Stock Actual<br>";

                if (sResultado != "")
                {
                    messageBox.ShowMessage("Falta ingresar los siguientes campos:<br> " + sResultado);
                }
                else
                {
                    if (EditProducto.Actualizar(producto) == 0)
                    {
                        messageBox.ShowMessage("Hubo un error al guardar los datos intente nuevamente");
                    }
                    else
                    {
                        messageBox.ShowMessage("Los datos fueron guardados exitosamente!");
                    }
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message);
            }
            
        }
    }
}