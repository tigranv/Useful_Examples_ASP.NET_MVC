<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AuthenticationSample.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Login <asp:TextBox ID="LoginTextBox" runat="server" />
        <br />
        Password <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" />
        <br />
        <asp:Button ID="LoginButton" Text="Sign In" runat="server" OnClick="LoginButton_Click" />
        <br />
        <asp:Label ID="ErrorLabel" runat="server" Text="Login or password is incorrect!" ForeColor="Red" Visible="false"></asp:Label>

    </div>
    </form>
</body>
</html>
