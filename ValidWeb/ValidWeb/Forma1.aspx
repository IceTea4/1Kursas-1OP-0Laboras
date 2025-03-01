<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forma1.aspx.cs" Inherits="ValidWeb.Forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Konkurso dalyio registracija:"></asp:Label>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <asp:Label ID="Label2" runat="server" Text="Vardas:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vardas yra privalomas" ControlToValidate="TextBox1" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Blogas vardas" ControlToValidate="TextBox1" ForeColor="Red" ValidationExpression="[A-Z][a-z]*" >*</asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Pavardė:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Pavardė yra privaloma" ControlToValidate="TextBox2" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Bloga pavardė" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="[A-Z][a-z]*" >*</asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Mokyklos pavadinimas:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mokykla yra privaloma" ControlToValidate="TextBox3" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="Validate_TextBox3" ControlToValidate="TextBox3" ErrorMessage="Blogas pavadinimas" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Amžius:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Neteisinga metų reikšmė" ForeColor="Red" MaximumValue="25" MinimumValue="14" Type="Integer">*</asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Programavimo kalba:"></asp:Label>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="title" DataValueField="title">
            </asp:CheckBoxList>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/kalbos.xml"></asp:XmlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Registruotis" OnClick="Button1_Click"/>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Pašalinti įrašus" Width="105px" OnClick="Button2_Click" CausesValidation="False" />
            <br />
            <br />
            <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderWidth="1px" Width="730px">
            </asp:Table>
        </div>
    </form>
</body>
</html>
