<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AuthenticationSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Welcome - 
        <asp:Label ID="LoginLabel" Text="Guest" runat="server" />
        <asp:HyperLink ID="LoginLink" NavigateUrl="Login.aspx" runat="server" >Log In</asp:HyperLink>
        <asp:HyperLink ID="LogoutLink" NavigateUrl="Logout.aspx" Visible="false" runat="server" >Log Out</asp:HyperLink>
        <br />
        <br />
        <br />
        <a href="Closed.aspx">Hidden Page</a>
    </div>
    </form>
</body>
</html>
