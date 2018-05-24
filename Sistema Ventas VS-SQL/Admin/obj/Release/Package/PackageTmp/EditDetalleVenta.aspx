<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditDetalleVenta.aspx.cs" Inherits="Admin.EditDetalleVenta" %>


<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>

<%@ Register Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" Namespace="eWorld.UI" TagPrefix="ew" %> 
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin |Detalle de Ventas|</title>
	
	

  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"><style type="text/css">BODY {
	FONT-SIZE: 8.5pt
}
TD {
	FONT-SIZE: 8.5pt
}
TH {
	FONT-SIZE: 8.5pt
}
BODY {
	BACKGROUND-IMAGE: url(Images/fondo.jpg); BACKGROUND-COLOR: #ffffff
}
</style>
    
    <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="stylesheet" href="Styles/estilos.css" type="text/css"/>
	<script src="Util.js" type="text/javascript"></script>
    <script src="js/jquery.js"></script>
    <script src="js/jquery-ui-1.8rc3.custom.min.js"></script>
    
    <link href="Styles/jquery-ui-1.8rc3.custom.css" rel="stylesheet" />
    <link href="Styles/simpleAutoComplete.css" rel="stylesheet" />

    
    <script>

       
        $(function () {
            $('#txtProducto').simpleAutoComplete('Autocomplete.aspx', {
                autoCompleteClassName: 'autocomplete',
                selectedClassName: 'sel',
                attrCallBack: 'rel',
                identifier: 'Producto'
            }, fnProductoCallback);

        });

        function fnProductoCallback(par) {
            document.getElementById("hdnProductoId").value = par[0];
            document.getElementById("txtStock").value = par[1];
            //par[1] descripcion
        }


        function Confirmacion() {

            return confirm("¿Realmente desea eliminar este detalle de venta?");
        }
    </script>

</head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Images/top_fifiu.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Datos Venta</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->
          <table>
              <tr>
                  
                    <td>
                        <asp:Label runat="server" ID="Label3" Text="Venta Id:"></asp:Label> <br/>
                        <asp:TextBox runat="server" ID="txtVentaId" Width="90" style="font-weight: bold" ReadOnly="True"></asp:TextBox>
                  </td>
                  
                  
                  
                   <td>
                       <asp:Label runat="server" ID="Label1" Text="Cliente:"></asp:Label> <br/>
                        <asp:TextBox runat="server" ID="txtCliente" Width="300" style="font-weight: bold" ReadOnly="True"></asp:TextBox>
                  </td>
                  <td>
                       <asp:Label runat="server" ID="lblFecha" Text="Fecha Venta:"></asp:Label> <br/>
                        <asp:TextBox runat="server" ID="txtFechaVenta" Width="90" style="font-weight: bold" ReadOnly="True"></asp:TextBox>
                  </td>

                   <td>
                       <asp:Label runat="server" ID="Label2" Text="Monto:"></asp:Label> <br/>
                        <asp:TextBox runat="server" ID="txtMonto" Width="90" style="font-weight: bold" ReadOnly="True"></asp:TextBox>
                  </td>
                  
                


              </tr>
              

               <tr >
                  <td colspan="4" style="border-bottom: 1px #666 solid">
                       &nbsp;
                  </td>
                  
              </tr>
              
              
              <tr>
                
                  
                   <td colspan="2">
                       <asp:Label runat="server" ID="Label4" Text="Seleccione Producto:"></asp:Label> <br/>
                        <asp:TextBox runat="server" ID="txtProducto" Width="400" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                       <asp:HiddenField runat="server" ID="hdnProductoId" Value=""/>
                  </td>
                  
                   <td>
                       <asp:Label runat="server" ID="Label5" Text="Cantidad:"></asp:Label> <br/>
                        <ew:NumericBox runat="server" ID="txtCantidad" Width="90" DecimalPlaces="0" ></ew:NumericBox>
                  </td>
                  <td>
                      <asp:Button runat="server" ID="btnAgregarproducto" Text="Agregar Producto" CssClass="boton_formulario" OnClick="btnAgregarproducto_Click"/>
                  </td>

              </tr>
              
                <tr>
                
                  
                   <td >
                       <asp:Label runat="server" ID="Label6" Text="Stock Disponible:"></asp:Label> 
                       
                  </td>
                  
                     <td >
                       
                        <asp:TextBox runat="server" ID="txtStock" Width="100" ></asp:TextBox>
                       
                  </td>

                   <td>
                       
                  </td>
                  <td>
                     
                  </td>

              </tr>

          </table>
          <br />
          <h2>Detalles de Venta</h2>
          
          <asp:GridView ID="gridDetalle" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" 
              GridLines="Horizontal" AutoGenerateColumns="False" OnRowCommand="gridDetalle_RowCommand" >
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Codigo" HeaderStyle-Width="30px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblCCodigo" Text='<%# Eval("Codigo") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Descripcion" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcion" Text='<%# Eval("Descripcion") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Cantidad" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblCantidad" Text='<%# Eval("Cantidad") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Precio Unitario" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPrecioUnitario" Text='<%# Eval("PrecioUnitario") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Subtotal" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblSubtotal" Text='<%# Eval("Subtotal") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Detalle" OnClientClick="return Confirmacion();" ToolTip="Eliminar Detalle" CssClass="cBotones" ImageUrl="~/Images/eliminar.gif"  CommandName="EliminarDetalle" CommandArgument='<%# Eval("Id") %>'/>
                      </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
          </asp:GridView>

        </td>
      
    </tr>
    <tr>
      <td width="200" height="30" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="10" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="770" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="20" bgcolor="#d2d2c6">&nbsp;</td>
    </tr>
  </table>
   
  
    </form>
</body>
</html>

