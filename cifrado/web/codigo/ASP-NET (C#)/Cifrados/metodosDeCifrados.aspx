<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="metodosDeCifrados.aspx.cs"
    Inherits="Cifrados.metodosDeCifrados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Metódos de cifrado</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #desplazamiento {
            height: 18px;
        }

        #cifrado {
            height: 20px;
        }

        #TransposicionInversa {
            height: 15px;
        }

        #grupos {
            height: 18px;
        }

        #Text1 {
            height: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Cifrados</h1>
        <div id="contenedor">


            <div id="textoPlano">
                <asp:Label ID="LabelTextPlano" runat="server" Text="Texto plano:"></asp:Label>
                <asp:TextBox ID="txtPlano" runat="server" Height="61px" Width="298px"
                    OnTextChanged="txtPlano_TextChanged" onkeypress="sentServer()"></asp:TextBox>
            </div>

            <div id="Cesar">
                <h2>Cifrado Cesar</h2>
                <label for="desplazamiento">Desplazamiento: </label>
                <asp:TextBox ID="numDesplazamiento" runat="server" MaxLength="100"
                    TextMode="Number"></asp:TextBox>
                &nbsp;<label for="cifrado">Cifrado: </label>
                &nbsp;<asp:TextBox ID="txtCifradoCesar" runat="server" Width="159px"></asp:TextBox>
            </div>

            <div id="TI">
                <h2>TI</h2>
                <label for="TransposicionInversa">Cifrado: </label>
                &nbsp;<asp:TextBox ID="txtCifradoTI" runat="server" Width="167px"></asp:TextBox>
            </div>

            <div id="TIP">
                <h2>TIP</h2>
                <label for="grupos">Grupos: </label>
                <asp:TextBox ID="numGrupos" runat="server" MaxLength="100" TextMode="Number"></asp:TextBox>
                &nbsp;<label for="cifrado">Cifrado: </label>
                &nbsp;<asp:TextBox ID="txtCifradoTIP" runat="server"></asp:TextBox>
            </div>


        </div>
    </form>
    <script type="text/javascript" src="js/script.js"></script>
</body>
</html>
