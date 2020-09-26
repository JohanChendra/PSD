<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductTypePage.aspx.cs" Inherits="TokoBeDia.View.ViewProductTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Product Type Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="HomeButton" runat="server" Text="Back To Home" OnClick="HomeButton_Click" />
    </div>
    <div>
        <p>
            Product Types
        </p>
    </div>
    <asp:GridView ID="ProductTypeGridView" runat="server" OnRowDeleting="ProductTypeGridView_RowDeleting" OnRowUpdating="ProductTypeGridView_RowUpdating">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
        </Columns>
        </asp:GridView>
    <div>
        <asp:Button ID="InsertProductTypeButton" runat="server" Text="Insert Product Type" OnClick="InsertProductTypeButton_Click" />
    </div>
    </form>
</body>
</html>
