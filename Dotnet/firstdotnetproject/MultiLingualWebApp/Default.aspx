<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiLingualWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;
    <asp:Label ID="lblLanguage0" runat="server" Text="<%$ Resources:DACMLA, AppBanner %>" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
            <br />
            <br />

        </div>
        <asp:Panel ID="Panel1" runat="server" Height="50px" Width="682px">
            <asp:Label ID="lblLanguage" runat="server" Text="<%$ Resources:DACMLA, Language %>"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            
                <asp:DropDownList ID="ddlLanguage" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="-1">Select a language</asp:ListItem>
                    <asp:ListItem Value="hi-IN">Hindi</asp:ListItem>
                    <asp:ListItem Value="en-US">US English</asp:ListItem>
                    <asp:ListItem Value="en-IN">India English</asp:ListItem>
                    <asp:ListItem Value="ta-IN">Tamil</asp:ListItem>
                    <asp:ListItem Value="te-IN">Telugu</asp:ListItem>
                    <asp:ListItem Value="mr-IN">Marathi</asp:ListItem>
                </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblWelcome" runat="server" Text="<%$ Resources:DACMLA, Weclometext %>" Width="504px"></asp:Label>
        </asp:Panel>
        &nbsp;
        <br />
        <br />
        <asp:Label ID="lblAmount" runat="server" Text="<%$ Resources:DACMLA, Amount %>"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="txtMoney" runat="server" Width="239px"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Label ID="lblCalendar" runat="server" Text="<%$ Resources:DACMLA, Calendar %>" Width="312px"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="cldCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="352px">
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TodayDayStyle BackColor="#CCCCCC" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
        </asp:Calendar>
        <br />
        <asp:Button ID="btnBook" runat="server" Text="<%$ Resources:DACMLA, book %>" Width="275px" />
    &nbsp;
        <asp:Button ID="btnReset" Text="<%$ Resources:DACMLA, reset %>" runat="server" Width="284px"  />
    </form>
</body>
</html>
