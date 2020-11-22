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
        .bold{
            font-weight: bolder;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc:greeting runat="server" />
        <h3>Member Page - SEO Services</h3>

        <div>
            By being a member you get access to the following SEO Services:<br />
            <br />
            <span class="bold">Word Filter:</span> Removes stop words from a string that are not meaningful when counted as the top words in a search.<br />
            <br />
            Enter the string to be processed:<br />
            <asp:TextBox ID="WordFilterTextBox" runat="server" style="width:100%"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="WordFillterButton" runat="server" Text="Word Filter" OnClick="WordFillterButton_Click" />
            <br />
            <br />
            Results:
            <asp:Label ID="WordFilterResultsLabel" runat="server"></asp:Label>
            <br />
            <br />
            <span class="bold">Word Stemming:</span> Replaces words in a string with their Stem word.<br />
            <br />
            Enter the string to be processed:<br />
            <asp:TextBox ID="StemmingTextBox" runat="server" style="width:100%"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="StemmingButton" runat="server" Text="Word Stemming" OnClick="StemmingButton_Click" />
            <br />
            <br />
            Results: <asp:Label ID="StemmingResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <span class="bold">Top Ten Content Words:</span> Returns the top ten content words found at the site requested.<br />
            <br />
            Enter the url to be processed:<br />
            <asp:TextBox ID="TopTenTextBox" runat="server" style="width:100%">http://</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="TopTenButton" runat="server" OnClick="TopTenButton_Click" Text="Top Ten Content Words" />
            <br />
            <br />
            Results:
            <asp:Label ID="TopTenResultsLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="btnBackToDefault" runat="server" Text="Go back to Default page" OnClick="btnBackToDefault_Click" />

    </form>
</body>
</html>
