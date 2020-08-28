<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCalculator.aspx.cs" Inherits="MyFirstWebApp.MyCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 25%;
        }
        #Text1 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Batang; font-size: xx-large; font-weight: bold; color: #FF00FF; width: 753px; text-align: center">
            <strong>My CDAC Calculator </strong>
        </div>
        <table style="width: 30%; background-color: aqua">
            <tr>
                <td width="25%"></td>
                <td width="25%"></td>
                <td width="25%"></td>
                <td width="25%"></td>
            </tr>
            <tr>
                <td colspan="4">

                    <asp:TextBox ID="txtResult" runat="server" Height="38px" Width="246px" Enabled="False" Font-Bold="True" Font-Italic="True" Font-Size="Larger" ForeColor="#FF66FF" ReadOnly="True"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="&lt;---" Font-Size="Large" OnClick="Button2_Click" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="C" Font-Size="Large" OnClick="Button3_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="+" Height="26px" Font-Size="Large" OnClick="Button4_Click" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="-" Font-Size="Large" OnClick="Button5_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="7" Font-Size="Large" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="8" Font-Size="Large" OnClick="Button6_Click" />
                </td>
                <td>
                    <asp:Button ID="Button7" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="9" Font-Size="Large" OnClick="Button7_Click" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="*" Font-Size="Large" OnClick="Button8_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button9" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="4" Font-Size="Large" OnClick="Button9_Click" />
                </td>
                <td>
                    <asp:Button ID="Button10" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="5" Font-Size="Large" OnClick="Button10_Click" />
                </td>
                <td>
                    <asp:Button ID="Button11" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="6" Font-Size="Large" OnClick="Button11_Click" />
                </td>
                <td>
                    <asp:Button ID="Button12" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="/" Font-Size="Large" OnClick="Button12_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <table width="100%">
                        <tr>
                            <td width="75%">

                                <table width="100%">
                                    <tr>
                                        <td width="33%">
                                            <asp:Button ID="Button13" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="1" Font-Size="Large" OnClick="Button13_Click" />
                                        </td>
                                        <td width="33%">
                                            <asp:Button ID="Button14" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="2" Font-Size="Large" OnClick="Button14_Click" />
                                        </td>
                                        <td width="34%">
                                            <asp:Button ID="Button15" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="3" Font-Size="Large" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Button ID="Button17" runat="server" Font-Bold="True" ForeColor="Red" Width="132px" Text="0" Font-Size="Large" OnClick="Button17_Click" />
                                        </td>
                                        <td>
                                            <asp:Button ID="Button19" runat="server" Font-Bold="True" ForeColor="Red" Width="56px" Text="." Font-Size="Large" OnClick="Button19_Click" />
                                        </td>
                                    </tr>
                                </table>

                            </td>
                            <td class="auto-style1">
                                <asp:Button ID="Button18" runat="server" Font-Bold="True" ForeColor="Red" Height="55px" Width="56px" Text="=" Font-Size="Large" OnClick="Button18_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

        </table>
        <asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
        <asp:Button ID="Button20" runat="server" OnClick="Button20_Click" OnLoad="Button20_Load" Text="DisplayName" />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Agree" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <p>
            <asp:TextBox ID="lblErrorMessage" runat="server" Enabled="False" Height="139px" ReadOnly="True" Rows="10" TextMode="MultiLine" Width="662px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
