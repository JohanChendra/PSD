<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePasswordPage.aspx.cs" Inherits="TokoBeDia.View.ChangePasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Change Password
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Old Password"></asp:Label>
        <asp:TextBox ID="OPtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="NPtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="CPtxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text=" "></asp:Label>
    </div>
    <div>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
    </div>
    </form>
</body>
</html>
