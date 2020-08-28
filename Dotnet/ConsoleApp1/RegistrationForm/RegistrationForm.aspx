<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="RegistrationForm.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Registration Form<br />
        UserName :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxTUserName" runat="server"></asp:TextBox>
        <br />
        <br />
        PhoneNo :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxTphoneNo" runat="server"></asp:TextBox>
        <br />
        <br />
        EmailId :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxTEmailId" runat="server"></asp:TextBox>
        <br />
        <br />
        PassWord :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="TxTPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        CPassword :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxTCPassword" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Confirm" Width="71px" OnClick="Button1_Click" />
        <br />
        <br />
    </form>
</body>
</html>
