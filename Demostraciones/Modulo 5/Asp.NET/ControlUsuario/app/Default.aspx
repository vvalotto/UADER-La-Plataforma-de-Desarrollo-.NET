<%@ Page Language="C#" 
         AutoEventWireup="true" 
         CodeFile="~/app/Default.aspx.cs" 
         Inherits="_Default" 
         CodeBehind="~/app/Default.aspx.cs"
         EnableEventValidation="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EJEMPLO DE VALIDADORES EN ASP.NET</title>
    <script type="text/javascript">
        function caracteresInvalidos(sender, args) 
        {
            var textBox = document.getElementById(sender.controltovalidate).value;
            args.IsValid = false;

            args.IsValid = (textBox.indexOf('<') == -1) &&
                   (textBox.indexOf('>') == -1) &&
                   (textBox.indexOf('%') == -1);
            sender.isvalid = args.IsValid;
        }

        function CuitValido(source, clientside_arguments) {
            var cuit = clientside_arguments.Value;

            cuit = cuit.replace(/[-_]/g, "");
            if (cuit.length != 11) {
                clientside_arguments.IsValid = false;
                return;
            }
            else {
                var prefijo = [20, 23, 24, 27, 30, 33];
                var prefijoOk = false;

                for (var i = 0; i < prefijo.length; i++) {
                    if (prefijo[i] == parseInt(cuit.substring(0, 2))) {
                        prefijoOk = true;
                        break;
                    }
                }

                if (!prefijoOk) {
                    clientside_arguments.IsValid = false;
                    return;
                }
                else {
                    var mult = [5, 4, 3, 2, 7, 6, 5, 4, 3, 2];
                    var total = 0;
                    for (var i = 0; i < mult.length; i++) {
                        var cuitAux = cuit.substring(i, i + 1);
                        total += parseInt(cuitAux) * mult[i];
                        //total += parseInt(cuit[i]) * mult[i];     cuit[i] no anda en ie7
                    }

                    var mod = total % 11;

                    var digito;
                    if (mod == 0) {
                        digito = 0;
                    } else if (mod == 1) {
                        digito = 9;
                    } else {
                        digito = 11 - mod;
                    }

                    cuitAux = cuit.substring(10, 11);
                    if (digito == parseInt(cuitAux)) {
                        clientside_arguments.IsValid = true;
                        return;
                    } else {
                        clientside_arguments.IsValid = false;
                        return;
                    }
                }
            }
        }
    </script>    
</head>
<body>


    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <cu:formulario ID="ucFormulario" runat="server" /> 

    <div align="center">
        <asp:Button ID="btnAceptar" 
                    runat="server" 
                    ValidationGroup="Curso" 
                    Text="Aceptar"
                    onclick="btnAceptar_Click"  />
        <asp:Button ID="btnCancelar" 
                    runat="server" 
                    Text="Cancelar"
                    CausesValidation="false" onclick="btnCancelar_Click" />
    </div>
    </div>

    <div align="center">
        <asp:Label ID="lblResultado" runat="server" ForeColor="Red" Font-Bold="True" 
            Font-Size="25px" />
    </div>
    </form>
</body>
</html>
