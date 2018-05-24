<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProducto.aspx.cs" Inherits="Admin.ListProducto" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin | Listado Productos|</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="stylesheet" href="Styles/estilos.css" type="text/css"/>
    
	<script src="Util.js" type="text/javascript"></script>

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
    
    
    <script>
        function Confirmacion() {

            return confirm("¿Realmente desea eliminar este producto?");
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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Listado de Productos</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->

          <asp:GridView ID="gridproductos" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" 
              GridLines="Horizontal" AutoGenerateColumns="False" OnRowCommand="gridproductos_RowCommand" >
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="30px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblId" Text='<%# Eval("Id") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Codigo" HeaderStyle-Width="20px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblCodigo" Text='<%# Eval("Codigo") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Descripcion" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcion" Text='<%# Eval("Descripcion") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <%--									--%>
                   <asp:TemplateField HeaderText="Talle" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcionTalle" Text='<%# Eval("DescripcionTalle") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>  
                  <asp:TemplateField HeaderText="Tipo" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcionTipo" Text='<%# Eval("DescripcionTipo") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Color" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcionColor" Text='<%# Eval("DescripcionColor") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Proveedor" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcionProveedor" Text='<%# Eval("DescripcionProveedor") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Precio Costo" HeaderStyle-Width="60px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPrecioCosto" Text='<%# Eval("PrecioCosto") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Porc Ganancia" HeaderStyle-Width="60px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPorcGanancia" Text='<%# Eval("PorcGanancia") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Precio Venta" HeaderStyle-Width="600px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPrecioVenta" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Stock" HeaderStyle-Width="600px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblStockActual" Text='<%# Eval("StockActual") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Porc Descuento" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPorcDescuento" Text='<%# Eval("PorcDescuento") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   

                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server" ID="btnEditar" AlternateText="Editar Compra" ToolTip="Editar Compra" CssClass="cBotones" ImageUrl="~/Images/edit.png" CommandName="EditarProducto" CommandArgument='<%# Eval("Id") %>'/>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Compra" ToolTip="Eliminar Compra" OnClientClick="return Confirmacion();" CssClass="cBotones" ImageUrl="~/Images/eliminar.gif"  CommandName="EliminarProducto" CommandArgument='<%# Eval("Id") %>'/>
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
