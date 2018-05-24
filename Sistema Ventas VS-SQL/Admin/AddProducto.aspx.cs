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
    public partial class AddProducto : paginaBase
    {
        private static DataTable  dtTipoProducto = null;
        //private static DataTable dtTalle = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dtTipoProducto = AddProducto.GetTipoProductos().Tables[0];
                //dtTalle = AddProducto.GetTalles().Tables[0];
                CargarGrilla(10);
            }
        }

        public void CargarGrilla(int cantidad)
        {
            List<Producto> lista= new List<Producto>();

            for (int i = 0; i < cantidad; i++)
            {
                Producto producto = new Producto();
                producto.Renglon = i + 1;
                producto.PorcDescuento = 0.00;
                lista.Add(producto);
            }

            gridProductos.DataSource = lista;
            gridProductos.DataBind();

        }

        protected void gridProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataSet ds = AddProducto.GetTipoProductos();
                ((DropDownList)e.Row.FindControl("ddlTipo")).DataValueField = "Id";
                ((DropDownList)e.Row.FindControl("ddlTipo")).DataTextField = "Descripcion";
                ((DropDownList)e.Row.FindControl("ddlTipo")).DataSource = dtTipoProducto;
                ((DropDownList)e.Row.FindControl("ddlTipo")).DataBind();
                

               // ds = AddProducto.GetTalles();
                //((DropDownList)e.Row.FindControl("ddlTalle")).DataValueField = "Id";
                //((DropDownList)e.Row.FindControl("ddlTalle")).DataTextField = "Descripcion";
                //((DropDownList)e.Row.FindControl("ddlTalle")).DataSource = dtTalle;
                //((DropDownList)e.Row.FindControl("ddlTalle")).DataBind();
                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                List<Producto> lista= new List<Producto>();
                string sResultado = ValidarDatos(ref lista);

                int correctos = 0;
                int iErroneos = 0;
                if ((sResultado=="") && lista.Count>0 )
                {
                    foreach (Producto prod in lista)
                    {
                        prod.Compra.Id = Convert.ToInt32(hdnCompraId.Value);
                        if (AddProducto.Insertar(prod) > 0)
                        {
                            correctos++;
                        }
                        else
                        {
                            iErroneos++;
                        }
                    }

                    if (lista.Count>0)
                    {
                        string sMensaje = "Se insertaron " + correctos.ToString() + " registros correctamente";
                        if (iErroneos>0)
                        {
                            sMensaje = sMensaje + " " + iErroneos + " registros fallaron en la insercion";
                        }

                        messageBox.ShowMessage(sMensaje);
                    }

                   
                }
                else
                {
                    messageBox.ShowMessage(sResultado);  
                }

                //

            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message+ex.StackTrace);
            }
        }

        private string ValidarDatos(ref List<Producto> listaProducto )
        {
            string sResultado = "";
            Producto producto = null;
            int j = 1;

            if (txtCompra.Text=="")
            {
                sResultado = "Debe ingresar una compra";
                return sResultado;
            }


            foreach (GridViewRow dr in gridProductos.Rows)
            {
                producto= new Producto();

                producto.Codigo = Utils.utils.ToInt(((NumericBox)dr.FindControl("txtCodigo")).Text);
                if (producto.Codigo == 0)
                {
                    break;
                }

                producto.Descripcion = ((TextBox) dr.FindControl("txtDescripcion")).Text;
                producto.Tipo.Id = Utils.utils.ToInt(((DropDownList)dr.FindControl("ddlTipo")).SelectedValue);
                //producto.Talle.Id = Utils.utils.ToInt(((DropDownList)dr.FindControl("ddlTalle")).SelectedValue);
                //producto.Color.Descripcion = ((TextBox)dr.FindControl("txtColor")).Text;
                producto.PrecioCosto = Utils.utils.ToDouble(((NumericBox)dr.FindControl("txtPrecioCosto")).Text);
                producto.PorcGanancia = Utils.utils.ToDouble(((NumericBox)dr.FindControl("txtPorcGanancia")).Text);
                producto.PrecioVenta = Utils.utils.ToDouble(((NumericBox)dr.FindControl("txtPrecioVenta")).Text);
                producto.StockActual = Utils.utils.ToInt(((NumericBox)dr.FindControl("txtStockActual")).Text);
                producto.PorcDescuento = Utils.utils.ToDouble(((NumericBox)dr.FindControl("txtPorcDescuento")).Text);

                if (producto.Descripcion == "")
                    sResultado = "Descripcion <br>";
                //if (producto.Color.Descripcion == "")
                //    sResultado = sResultado + " Color<br>";
                if (producto.PrecioCosto == 0)
                    sResultado = sResultado + "Precio Costo<br>";
                if (producto.PrecioVenta == 0)
                    sResultado = sResultado + "Precio Venta<br>";
                if (producto.PorcGanancia == 0)
                    sResultado = sResultado + "Porcentaje de Ganancia<br>";
                if (producto.StockActual == 0)
                    sResultado = sResultado + "Stock Actual<br>";

                listaProducto.Add(producto);

                if (sResultado!="")
                {
                    sResultado = "En la Fila " + j.ToString() + " faltan ingresar los siguientes datos:<br><br>" + sResultado;
                    break;
                }
                j++;
            }

            return sResultado;
        }

        
    }
}