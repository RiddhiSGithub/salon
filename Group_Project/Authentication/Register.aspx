<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Group_Project.Authentication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="https://fonts.cdnfonts.com/css/yatra-one" rel="stylesheet" runat="server" />
    <link rel="icon" type="image/x-icon" href="images/newlogo.png" runat="server" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" runat="server" />
    <title>Rich and care beauty hub</title>
    <link rel="stylesheet" href="css/registration.css" runat="server" />
</head>
<body>
    <form id="formRegister" runat="server" method="post">
        <div class="container1">
            <h1>Register</h1>
            <p>Please fill in this form to create an account.</p>
            <hr>

            <label for="email"><b>Full Name</b></label>
            <asp:TextBox ID="txtName"  runat="server" CssClass="input"></asp:TextBox>

            <label for="email"><b>City</b></label>
            <asp:TextBox ID="txtCity"  runat="server" CssClass="input"></asp:TextBox>

            <label for="email"><b>Gender</b></label>
            <asp:RadioButton GroupName="gender" Text="Male" CssClass="input" runat="server" ID="rbMale" />

            <asp:RadioButton GroupName="gender" Text="Female" CssClass="input" runat="server" ID="rbFemale" />

            <label for="email"><b>Contact Number</b></label>
            <asp:TextBox ID="txtContact" runat="server" CssClass="input"></asp:TextBox>
            <label for="email"><b>Email</b></label>


            <asp:TextBox ID="txtEmail" runat="server" CssClass="input"></asp:TextBox>
            <label for="email"><b>Password</b></label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="input"></asp:TextBox>

            <asp:Button ID="btnRegister" Text="Register" runat="server" OnClick="btnRegister_Click" CssClass="registerbtn" />

            <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>

    <div class="container1 signin">
    <p>Already have an account? <a href="login.aspx">Log in</a>.</p>
  </div>
</body>
</html>
