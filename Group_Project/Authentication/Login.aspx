<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Group_Project.Authentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.cdnfonts.com/css/yatra-one" rel="stylesheet" runat="server" />
    <link rel="icon" type="image/x-icon" href="images/newlogo.png" runat="server"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" runat="server" />
    <title>Rich and care beauty hub</title>
    <link rel="stylesheet" href="css/login.css" runat="server"/>
</head>
<body>
    
    
    <form id="formLogin" runat="server">
        <div class="container1">
    <label for="uname"><b>Username</b></label>


                    <asp:TextBox runat="server" TextMode="Email" ID="txtUsername" CssClass="input"></asp:TextBox>          
            

            
                    <label for="uname"><b>Password</b></label>
                
                    <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" CssClass="input"></asp:TextBox>
                
            

            
                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" CssClass="button" />
            
              
                    <asp:Label runat="server" ID="lblMessage" ></asp:Label>
                <div class="container1 signin">
    <p>Don't have an account? <a href="Register.aspx">Register</a>.</p>
  </div>
        
    </form>
</body>
</html>
