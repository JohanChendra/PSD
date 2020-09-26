<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TokoBeDia.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Login
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="ChkRM" runat="server" Text="Remember Me" />
    </div>
    <div>
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
    </div>
    <div>
        <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text=" "></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Don't have an accout ?"></asp:Label>
        <asp:LinkButton ID="RegisterButton" runat="server" OnClick="RegisterButton_Click">Register Now!</asp:LinkButton>
    </div>
    </form>
</body>
</html>
