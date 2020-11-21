<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5GroupSln.Staff.Staff" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="../UserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <uc:greeting runat="server" />
             <h3>Staff Page!</h3>

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
