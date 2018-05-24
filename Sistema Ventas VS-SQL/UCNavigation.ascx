<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNavigation.ascx.cs" Inherits="Teach.UCNavigation" %>
<table width="200" border="0" cellspacing="1" cellpadding="0">
    <tr>
      <td height="10" colspan="4"><img src="Images/1.gif" width="198" height="15" /></td>
    </tr>
    <tr id="divLogin" runat="server">
      <td height="20">&nbsp;</td>
      <td bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628"><asp:HyperLink CssClass="izq" ID="lnkCRM" NavigateUrl="Login.aspx" runat="server">CRM Login</asp:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    
    <tr id="divlnkHome">
      <td height="20">&nbsp;</td>
      <td bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628"><ASP:HyperLink CssClass="izq" id="lnkHome"
				 navigateurl="Main.aspx" runat="server">Home</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlblVentas" >
      <td height="20" style="HEIGHT: 21px">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6" style="HEIGHT: 21px">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco" style="HEIGHT: 21px">
        <ASP:Label id="lblVentas" runat="server">Ventas:</ASP:Label></td>
      <td height="20" style="HEIGHT: 21px">&nbsp;</td>
    </tr>
    <tr id="divlnkAddVenta" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;<ASP:HyperLink id="lnkAddVenta" runat="server" cssclass="izq2" navigateurl="AddVenta.aspx">Nueva Venta</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkListVentas" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;<ASP:HyperLink
                       id="lnkListVentass" runat="server" cssclass="izq2" navigateurl="ListVenta.aspx">Listar Ventas</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlblProductos" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblProductos" runat="server">Productos:</ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkAddProducto" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkAddProducto" runat="server" cssclass="izq2" navigateurl="AddProducto.aspx">Nuevo Producto</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkListProductos" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkListProductos" runat="server" cssclass="izq2" navigateurl="ListProducto.aspx">Listar Productos</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlblProveedores" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblProveedores" runat="server">Proveedores:</ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkAddProveedor" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkAddProveedor" runat="server" cssclass="izq2" navigateurl="AddProveedor.aspx">Nuevo Proveedor</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkListProveedores" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkListProveedores" runat="server" cssclass="izq2" navigateurl="ListProveedor.aspx">Listar Proveedores</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    
   

    <tr id="divCompras" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblCompras" runat="server">Compras:</ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divAddCompra" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkAddCompra" runat="server" cssclass="izq2" navigateurl="AddCompra.aspx">Add Compra</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divLisCompra" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkListaCompras" runat="server" cssclass="izq2" navigateurl="ListCompra.aspx">Listar Compras</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divBalance" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblBalance" runat="server">Balance:</ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divBalanceList" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkVerValance" runat="server" cssclass="izq2" navigateurl="ListBalance.aspx">Ver Balance</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divCaja" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkCaja" runat="server" cssclass="izq2" navigateurl="Caja.aspx">Caja</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkChangePassword" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" classname="izq"><ASP:HyperLink id="lnkChangePassword" class="izq"
                       runat="server" navigateurl="ChangePassword.aspx" cssclass="izq">Change Password</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkLogout" >
      <td width="10" height="20" style="HEIGHT: 20px">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6" style="HEIGHT: 20px">&nbsp;</td>
      <td height="20" bgcolor="#225628" style="HEIGHT: 20px">
        <p>
          <ASP:HyperLink id="lnkLogout" runat="server" cssclass="izq2" navigateurl="LogOut.aspx">Log Out</ASP:HyperLink>
        </p></td>
      <td width="10" height="20" style="HEIGHT: 20px">&nbsp;</td>
    </tr>
    <tr style="background:green" runat="server" id="trTipoSitio" visible="false">
      <td width="10">&nbsp;</td>
      <td width="4">&nbsp;</td>
      <td>TESTING...</td>
      <td width="10">&nbsp;</td>
    </tr>
  </table>
  <script language="javascript" type="text/javascript">
      function ocultarEnlaces(b) {
          var cad = 'none';
          if (b) {
              cad = '';
          }

          document.getElementById('divlnkHome').style.display = cad;
          document.getElementById('divlblVentas').style.display = cad;
          document.getElementById('divlnkAddVenta').style.display = cad;
          document.getElementById('divlnkListVentas').style.display = cad;
          document.getElementById('divlblProductos').style.display = cad;
          document.getElementById('divlnkAddProducto').style.display = cad;
          document.getElementById('divlnkListProductos').style.display = cad;
          document.getElementById('divlblProveedores').style.display = cad;
          document.getElementById('divlnkAddProveedor').style.display = cad;
          document.getElementById('divlnkListProveedores').style.display = cad;
          
          
          document.getElementById('divlnkChangePassword').style.display = cad;
          document.getElementById('divlnkLogout').style.display = cad;
          
          document.getElementById('divAddCompra').style.display = cad;
          document.getElementById('divCompras').style.display = cad;
          document.getElementById('divLisCompra').style.display = cad;
          document.getElementById('divBalance').style.display = cad;
          document.getElementById('divBalanceList').style.display = cad;
          document.getElementById('divCaja').style.display = cad;


      }
  </script>
<p></p>
