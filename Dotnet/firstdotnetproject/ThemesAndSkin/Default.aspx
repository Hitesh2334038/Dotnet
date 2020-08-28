<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThemesAndSkin._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please select a Theme --&gt;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="168px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Please select a Theme</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
            <asp:ListItem>Pink</asp:ListItem>
        </asp:DropDownList>
            <br />
            <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlDisplayInfo" Width="500px" Height="400px">
                <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="GO to Page 2" OnClick="Button1_Click" />
                <br />

                <asp:DropDownList ID="DropDownList2" runat="server" Width="176px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
                <br />

                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:GridView ID="GridView1" runat="server" Width="357px"></asp:GridView>




            </asp:Panel>

        </div>
    </form>
</body>
</html>
