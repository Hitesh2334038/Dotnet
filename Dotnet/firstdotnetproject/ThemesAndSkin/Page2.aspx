<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="ThemesAndSkin.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel runat="server" ID="pnlDisplayInfo" Width="500px" Height="400px">
            <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go to Default" OnClick="Button1_Click" />
             <br />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Label"></asp:Label>
            <br />
             <br />


            <asp:DropDownList ID="DropDownList1" runat="server" Width="176px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
             <br />
            
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
              <br />
            <asp:GridView ID="GridView1" runat="server" Width="357px"></asp:GridView>




        </asp:Panel>


    </form>
</body>
</html>
