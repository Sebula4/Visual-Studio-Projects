<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Karate_Payments_Grid._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Karate Payments</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Payments By Karate Students</h1>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="Blue" BorderWidth="1px" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="First Name" HeaderText="First Name" SortExpression="First Name">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Last Name" HeaderText="Last Name" SortExpression="Last Name">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Payment Date" DataFormatString="{0:d}" HeaderText="Payment Date" SortExpression="Payment Date">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Amount" DataFormatString="{0:c}" HeaderText="Amount" SortExpression="Amount" />
            </Columns>
            <HeaderStyle BackColor="#000099" ForeColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarateConnectionString %>" SelectCommand="SELECT Members.First_Name AS [First Name], Members.Last_Name AS [Last Name], Payments.Payment_Date AS [Payment Date], Payments.Amount FROM Members INNER JOIN Payments ON Members.ID = Payments.Member_Id ORDER BY [Last Name]"></asp:SqlDataSource>
    </form>
</body>
</html>
