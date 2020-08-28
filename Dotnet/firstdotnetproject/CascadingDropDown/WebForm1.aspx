<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CascadingDropDown.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 244px;
        }
        .auto-style3 {
            width: 244px;
        }
        .auto-style4 {
            height: 23px;
            width: 106px;
        }
        .auto-style5 {
            width: 106px;
        }
        #Text1 {
            width: 219px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
 
        <h1> Cascading Drop Down Controls </h1>
        <p>
            Please Enter Name&nbsp;
            <input id="Text1" type="text" /></p>
        <p> &nbsp;</p>

        <table width="100%" style="background-color:lightyellow">
            <tr>
                <td class="auto-style4" style="height:75px"></td>
                <td class="auto-style2">Country</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlCOuntry" runat="server" Height="16px" Width="298px" AutoPostBack="True" OnSelectedIndexChanged="ddlCOuntry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td class="auto-style5" style="height:75px"></td>
                <td class="auto-style3">State</td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server" Height="16px" Width="298px" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                    </asp:DropDownList>
                 </td>
            </tr>
             <tr>
                <td class="auto-style5" style="height:75px"></td>
                <td class="auto-style3">City</td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" Height="16px" Width="298px" AutoPostBack="True">
                    </asp:DropDownList>
                 </td>
            </tr>
        </table>

    </form>
</body>
</html>
