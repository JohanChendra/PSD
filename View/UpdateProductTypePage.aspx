<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductTypePage.aspx.cs" Inherits="TokoBeDia.View.UpdateProductTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Product Type Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Update Product Type
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product Type :"></asp:Label>
        <asp:TextBox ID="ProductTypetxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Description :"></asp:Label>
        <asp:TextBox ID="desctxt" runat="server"></asp:TextBox>
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
