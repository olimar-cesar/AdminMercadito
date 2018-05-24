<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProducto.aspx.cs" Inherits="Admin.EditProducto" %>


<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin |  Edición de producto</title>
	
	
     <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <script src="js/jquery-ui-1.8rc3.custom.min.js"></script>
    <script src="js/jquery.js"></script>
    <link href="Styles/jquery-ui-1.8rc3.custom.css" rel="stylesheet" />
    <link href="Styles/simpleAutoComplete.css" rel="stylesheet" />

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
    
    
   <script type="text/javascript" language="javascript">

       $(function () {
           $('#txtCompra').simpleAutoComplete('Autocomplete.aspx', {
               autoCompleteClassName: 'autocomplete',
               selectedClassName: 'sel',
               attrCallBack: 'rel',
               identifier: 'Compra'
           }, fnCompraCallback);

       });

       function fnCompraCallback(par) {
           document.getElementById("hdnCompraId").value = par[0]; //par[0] id
          
       }


       $(function () {
           $('#txtColor').simpleAutoComplete('Autocomplete.aspx', {
               autoCompleteClassName: 'autocomplete',
               selectedClassName: 'sel',
               attrCallBack: 'rel',
               identifier: 'Color'
           }, fnColorCallback);

       });

       function fnColorCallback(par) {
          
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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Edición de producto</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">
          <!--Contenido aqui-->
          <table>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Id Producto" ID="labelProductoId"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtId"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Código" ID="label6"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtCodigo"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" errormessage="El Codigo es Obligatorio" width="132px" controltovalidate="txtCodigo" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>

              <tr>
                  <td>
                      <asp:Label runat="server" Text="Descripcion" ID="label1"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="3"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="rfvValidarNombre" runat="server" errormessage="La descripcion es obligatoria" width="132px" controltovalidate="txtDescripcion" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Tipo Producto" ID="label2"></asp:Label>
                  </td>
                  <td>
                      <asp:DropDownList runat="server" ID="ddlTipo" />
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Color" ID="label4"></asp:Label>
                       
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtColor" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" errormessage="El color es obligatorio" width="132px" controltovalidate="txtColor" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Talle" ID="label7"></asp:Label>
                  </td>
                  <td>
                      <asp:DropDownList runat="server" ID="ddlTalle" />
                  </td>
              </tr>
              
               <tr>
                  <td>
                      <asp:Label runat="server" Text="Precio Costo" ID="label8"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtPrecioCosto"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" errormessage="El Precio de Costo es Obligatorio" width="132px" controltovalidate="txtPrecioCosto" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              
               <tr>
                  <td>
                      <asp:Label runat="server" Text="Porcentaje de Ganancia" ID="label9"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtPorcGanancia"></asp:TextBox>
                  </td>
              </tr>
               <tr>
                  <td>
                      <asp:Label runat="server" Text="Precio de Venta" ID="label10"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtPrecioVenta"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" errormessage="El Precio de Venta es obligatorio" width="132px" controltovalidate="txtPrecioVenta" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
               <tr>
                  <td>
                      <asp:Label runat="server" Text="Stock" ID="label11"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtStockActual"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" errormessage="El Stock es Obligatorio" width="132px" controltovalidate="txtStockActual" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
               <tr>
                  <td>
                      <asp:Label runat="server" Text="Porcentaje de Descuento" ID="label12"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtPorcDescuento"></asp:TextBox>
                  </td>
              </tr>

                <tr>
                  <td>
                      <asp:Label runat="server" Text="Compra" ID="label5"></asp:Label>
                       
                  </td>
                  <td>
                      <asp:HiddenField runat="server" ID="hdnCompraId" Value="0"/>
                      <asp:TextBox runat="server" ID="txtCompra" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" errormessage="La compraes obligatoria" width="132px" controltovalidate="txtCompra" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
            
              
                  <tr>
                  <td>
                      <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="boton_formulario" OnClick="btnGuardar_Click" />
                  </td>
                  <td>
                      
                  </td>
              </tr>
          </table>

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
