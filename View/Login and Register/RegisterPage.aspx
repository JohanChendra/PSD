<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="TokoBeDia.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Register
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Confirm Password :"></asp:Label>
        <asp:TextBox ID="ConfirmPasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Gender :"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonListGender" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:RadioButtonList>          
    </div>
    <div>
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
        <br />
        <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text=" "></asp:Label>
    </div>
    <div>
        <hr/>
        <asp:LinkButton ID="LoginButton" runat="server" OnClick="LoginButton_Click">Login With Existing Account</asp:LinkButton>
    </div>
    </form>
</body>
</html>
