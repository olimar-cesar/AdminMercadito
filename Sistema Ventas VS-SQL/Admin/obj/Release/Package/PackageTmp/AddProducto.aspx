<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProducto.aspx.cs" Inherits="Admin.AddProducto" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<%@ Register Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" Namespace="eWorld.UI" TagPrefix="ew" %> 

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin | Alta de Productos|</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="stylesheet" href="Styles/estilos.css" type="text/css"/>
    
    <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
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
            document.getElementById("txtMonto").value = par[2];
            document.getElementById("txtFechaCompra").value = par[3];
            document.getElementById("txtProveedor").value = par[4];

        }


        $(function () {

            $("input[id^='gridProductos_txtColor_']").each(function () {
                $('#'+this.id).simpleAutoComplete('Autocomplete.aspx', {
                    autoCompleteClassName: 'autocomplete',
                    selectedClassName: 'sel',
                    attrCallBack: 'rel',
                    identifier: 'Color'
                }, fnColorCallback);

            });
           

        });


        function fnColorCallback(par) {
         }


        function SetearPrecioVenta(obj) {

            //gridProductos_txtPrecioCosto_0
            //gridProductos_txtPorcGanancia_0
            //gridProductos_txtPrecioVenta_0

            var aDatos = obj.id.split('_');
            var PorGanancia = obj.value;

            var PrecioCosto = parseFloat(document.getElementById("gridProductos_txtPrecioCosto_" + aDatos[2]).value);

            document.getElementById("gridProductos_txtPrecioVenta_" + aDatos[2]).value = (PrecioCosto + PrecioCosto * PorGanancia / 100).toFixed(2);


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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Alta de productos</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->
          <asp:HiddenField runat="server" ID="hdnCompraId" Value="0"/>
          <div style="width: 100%">
              <table>
                  <tr>
                      <td><asp:Label runat="server" ID="lblCompra" Text="Compra:"> </asp:Label></td>
                      <td><asp:TextBox runat="server" ID="txtCompra" Width="180" onkeypress="return event.keyCode!=13;"></asp:TextBox></td>
                      <td></td>
                      <td><asp:Label runat="server" ID="Label1" Text="Monto:"> </asp:Label></td>
                      <td><asp:TextBox runat="server" ID="txtMonto" ReadOnly="True" Width="60"></asp:TextBox></td>
                      <td></td>
                      <td><asp:Label runat="server" ID="Label2" Text="Proveedor:"> </asp:Label></td>
                      <td><asp:TextBox runat="server" ID="txtProveedor" ReadOnly="True" Width="190"></asp:TextBox></td>
                       <td></td>
                      <td><asp:Label runat="server" ID="Label3" Text="Fecha Compra:"> </asp:Label></td>
                      <td><asp:TextBox runat="server" ID="txtFechaCompra" ReadOnly="True" Width="70"></asp:TextBox></td>
                  </tr>
              </table>
              <br />
          </div>
          

          <asp:GridView ID="gridProductos" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" 
              GridLines="Horizontal" AutoGenerateColumns="False" OnRowDataBound="gridProductos_RowDataBound">
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="#" HeaderStyle-Width="20px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblCodigo" Width="20" Text='<%# Eval("Renglon") %>' ></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Codigo" HeaderStyle-Width="50px">
                      <ItemTemplate>
                          <ew:NumericBox runat="server" ID="txtCodigo" Width="50" DecimalPlaces="0" PlacesBeforeDecimal="6" ></ew:NumericBox>

                      </ItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Descripcion" HeaderStyle-Width="150px">
                      <ItemTemplate>
                           <asp:TextBox runat="server" ID="txtDescripcion" Width="150"></asp:TextBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Tipo" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:DropDownList runat="server" ID="ddlTipo"  Width="100"/>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Color" HeaderStyle-Width="100px">
                      <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtColor"  Width="100" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Talle" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:DropDownList runat="server" ID="ddlTalle"  Width="100"/>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Precio Costo" HeaderStyle-Width="50px">
                      <ItemTemplate>
                            <ew:NumericBox runat="server" ID="txtPrecioCosto"  Width="50" DecimalPlaces="2" PlacesBeforeDecimal="8"></ew:NumericBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Porc Ganancia" HeaderStyle-Width="50px">
                      <ItemTemplate>
                            <ew:NumericBox runat="server" ID="txtPorcGanancia"  Width="50" onblur="SetearPrecioVenta(this);" DecimalPlaces="2" PlacesBeforeDecimal="8" ></ew:NumericBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Precio Venta" HeaderStyle-Width="50px">
                      <ItemTemplate>
                            <ew:NumericBox runat="server" ID="txtPrecioVenta"  Width="50" DecimalPlaces="2" PlacesBeforeDecimal="8"></ew:NumericBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Stock Actual" HeaderStyle-Width="50px">
                      <ItemTemplate>
                            <ew:NumericBox runat="server" ID="txtStockActual"  Width="50" DecimalPlaces="0" PlacesBeforeDecimal="8"></ew:NumericBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Porc Descuento" HeaderStyle-Width="50px">
                      <ItemTemplate>
                            <ew:NumericBox runat="server" ID="txtPorcDescuento"  Width="50"  Text='<%# Eval("PorcDescuento") %>' DecimalPlaces="2" PlacesBeforeDecimal="8"></ew:NumericBox>
                      </ItemTemplate>
                  </asp:TemplateField>
                  
              </Columns>
          </asp:GridView>
          
          <asp:Button runat="server" ID="btnGuardar" CssClass="boton_formulario" Text="Guardar" OnClick="btnGuardar_Click"/>
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

