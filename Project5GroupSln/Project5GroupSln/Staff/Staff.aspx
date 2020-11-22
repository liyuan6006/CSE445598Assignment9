<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5GroupSln.Staff.Staff" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="../UserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Page</title>
        <style>
        form {
            margin-left: 20%;
            margin-right: 20%;
            width: 60%;
        }
            .auto-style1 {
                width: 172px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <uc:greeting runat="server" />
             <h3>Staff Page!</h3>

            <div>
                Use the below form to add a new Staff Member!<br />
                <br />
                <table border="1">
                    <tr>
                        <td> New Staff Username</td>
                        <td>New Staff Password</td>
                        <td class="auto-style1"> Create! </td>
                    </tr>
                    <td>
                        <asp:TextBox ID="staff_username" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="staff_password" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btn_staffCreate" runat="server" OnClick="btn_staffCreate_Click" Text="Create Staff User" />
                    </td>
                </table>
                <asp:Label ID="creation_result" runat="server" ForeColor="#CC3300"></asp:Label>
                <br />
            </div>

        <div>
            This is the Staff Page!
            Staff page is how you select which of your existing website pages are for Staff only.        
            <br />
            <asp:Button ID="staff_return" runat="server" OnClick="staff_return_Click" Text="Go Back to Default Page" />
        </div>
        </div>
    </form>
</body>
</html>
