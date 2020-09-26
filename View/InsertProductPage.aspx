<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProductPage.aspx.cs" Inherits="TokoBeDia.View.InsertProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Product Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Insert Product
        </p>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Stock :"></asp:Label>
        <asp:TextBox ID="Stocktxt" runat="server" TextMode="Number" ></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Price :"></asp:Label>
        <asp:TextBox ID="Pricetxt" runat="server" TextMode="Number"></asp:TextBox>
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
