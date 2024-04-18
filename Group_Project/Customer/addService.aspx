<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addService.aspx.cs" Inherits="Group_Project.Customer.addService" %>

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
    <form id="formAddService" runat="server">

         <!--navigation bar-->
        <div class="container">
            <div class="logo">
                <img src="images/newlogo.png" alt="" width="130" />
            </div>
            <nav class="nav">
                <ul>    
                    
                    <li>
                        <a href="https://localhost:44399/Admin/showAppointments.aspxx">
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

        <table>
            <tr>
                <td>
                    Service Name
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    Service Time Span
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTimeSpan" ></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    Service Cost
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtCost" TextMode="Number"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button runat="server" id="btnAddService" Text="Add Service"  OnClick="btnAddService_Click"  />
                </td>
            </tr>

            <tr>
                <td span="2">
                    <asp:Label runat="server" ID="lblMessage"></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
