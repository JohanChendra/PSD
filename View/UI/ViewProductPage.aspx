<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductPage.aspx.cs" Inherits="TokoBeDia.View.ViewProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Product Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="HomeButton" runat="server" Text="Back To Home" OnClick="HomeButton_Click" />
    </div>
    <div>
        <p>
            Products
        </p>
    </div>
    <asp:GridView ID="ProductsGridView" runat="server" OnRowDeleting="ProductsGridView_RowDeleting" OnRowUpdating="ProductsGridView_RowUpdating">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
        </Columns>
        </asp:GridView>
    <div>
        <asp:Button ID="InsertProductButton" runat="server" Text="Insert Product" OnClick="InsertProductButton_Click" />
    </div>
    </form>
</body>
</html>
