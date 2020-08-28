<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Web App</title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" style="width: 100%; text-align: center; background-color: #00FFFF; font-family: 'Times New Roman', Times, serif; font-size: medium; font-weight: bold; font-variant: normal; text-transform: capitalize; color: #FF0000; border: double;" border="2">
            <tr>
                <td width="40%">
                    <asp:Label ID="Label1" runat="server" Text="Enter User Name"></asp:Label>
                </td>
                <td width="60%" align="left">
                    <asp:TextBox ID="txtUserName" runat="server" Width="208px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="208px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"align="left">
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="2"><asp:TextBox ID="lblErrorMessage" runat="server" Enabled="False" Height="71px" ReadOnly="True" Width="587px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
