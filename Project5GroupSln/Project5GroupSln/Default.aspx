<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5GroupSln.Default" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="UserControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #customers {
            font-family: Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

            #customers td {
                border: 1px solid #ddd;
                padding: 8px;
            }

            #customers tr:nth-child(even) {
                background-color: #f2f2f2;
            }

            #customers tr:hover {
                background-color: #ddd;
            }

        form {
            margin-left: 25%;
            margin-right: 25%;
            width: 50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc:greeting runat="server" />

        <h3 style="text-align: center">Default Page</h3>
        <div>*This system uses forms-based authentication. Default and Register pages are public pages, everyone can access it.</div>
        <div>*Member page is protected page, you need to login to access it. You can click Member Register Page button to register a new user or you can use predefined username <b>name1</b> and password <b>123</b> to access it.</div>
        <table id="customers">
            <tr>
                <td>You need to register and login to access member page</td>
                <td>
                    <asp:Button ID="btnMember" runat="server" Text="Go to Member Page" OnClick="btnMember_Click" /></td>
                <td>
                    <asp:Button ID="btnMemberRegister" runat="server" Text="Member Register Page" OnClick="btnMemberRegister_Click" />
                </td>

            </tr>
            <tr>
                <td> You need to log in to access the staff pages.</td>
                <td>
                    <asp:Button ID="btnStaff" runat="server" Text="Staff Page" OnClick="btnStaff_Click" />
                </td><td></td>
            </tr>

            <tr>
                <td>The logout button will clear authentication tiket. You will have to login again.</td>
                <td>
                    <asp:Button ID="btnClear" runat="server" Text="Logout" OnClick="btnClear_Click" /></td>
                <td></td>

            </tr>

        </table>
    </form>
</body>
</html>
