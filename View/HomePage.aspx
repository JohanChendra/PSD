<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TokoBeDia.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TokoBeDia</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Welcome to TokoBeDia
        <asp:Label ID="LabelGreet" runat="server" Text=" "></asp:Label></p>
        <asp:Button ID="VUserButton" runat="server" Text="View User" OnClick="VUserButton_Click" />
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        <asp:Button ID="VProfileButton" runat="server" Text="View Profile" OnClick="VProfileButton_Click" />
        <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />        
    </div>
    <div> 
        <asp:Button ID="VProductButton" runat="server" Text="View Product" OnClick="VProductButton_Click" />               
        <asp:Button ID="IProductButton" runat="server" Text="Insert Product" OnClick="IProductButton_Click" />
        <asp:Button ID="UProductButton" runat="server" Text="Update Product" OnClick="UProductButton_Click" />    
    </div>
    <div>
        <asp:Button ID="VProductTypeButton" runat="server" Text="View Product Type" OnClick="VProductTypeButton_Click" />
        <asp:Button ID="IProductTypeButton" runat="server" Text="Insert Product Type" OnClick="IProductTypeButton_Click" />
        <asp:Button ID="UProductTypeButton" runat="server" Text="Update Product Type" OnClick="UProductTypeButton_Click" />
    </div><br /><br /><br />
    <div>
        <asp:Label ID="LabelRecommend" runat="server" Text="Products Recommended for you"></asp:Label><br />
        <asp:GridView ID="HomeGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
