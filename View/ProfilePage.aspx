<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="TokoBeDia.View.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="HomeButton" runat="server" Text="Back To Home" OnClick="HomeButton_Click" />
    </div>
    <div>
        <p>
            Profile
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email :"></asp:Label>
        <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
        <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Gender :"></asp:Label>
        <asp:Label ID="LabelGender" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="UProfileButton" runat="server" Text="Update Profile" OnClick="UProfileButton_Click" />
        <asp:Button ID="ChangePasswordButton" runat="server" Text="Change Password" OnClick="ChangePasswordButton_Click" />
    </div>
    </form>
</body>
</html>
