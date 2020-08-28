<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homrpage.aspx.cs" Inherits="LogibFunctionality.Homrpage" %>

<%@ Register src="AuthenticateUser.ascx" tagname="AuthenticateUser" tagprefix="uc1" %>
<%@ Register src="LogOut.ascx" tagname="LogOut" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        Library Management System
    </h1>
        <uc2:LogOut ID="LogOut1" runat="server" />
        <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="292px" Width="708px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <uc1:AuthenticateUser ID="AuthenticateUser1" runat="server" />
    </form>
</body>
</html>
