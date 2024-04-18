<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Group_Project.Customer.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="https://fonts.cdnfonts.com/css/yatra-one" rel="stylesheet" runat="server" />
    <link rel="icon" type="image/x-icon" href="images/newlogo.png" runat="server" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" runat="server" />
    <link rel="stylesheet" href="css/css.css" runat="server" />
    <title>Rich & Care | Home</title>
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
                    <asp:LinkButton Text=""  onclick="Unnamed_Click" id="btnLogOut" runat="server"></asp:LinkButton></a>
                    </li>
            </ul>
                </form>
        </nav>
    </div>
    
    
    <div class="slideshow-container">

        <div class="mySlides fade">
            <img src="images/slider2.jpg" class="img">
        </div>

        <div class="mySlides fade">
            <img src="images/slider3.jpg" class="img">
        </div>

        <div class="mySlides fade">
            <img src="images/slider4.jpg" class="img">
        </div>

    </div>
    
    <br>

    <div style="text-align:center">
        <span class="dot"></span> 
        <span class="dot"></span> 
        <span class="dot"></span> 
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
    
    
    
 <script>
let slideIndex = 0;
showSlides();

function showSlides() {
  let i;
  let slides = document.getElementsByClassName("mySlides");
  let dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";  
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}    
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
  setTimeout(showSlides, 2000); // Change image every 2 seconds
}
 </script>
</body>
</html>
