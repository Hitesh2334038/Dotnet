<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName&nbsp;&nbsp;
            <asp:Label ID="lblusername" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Password&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblpassword" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
