<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forma1.aspx.cs" Inherits="PirmasWeb.Forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pirmas puslapis</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="Black" ForeColor="White"></asp:Label></div>
        <div>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            &nbsp;</div>
        <div>
            <asp:Button runat="server" Text="Gerai!" ID="Button1" OnClick="Button1_Click"></asp:Button>
            &nbsp;</div>
    </form>
</body>
</html>
