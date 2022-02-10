<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication_FormLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name :"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
               <asp:Label ID="lblLastName" runat="server" Text="Last Name :"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
               <asp:Label ID="lblCity" runat="server" Text="City :"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblID" runat="server" Text="Enter Id for Data Updation:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
