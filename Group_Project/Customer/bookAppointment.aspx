<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookAppointment.aspx.cs" Inherits="Group_Project.Customer.bookAppointment" %>

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
            <img src="images/newlogo.png" alt="" width="130"/>
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
                   <asp:LinkButton Text=""  onclick="btnLogOut_Click" id="btnLogOut" runat="server"></asp:LinkButton></a>
                    </li>
            </ul>
        </nav>
    </div>
    
    
<!-- booking  -->
    <div class="form">
         <asp:Label ID="lblMessage" runat="server"></asp:Label>


                    Select Your Services

                    <asp:GridView runat="server" ID="grdDisplayServices" AutoGenerateColumns="false" DataKeyNames="service_id"  RowStyle-CssClass="td" CssClass="customers">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox CssClass="checkbox" ID="mycheckbox" runat="server"  />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="service_name" ControlStyle-CssClass="th" HeaderText="Service Name" />
                            <asp:BoundField DataField="service_price" ControlStyle-CssClass="th" HeaderText="Service Cost" />
                            <asp:BoundField DataField="service_time_span" ControlStyle-CssClass="th" HeaderText="Service Time Span" />
                        </Columns>
                    </asp:GridView>
                
            
                    Select Date
            
                    <asp:TextBox runat="server" TextMode="Date" CssClass="td" ID="txtDate" required="true"  ></asp:TextBox>
            

                    <asp:Button runat="server" ID="btnBookAppointment" text="Book Appointment" OnClick="btnBookAppointment_Click" CssClass="button"/>

                   


    </form>
</body>
</html>
