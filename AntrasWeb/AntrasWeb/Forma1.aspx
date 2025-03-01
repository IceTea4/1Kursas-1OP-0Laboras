<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forma1.aspx.cs" Inherits="AntrasWeb.Forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Kūgio aukštinė, H"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Kūgio spindulys, R"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Kūgio spindulys, r"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox3" runat="server">0</asp:TextBox>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Kūgio tūris"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox4" runat="server">0</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Skaičiuoti!" OnClick="Button1_Click" />
    </form>
</body>
</html>
