<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LiveNotice.HomePage" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
            <br />
            Welcome To _____.org
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ViewInfo" Width="88px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ApplyForLeave" />
            <br />
        </div>
    </form>
</body>
</html>
