<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="Project5GroupSln.MemberRegister" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="UserControl.ascx" %>

<%@ Register Src="~/ImageVerifierUserControl.ascx" TagPrefix="uc1" TagName="ImageVerifierUserControl" %>
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
        <h3 style="text-align: center">Member Register Page</h3>
        <div>*After you register successfully, you will be redirect to Member page.</div>
        <div>*The register function will call CreateMember remote service at http://webstrar53.fulton.asu.edu/Page5/Service.svc?wsdl to save the member info into the Member.xml</div>
        <div>*The password will be encryped. The encryption function is developed in MD5HashLibrary.dll</div>
        <div>*The Member.xml will be saved at w:\sites\content\website53\Page5\App_Data\Member.xml </div>

        <div>*An image verifier is used to protect malicious users. The image verifier is a user control and it uses http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifierSvc/Service.svc web service.</div>
        <div>*Session[&quot;generatedString&quot;] is used to store generated string. </div>


        <table id="customers">
            <tr>
                <td>Member Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPwd" type="password" runat="server"></asp:TextBox>
                </td>

            </tr>

            <tr>
                <td>Image verifier:</td>
                <td>
                    <uc1:ImageVerifierUserControl runat="server" ID="ImageVerifierUserControl" />
                </td>

            </tr>
            <tr>
                <td>Please enter the text above into the following textbox:
                </td>
                <td>
                    <asp:TextBox ID="txtInputForImage" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button ID="btnBackToDefault" runat="server" Text="Go back to Default page" OnClick="btnBackToDefault_Click" />
        <br />
        <asp:Label ID="lblResult" Style="color: red" runat="server" Text="Result:"></asp:Label>
    </form>
</body>
</html>
