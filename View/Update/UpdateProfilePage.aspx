<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="TokoBeDia.View.UpdateProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Profile Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Update Profile
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email :"></asp:Label>
        <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name :"></asp:Label>
        <asp:TextBox ID="Nametxt" runat="server" ></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Gender :"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonListGender" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:RadioButtonList>          
    </div>
    <div>
        <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
    </div>

    </form>
</body>
</html>
