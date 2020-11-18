<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="luke_testing.aspx.cs" Inherits="Project5GroupSln.luke_testing" %>
<%@ Register TagPrefix="uc" TagName="greeting" src="UserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LUKE TESTING PAGE</h1>
            <uc:greeting runat="server" />
        </div>
    </form>
</body>
</html>
