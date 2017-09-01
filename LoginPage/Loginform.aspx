<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Loginform.aspx.cs" Inherits="Loginform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 170px;
        }
        .auto-style5 {
            width: 109px;
            height: 70px;
        }
        .auto-style6 {
            text-align: right;
            width: 170px;
            height: 70px;
        }
        .auto-style7 {
            height: 70px;
        }
        .auto-style8 {
            width: 170px;
            height: 70px;
        }
    </style>
</head>
<body style="height: 262px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Login Page</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style6">E-mail:</td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="emailuserBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailuserBox" ErrorMessage="Please enter Username"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="passuserBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passuserBox" ErrorMessage="Please enter Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" Width="87px" />
                </td>
                <td class="auto-style7">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegistrationPage.aspx">Register New Customer</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
