<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCatalog.aspx.cs" Inherits="LogibFunctionality.DisplayCatalog" %>

<%@ Register src="AuthenticateUser.ascx" tagname="AuthenticateUser" tagprefix="uc1" %>
<%@ Register src="LogOut.ascx" tagname="LogOut" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
        Display Catalog
    </h1>
    </div>
        <uc1:AuthenticateUser ID="AuthenticateUser1" runat="server" />
        <uc2:LogOut ID="LogOut1" runat="server" />
    </form>
</body>
</html>
