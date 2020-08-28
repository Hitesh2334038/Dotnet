<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateCityInfo.aspx.cs" Inherits="MyFirstWebApp.StateCityInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
            <ContentTemplate>
                <div>
                    Drop Down List
        <br />
                    <br />
                    <strong>Select State&nbsp;&nbsp;&nbsp; </strong>
                    <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" Width="240px">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <strong>Select City&nbsp;&nbsp;&nbsp; </strong>
                    <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" Height="16px" Width="240px">
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="289px" Width="674px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
