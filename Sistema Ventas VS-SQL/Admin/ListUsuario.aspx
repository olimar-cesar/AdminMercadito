<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListUsuario.aspx.cs" Inherits="Admin.ListUsuario" %>


<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| El Mercadito | Listado Usuarios|</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="stylesheet" href="Styles/estilos.css" type="text/css"/>
    <link rel="shortcut icon" href="../Images/favicon.png"/> 
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
</style></head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Images/elmercadito.png" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Listado de Usuarios</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

       <!--Contenido aqui-->

          <asp:GridView ID="gridUsuarios" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" 
              GridLines="Horizontal" AutoGenerateColumns="False" OnRowCommand="gridUsuarios_RowCommand">
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="30px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblClienteId" Text='<%# Eval("Id") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Usuario" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblUserName" Text='<%# Eval("UserName") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="PerfilId" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblPerfilId" Text='<%# Eval("PerfilId") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="password" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblpassword" Text='<%# Eval("password") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server" ID="btnEditar" AlternateText="Editar Usuario" ToolTip="Editar Usuario" CssClass="cBotones" ImageUrl="~/Images/edit.png" CommandName="EditarUsuario" CommandArgument='<%# Eval("Id") %>'/>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Usuario" ToolTip="Eliminar Usuario" CssClass="cBotones" ImageUrl="~/Images/eliminar.gif"  CommandName="EliminarUsuario" CommandArgument='<%# Eval("Id") %>'/>
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
