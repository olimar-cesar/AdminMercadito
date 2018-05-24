using Admin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teach
{
    public partial class UCNavigation : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
         
            bool Logged = paginaBase.LoggedIn(Session);
           
            if (this.lnkChangePassword.Enabled)
            {
                this.lnkChangePassword.CssClass = "izq";
            }
            else
            {
                this.lnkChangePassword.CssClass = "izqDesactivado";
            }
           

            Page.ClientScript.RegisterStartupScript(Page.GetType(), "tttt", "ocultarEnlaces(" + Logged.ToString().ToLower() + ");", true);
            this.divLogin.Visible = !Logged;
            if (Logged)
           
            {
                this.lnkHome.CssClass = "izq";
                this.lblVentas.CssClass = "izq";
                this.lnkAddVenta.CssClass = "izq";
                this.lnkListVentass.CssClass = "izq";
                this.lblProductos.CssClass = "izq";
                this.lnkAddProducto.CssClass = "izq";
                this.lnkListProductos.CssClass = "izqDos";
                this.lblProveedores.CssClass = "izqDos";
                this.lnkAddProveedor.CssClass = "izqDos";
                this.lnkListProveedores.CssClass = "izqDos";
                this.lblCompras.CssClass = "izqDos";
                this.lnkAddCompra.CssClass = "izqDos";
                this.lnkLogout.CssClass = "izq";
                this.lnkListaCompras.CssClass = "izqDos";
                this.lblBalance.CssClass = "izqDos";
                this.lnkListaCompras.CssClass = "izqDos";
                this.lnkAddCompra.CssClass = "izqDos";
                this.lnkVerValance.CssClass = "izqDos";
                this.lnkCaja.CssClass = "izqDos";
            }
        }
        protected override void OnInit(EventArgs e)
        {
            this.InitializeComponent();
            base.OnInit(e);
        }
        private void InitializeComponent()
        {
            base.Load += new EventHandler(this.Page_Load);
        }
    }
}