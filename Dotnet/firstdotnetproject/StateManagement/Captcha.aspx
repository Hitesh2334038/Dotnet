<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captcha.aspx.cs" Inherits="StateManagement._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <table style="width: 75%; background-color: lightblue">

                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Image ID="imgCaptcha" ImageUrl="Captcha.ashx"
                            Width="199px" Height="45px"
                            runat="server" />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/view_refresh(2).ico" OnClick="ImageButton1_Click" />
                    </td>

                </tr>
                <tr>
                    <td width="40%">&nbsp;</td>
                    <td width="60%">
                        
                        <asp:TextBox ID="txtCaptcha" runat="server" Width="152px"></asp:TextBox>
                        
                        </td>

                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Validate" OnClick="Button1_Click" />
                    </td>

                </tr>
            </table>



        </div>
        <p>
            <asp:TextBox ID="lblErrorMessage" runat="server" BackColor="#CCFF99" Enabled="False" ForeColor="Red" Height="92px" ReadOnly="True" TextMode="MultiLine" Width="532px"></asp:TextBox>
        </p>
    </form>

</body>
</html>
