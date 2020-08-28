<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LiveNotice.LoginPage" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 286px;
        }
        #Text2 {
            width: 283px;
        }
        #Button1 {
            width: 92px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        <br />
        <br />
        Leave Application created by Hitesh Sonar<br />
        <br />
        UserName :
        <asp:TextBox ID="txtUserName" runat="server" Height="21px" OnTextChanged="TextBox1_TextChanged" Width="147px"></asp:TextBox>
        <br />
        <br />
        PassWord :
        <asp:TextBox ID="txtPassword" runat="server" Height="23px" OnTextChanged="TextBox2_TextChanged" Width="150px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home" Width="96px" />
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
