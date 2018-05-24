<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Admin.Test" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    
    <script>
        function AbrirVentana() {

            var caracteristicas = "height=500,width=800,scrollTo,resizable=1,scrollbars=1,location=0";
            var nueva = window.open(window.location.href.replace("Test.aspx", "EditCliente.aspx"), 'Popup', caracteristicas);
            return false;

           // window.open(window.location.href.replace("Test.aspx", "EditCliente.aspx"), "_blank");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="#" onclick="AbrirVentana();">Abrir ventana</a>
    </div>
    </form>
</body>
</html>
