<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.View.ViewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View User Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="HomeButton" runat="server" Text="Back To Home" OnClick="HomeButton_Click" />
    </div>
    <div>
       <p>View User</p>
    </div>
    <div>
        <asp:GridView ID="UserGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="UserDataSource">
            <Columns>
                <asp:TemplateField HeaderText="Manage Role">
                    <ItemTemplate>
                        <asp:Button ID="RoleButton" runat="server" Text="Change Role" OnClick="RoleButton_Click" CommandArgument='<%#Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Manage Status">
                    <ItemTemplate>
                        <asp:Button ID="StatusButton" runat="server" Text="Change Status" OnClick="StatusButton_Click" CommandArgument='<%#Eval("ID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="RoleID" HeaderText="RoleID" SortExpression="RoleID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="UserDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="TokoBeDia.App_Code.UserDataSetTableAdapters.UsersTableAdapter"></asp:ObjectDataSource>
    </div>
    <div>
        <p>
            *RoleID 1 = Member<br />
             RoleID 2 = Admin
        </p>
    </div>
    <div>
        <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text=" "></asp:Label>
    </div>
    <div>
        <asp:Label ID="LabelNewRole" runat="server" Text="New Role (1/2) :"></asp:Label>
        <asp:TextBox ID="NewRoletxt" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Label ID="LabelID" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>

