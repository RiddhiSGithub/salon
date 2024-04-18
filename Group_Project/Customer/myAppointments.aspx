<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myAppointments.aspx.cs" Inherits="Group_Project.Customer.myAppointments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.cdnfonts.com/css/yatra-one" rel="stylesheet" runat="server" />
    <link rel="icon" type="image/x-icon" href="images/newlogo.png" runat="server" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" runat="server" />
    <title>Rich and care beauty hub</title>
    <link rel="stylesheet" href="css/booking.css" runat="server" />
</head>
<body>
    <form id="formBookAppointment" runat="server">

        <!--navigation bar-->
        <div class="container">
            <div class="logo">
                <img src="images/newlogo.png" alt="" width="130" />
            </div>
            <nav class="nav">
                <ul>
                    <li><a href="index.aspx">Home</a></li>
                    <li><a href="showServices.aspx">Services</a></li>
                    <li><a href="bookAppointment.aspx">Booking</a></li>
                    <li>
                        <a>
                            <asp:LinkButton Text="" OnClick="btn_Click" ID="btn" runat="server"></asp:LinkButton></a>
                    </li>
                    <li>
                        <a>
                            <asp:LinkButton Text="" OnClick="btnLogOut_Click" ID="btnLogOut" runat="server"></asp:LinkButton></a>
                    </li>
                    
                </ul>
            </nav>
        </div>

        <asp:GridView runat="server" ID="grdDisplayAppointments" AutoGenerateColumns="false" DataKeyNames="cust_id" CssClass="customers" RowStyle-CssClass="tr">
            <Columns>
                <asp:BoundField DataField="start_time" ControlStyle-CssClass="th" HeaderText="Start Time" />
                <asp:BoundField DataField="end_time" ControlStyle-CssClass="th" HeaderText="End Time" />
                <asp:BoundField DataField="app_date" ControlStyle-CssClass="th" HeaderText="Appointment Date" />
                <asp:BoundField DataField="total_cost" ControlStyle-CssClass="th" HeaderText="Total Cost" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
