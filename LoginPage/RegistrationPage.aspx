<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 534px;
        }
        .auto-style3 {
            width: 214px;
        }
        .auto-style5 {
            text-align: center;
            font-size: large;
        }
        .auto-style6 {
            text-align: right;
            height: 70px;
        }
        .auto-style7 {
            text-align: left;
            height: 70px;
        }
        .auto-style8 {
            height: 70px;
        }
        #Reset1 {
            width: 85px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" colspan="2">RegistrationPage</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">First Name:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="firstBox" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstBox" ErrorMessage="First Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">Last Name:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="lastBox" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastBox" ErrorMessage="Last Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">E-mail:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="emailBox" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailBox" ErrorMessage="E-mail Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="You must enter the valid email id" ForeColor="Red" ControlToValidate="emailBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">Phone No:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="phoneBox" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="phoneBox" ErrorMessage="Phone Number Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="passBox" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="passBox" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style6">Confirm Password:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="confrBox" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="confrBox" ErrorMessage="Confirm Pasword Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passBox" ControlToValidate="confrBox" ErrorMessage="Both passwords must match" ForeColor="Red"></asp:CompareValidator>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" Width="76px" OnClick="reges_Click" />
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
