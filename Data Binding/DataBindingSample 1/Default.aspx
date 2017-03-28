<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataBindingSample_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93%;
        }
        .auto-style3 {
            width: 172px;
        }
        .auto-style4 {
            width: 110px;
        }
        .auto-style5 {
            width: 116px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Read_All" runat="server" Text="Read All" OnClick="Read_All_Click" />
                </td>
                <td class="auto-style3">Result</td>
                <td colspan="2">
                    <asp:Label ID="ShowContact" runat="server" Text="Show Contact" EnableViewState="False" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">First Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="FirstNameTexbox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Last Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Phone</td>
                <td class="auto-style3">
                    <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Add_Contact" runat="server" Text="Add Contact" OnClick="Add_Contact_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="AddingMessage" runat="server" Text="Adding message" EnableViewState="False" Visible="False"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;Delete by Id</td>
                <td class="auto-style3">
                    <asp:TextBox ID="RemoveIDTextBox" runat="server" Width="36px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="DeleteContact" runat="server" Text="Delete Contact" OnClick="DeleteContact_Click" />
                </td>
                <td>
                    <asp:Label ID="DeletingMessage" runat="server" Text="DeletingMessage" EnableViewState="False" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
