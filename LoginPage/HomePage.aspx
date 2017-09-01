<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 234px;
        }
        .auto-style2 {
            height: 23px;
            text-align: center;
        }
        .auto-style3 {
            height: 67px;
        }
        .auto-style4 {
            height: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">Home Page</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ReservationsPage.aspx">Reserv A Hotel Room</asp:HyperLink>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="ourdatabase">
                        <AlternatingItemTemplate>
                            <tr style="background-color:#FFF8DC;">
                                <td>
                                    <asp:Label ID="roomidLabel" runat="server" Text='<%# Eval("roomid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="arriveDateLabel" runat="server" Text='<%# Eval("arriveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="leaveDateLabel" runat="server" Text='<%# Eval("leaveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkinLabel" runat="server" Text='<%# Eval("checkin") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkoutLabel" runat="server" Text='<%# Eval("checkout") %>' />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <tr style="background-color:#008A8C;color: #FFFFFF;">
                                <td>
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                </td>
                                <td>
                                    <asp:TextBox ID="roomidTextBox" runat="server" Text='<%# Bind("roomid") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="arriveDateTextBox" runat="server" Text='<%# Bind("arriveDate") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="leaveDateTextBox" runat="server" Text='<%# Bind("leaveDate") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="checkinTextBox" runat="server" Text='<%# Bind("checkin") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="checkoutTextBox" runat="server" Text='<%# Bind("checkout") %>' />
                                </td>
                            </tr>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                <tr>
                                    <td>No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                </td>
                                <td>
                                    <asp:TextBox ID="roomidTextBox" runat="server" Text='<%# Bind("roomid") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="arriveDateTextBox" runat="server" Text='<%# Bind("arriveDate") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="leaveDateTextBox" runat="server" Text='<%# Bind("leaveDate") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="checkinTextBox" runat="server" Text='<%# Bind("checkin") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="checkoutTextBox" runat="server" Text='<%# Bind("checkout") %>' />
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <tr style="background-color:#DCDCDC;color: #000000;">
                                <td>
                                    <asp:Label ID="roomidLabel" runat="server" Text='<%# Eval("roomid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="arriveDateLabel" runat="server" Text='<%# Eval("arriveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="leaveDateLabel" runat="server" Text='<%# Eval("leaveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkinLabel" runat="server" Text='<%# Eval("checkin") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkoutLabel" runat="server" Text='<%# Eval("checkout") %>' />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                                <th runat="server">roomid</th>
                                                <th runat="server">arriveDate</th>
                                                <th runat="server">leaveDate</th>
                                                <th runat="server">checkin</th>
                                                <th runat="server">checkout</th>
                                            </tr>
                                            <tr id="itemPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                                <td>
                                    <asp:Label ID="roomidLabel" runat="server" Text='<%# Eval("roomid") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="arriveDateLabel" runat="server" Text='<%# Eval("arriveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="leaveDateLabel" runat="server" Text='<%# Eval("leaveDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkinLabel" runat="server" Text='<%# Eval("checkin") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="checkoutLabel" runat="server" Text='<%# Eval("checkout") %>' />
                                </td>
                            </tr>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:SqlDataSource ID="ourdatabase" runat="server" ConnectionString="<%$ ConnectionStrings:dat154_2ConnectionString %>" SelectCommand="SELECT [roomid], [arriveDate], [leaveDate], [checkin], [checkout] FROM [booking] WHERE ([customerid] = @customerid)">
                        <SelectParameters>
                            <asp:SessionParameter Name="customerid" SessionField="customerIds" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" Width="92px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
