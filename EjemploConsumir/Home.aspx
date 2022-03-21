<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EjemploConsumir.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblnum1" Text="Ingrese el primer valor" runat="server"/>
            <br />
            <asp:TextBox ID="valora" runat="server"/>
                <br />
            <asp:Label ID="lblnum2" Text="Ingrese el segundo valor" runat="server"/>
            <br />
            <asp:TextBox ID="valorb" runat="server"/>
                <br /><br />
            
            <asp:Button ID="btn_suma" Text="Sumar" runat="server" OnClick="btn_suma_Click" />
            <asp:Button ID="btn_resta" runat="server" Text="Restar" OnClick="btn_resta_Click" />
            <asp:Button ID="btn_multiplicacion" runat="server" Text="Multiplicar" OnClick="btn_multiplicacion_Click" />
            <asp:Button ID="btn_division" runat="server" Text="Dividir" OnClick="btn_division_Click" />
                <br />

            <hr />
            <asp:Label ID="Label1" runat="server" Text="El resultado es: "></asp:Label>
            <asp:Label ID="lblresultado"  runat="server"/>
                <br />
        </div>
    </form>
</body>
</html>
