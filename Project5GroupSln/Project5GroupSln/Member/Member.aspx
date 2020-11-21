<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5GroupSln.Member.Member" %>

<%@ Register TagPrefix="uc" TagName="greeting" Src="../UserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Page</title>
    <style>
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
        <h3>Member Page</h3>

        <div>
            This is member page.
            Member page is how you select which of your existing website pages are for members only.        
        </div>
        <asp:Button ID="btnBackToDefault" runat="server" Text="Go back to Default page" OnClick="btnBackToDefault_Click" />

    </form>
</body>
</html>
