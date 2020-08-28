<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewliveDetails.aspx.cs" Inherits="LiveNotice.ViewliveDetails" %>

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
            <strong>Leave Details</strong>
            <br />
            Hi......mr/ms 
            <asp:Label ID="lblUsername" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
