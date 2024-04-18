<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showAppointments.aspx.cs" Inherits="Group_Project.Admin.showAppointments" %>

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
    <form id="form1" runat="server">

        <!--navigation bar-->
        <div class="container">
            <div class="logo">
                <img src="images/newlogo.png" alt="" width="130" />
            </div>
            <nav class="nav">
                <ul>    
                    
                    <li>
                        <a href="https://localhost:44399/Admin/showAppointments.aspx">
                            Show Appointments
                        </a>
                    </li>

                    <li>
                        <a href="https://localhost:44399/Customer/addService.aspx">
                            Add service
                        </a>
                    </li>

                    <li>
                        <a>
                            <asp:LinkButton Text="Log Out" OnClick="btnLogOut_Click" ID="btnLogOut" runat="server"></asp:LinkButton></a>
                    </li>
                    
                </ul>
            </nav>
        </div>

        <div>
             <asp:GridView runat="server" ID="grdDisplayAppointments" AutoGenerateColumns="false" DataKeyNames="cust_id" CssClass="customers" RowStyle-CssClass="tr" SortedAscendingCellStyle-CssClass="td" SortedDescendingCellStyle-CssClass="td">
                        <Columns>                            
                            <asp:BoundField DataField="cust_name" HeaderText="Customer Name" ControlStyle-CssClass="th" />
                            <asp:BoundField DataField="cust_email" HeaderText="Customer Email" ControlStyle-CssClass="th" />
                            <asp:BoundField DataField="cust_contact" HeaderText="Customer Contact" ControlStyle-CssClass="th" />
                            <asp:BoundField DataField="start_time" HeaderText="Start Time" />
                            <asp:BoundField DataField="end_time" HeaderText="End Time" />
                            <asp:BoundField DataField="app_date" HeaderText="Appointment Date" />
                            <asp:BoundField DataField="total_cost" HeaderText="Total Cost" />
                        </Columns>
                    </asp:GridView>
        </div>
    </form>
</body>
</html>
