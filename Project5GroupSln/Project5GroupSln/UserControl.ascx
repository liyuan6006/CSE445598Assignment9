<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="Project5GroupSln.UserControl" %>
<asp:Panel ID="Panel1" runat="server" Height="110px">
    <asp:Label ID="greeting" runat="server"></asp:Label>
    <asp:Label ID="staff_status" runat="server"></asp:Label>
    <br />
    <asp:Label ID="date" runat="server"></asp:Label>
    <asp:Label ID="usersOnlineLabel" runat="server" style="padding-left: 10px"></asp:Label>
    <br />
    <asp:Button ID="quoteBtn" runat="server" OnClick="quoteBtn_Click" Text="Get Inspirational Quote" style="height: 26px" />
    <br />
    <asp:Label ID="inspirational_quote" runat="server"></asp:Label>
</asp:Panel>

