<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>GerCity - Login</title>
     
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css" />
    
    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">

        <div style="height: 363px; width: 363px; position: absolute; top: 25%; left: 50%; transform: translate(-50%, -50%);">

            <div class="card-panel teal cyan" style="text-align: center">
                <b><span class="white-text">Faça login na sua conta da GerCity</span></b>
            </div>

            <br />
            <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label>
            <br />
            <asp:TextBox ID="txtLogin" runat="server" Width="363px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" type="password" runat="server" Width="363px"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" BorderStyle="None"
                Width="363px" Height="45px" Style="text-align: center" OnClick="btnEntrar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
