<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationsPage.aspx.cs" Inherits="ReservationsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 636px;
        }
        .auto-style2 {
            width: 205px;
        }
        .auto-style3 {
            height: 60px;
        }
        .auto-style4 {
            width: 205px;
            height: 70px;
        }
        .auto-style5 {
            height: 70px;
        }
        .auto-style6 {
            height: 70px;
            width: 214px;
        }
        .auto-style7 {
            height: 70px;
            width: 167px;
        }
        .auto-style8 {
            height: 70px;
            width: 124px;
        }
        #TextArea1 {
            height: 108px;
            width: 574px;
        }
        #textArea {
            height: 94px;
            width: 480px;
            margin-top: 0px;
        }
        .auto-style9 {
            width: 205px;
            height: 74px;
        }
        .auto-style10 {
            height: 74px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="5" style="text-align: center">Reservation Page</td>
            </tr>
            <tr>
                <td class="auto-style4">Room Type</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dropdownRoom" AutoPostBack="true" runat="server" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="141px">
                        <asp:ListItem>Select Room Type</asp:ListItem>
                        <asp:ListItem Value="1">Single</asp:ListItem>
                        <asp:ListItem Value="2">Double</asp:ListItem>
                        <asp:ListItem Value="3">Suite</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Number of beds: "></asp:Label>
                    <asp:Label ID="bedNo" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Size: "></asp:Label>
                    <asp:Label ID="sizeNo" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Rate: "></asp:Label>
                    <asp:Label ID="rateNo" runat="server" Text="0 "></asp:Label>
                    <asp:Label ID="sizeNo0" runat="server" Text="Kr"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Check-In Date</td>
                <td colspan="4" class="auto-style5">
                    <asp:Calendar ID="checkIncal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Check-Out Date</td>
                <td colspan="4" class="auto-style5">
                    <asp:Calendar ID="checkOutcal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Comment</td>
                <td colspan="4">
                    <asp:TextBox ID="comentsec" runat="server" Width="404px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td colspan="2" class="auto-style10">
                    <asp:Button ID="resvButton" runat="server" Height="36px" OnClick="resvButton_Click" style="margin-top: 0px" Text="Reserve Room" Width="173px" />
                </td>
                <td colspan="2" class="auto-style10">
                    <asp:Button ID="cancelButton" runat="server" Height="36px" style="margin-top: 0px" Text="Cancel" Width="173px" OnClick="cancelButton_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
