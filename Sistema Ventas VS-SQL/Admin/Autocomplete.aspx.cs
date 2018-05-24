using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class Autocomplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["query"] != "")
            {
                if (Request.QueryString["identifier"] == "Proveedor")
                {
                    DataSet ds = Autocomplete.GetProveedores(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel=" + item.id + "_" + dr["Descripcion"].ToString() + ">" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }


                if (Request.QueryString["identifier"] == "Cliente")
                {
                    DataSet ds = Autocomplete.GetClientes(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel=" + item.id + "_" + dr["Descripcion"].ToString() + ">" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }

                if (Request.QueryString["identifier"] == "Usuario")
                {
                    DataSet ds = Autocomplete.GetUsuario(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel=" + item.id + "_" + dr["Descripcion"].ToString() + ">" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }


                if (Request.QueryString["identifier"] == "Producto")
                {
                    DataSet ds = Autocomplete.GetProductos(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul style='width:400px;'>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel=" + item.id + "_" + dr["StockActual"].ToString() + ">" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }


                if (Request.QueryString["identifier"] == "Compra")
                {
                    DataSet ds = Autocomplete.GetCompras(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel='" + item.id + "_" + dr["Descripcion"].ToString() + "_" + dr["Monto"].ToString() + "_" + dr["FechaCompra"].ToString() + "_" + dr["ProveedorDescripcion"].ToString() + "'>" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }

                if (Request.QueryString["identifier"] == "Color")
                {
                    DataSet ds = Autocomplete.GetColores(Request.QueryString["query"]);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<ul>" + "\n");
                        paginaBase.AutoCompleteResult item;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            item = new paginaBase.AutoCompleteResult();
                            item.value = dr["Descripcion"].ToString();
                            item.id = dr["Id"].ToString();
                            item.value = item.value.Replace(Request.QueryString["query"].ToString(), "<span style='font-weight:bold;'>" + Request.QueryString["query"].ToString() + "</span>");
                            Response.Write("\t" + "<li id=autocomplete_" + item.id + " rel=" + item.id + "_" + dr["Descripcion"].ToString() + ">" + item.value + "</li>" + "\n");

                        }
                        Response.Write("</ul>");
                        Response.End();
                    }
                }
            }
        }
    }
}