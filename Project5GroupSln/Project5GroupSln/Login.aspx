<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project5GroupSln.Login" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="UserControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
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
            margin-left: 20%;
            margin-right: 20%;
            width: 60%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc:greeting runat="server" />
        <h3 style="text-align: center">Login Page</h3>

        <div>*You need to enter the correct username and password to login </div>
        <div>*This application uses forms authentication, if user is not authenticated, this login page will apear, otherwise it will be hidden.</div>
        <div>
            *If you login as Member, the login page will check the username and password in Member.xml file.The predefined username and password is: (name1,  123)
        </div>
        <div>
            *If you login as Staff, the login page will check the username and password in Staff.xml file.The predefined username and password is: (TA,  Cse445ta!)
        </div>

        <table id="customers">
            <tr>
                <td>User Name:</td>
                <td>
                    <asp:TextBox ID="txtUserName" placeholder="Enter user name" runat="server" Text=""></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td>
                    <label>Password:</label></td>
                <td>
                    <asp:TextBox ID="txtPassword" type="password" placeholder="Enter password" runat="server"></asp:TextBox>

                </td>


            </tr>
            <tr>
                <td>Persistent Cookie:</td>
                <td>
                    <asp:CheckBox ID="chekRememberMe" class="form-check-input" runat="server" AutoPostBack="false" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MemberRegister.aspx">Register a new Member?</asp:HyperLink></td>

            </tr>
        </table>

        <div style="color: red">
            <asp:Label ID="lblLoginError" Style="color: red" runat="server" Text=""></asp:Label>
        </div>

        <asp:Button ID="btnLoginAsMember" runat="server" class="btn btn-primary" Text="Login As Member" OnClick="btnLoginAsMember_Click" />

        <asp:Button ID="btnLoginAsStaff" runat="server" OnClick="btnLoginAsStaff_Click" Text="Login As Staff" />

        <asp:Button ID="btnGoBack" runat="server" Text="Go back to Default page" OnClick="btnGoBack_Click" />
    </form>
</body>
</html>
