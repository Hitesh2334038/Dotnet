<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="RegistrationForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WELCOME<br />
            UserName :
            <asp:TextBox ID="txtUserName" runat="server" Width="200px" style="margin-left: 24px"></asp:TextBox>
            <br />
            <br />
            Password :
            <asp:TextBox ID="txtPassword" runat="server" Width="203px" style="margin-left: 29px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Width="77px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Registration" Width="88px" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
