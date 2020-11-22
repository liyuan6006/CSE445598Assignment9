<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="Project5GroupSln.UserControl" %>
<asp:Panel ID="Panel1" runat="server" Height="115px" BackImageUrl="~/logo.png" Style="background-repeat: no-repeat">
    <asp:Label ID="staff_status" runat="server" Style="float: right; padding-left: 10px"></asp:Label>
    <asp:Label ID="greeting" runat="server" Style="float: right"></asp:Label>
    <br />
    <asp:Label ID="date" runat="server" Style="float: right"></asp:Label>
    <br />
    <asp:Label ID="usersOnlineLabel" runat="server" Style="float: right"></asp:Label>
    <br />
    <asp:Button ID="quoteBtn" runat="server" OnClick="quoteBtn_Click" Text="New Inspirational Quote" Style="height: 26px; float: right" />
    <br />
    <br />
    <asp:Label ID="inspirational_quote" runat="server"></asp:Label>
</asp:Panel>

