<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showServices.aspx.cs" Inherits="Group_Project.Customer.showServices" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://fonts.cdnfonts.com/css/yatra-one" rel="stylesheet">
    <link rel="icon" type="image/x-icon" href="images/newlogo.png">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Rich and care beauty hub</title>
    <link rel="stylesheet" href="css/Services.css">
    
</head>
<body>
    <!--navigation bar-->
    <div class="container">
        <div class="logo">
            <img src="images/newlogo.png" alt="" width="130"/>
        </div>
        <nav class="nav">
            <form runat="server">
            <ul>
                <li><a href="index.aspx">Home</a></li>
                <li><a href="showServices.aspx">Services</a></li>
                <li><a href="bookAppointment.aspx">Booking</a></li>
                 <li>
                        <a>
                            <asp:LinkButton Text="" OnClick="btn_Click" ID="btn" runat="server"></asp:LinkButton></a>
                    </li>
                <li><a>
                    <asp:LinkButton Text=""  onclick="btnLogOut_Click" id="btnLogOut" runat="server"></asp:LinkButton></a></li>
            </ul>
                </form>
        </nav>
    </div>
    
    
<!--   gallary -->
<div class="row">
  <div class="column">
    <img src="images/facecare.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Face care</div>
  </div>
  </div>
  <div class="column">
    <img src="images/makeup.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Makeup</div>
  </div>
  </div>
  <div class="column">
    <img src="images/haircut.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Hair cut</div>
  </div>
  </div>
</div>
<div class="row">
  <div class="column">
    <img src="images/hair.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Hair Straightnig</div>
  </div>
  </div>
  <div class="column">
    <img src="images/spa.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Spa</div>
  </div>
  </div>
  <div class="column">
    <img src="images/nail.jpg" style="width:100%"  class="hover-shadow cursor">
      <div class="overlay">
    <div class="text">Nail Art</div>
  </div>
  </div>
</div>
    
    <!-- Site footer -->
    <footer class="footer-distributed">

		<div class="footer-right">

            <a href="#"><i class="fa fa-facebook"></i></a>
            <a href="#"><i class="fa fa-twitter"></i></a>
            <a href="#"><i class="fa fa-linkedin"></i></a>
            <a href="#"><i class="fa fa-instagram"></i></a>

        </div>

        <div class="footer-left">

            <p class="footer-links">
                <a class="link-1" href="homepage.html">Home</a>

                <a href="services.html">Services</a>

                <a href="Booking.html">Booking</a>

                <a href="Login.html">login/Registration</a>

            </p>

            <p>Rich and care beauty hub &copy; 2023</p>
        </div>

    </footer>

</body>

</html>
