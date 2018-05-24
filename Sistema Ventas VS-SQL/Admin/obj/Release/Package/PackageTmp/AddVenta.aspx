<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddVenta.aspx.cs" Inherits="Admin.AddVenta" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin | Alta de Ventas|</title>
	
	 <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <script src="js/jquery.js"></script>
    <script src="js/jquery-ui-1.8rc3.custom.min.js"></script>
    
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
    
    <script>
        
        $(function () {

            //Array para dar formato en español
            $.datepicker.regional['es'] =
            {
                closeText: 'Cerrar',
                prevText: 'Previo',
                nextText: 'Próximo',

                monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio',
                'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun',
                'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                monthStatus: 'Ver otro mes', yearStatus: 'Ver otro año',
                dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sáb'],
                dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                dateFormat: 'dd/mm/yy', firstDay: 0,
                initStatus: 'Selecciona la fecha', isRTL: false
            };
            $.datepicker.setDefaults($.datepicker.regional['es']);

            $("#txtFecha").datepicker({
                dateFormat: 'dd/mm/yy', showOn: 'button', buttonImage: 'images/Calendar_scheduleHS.png', buttonImageOnly: true, changeMonth: true,
                changeYear: true, gotoCurrent: true
            });
        });



        $(function () {
            $('#txtCliente').simpleAutoComplete('Autocomplete.aspx', {
                autoCompleteClassName: 'autocomplete',
                selectedClassName: 'sel',
                attrCallBack: 'rel',
                identifier: 'Cliente'
            }, fnClienteCallback);

        });

        function fnClienteCallback(par) {
            document.getElementById("hdnClienteId").value = par[0];
            //par[1] descripcion
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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Alta de Ventas</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->
          <table>
              
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Fecha Venta" ID="label2"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtFecha"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" errormessage="La fecha de Venta es olbigatoria" width="132px" controltovalidate="txtFecha" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              
                  <tr>
                  <td>
                      <asp:HiddenField runat="server" ID="hdnClienteId" Value="0"/>
                      <asp:Label runat="server" Text="Cliente" ID="label5"></asp:Label>
                       
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtCliente" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" errormessage="El Cliente es olbigatorio" width="132px" controltovalidate="txtCliente" display="Dynamic"></ASP:RequiredFieldValidator>
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
