<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="Project5GroupSln.UserControl" %>
<asp:Panel ID="Panel1" runat="server" Height="100px">
    <asp:Label ID="greeting" runat="server" Text="greeting"></asp:Label>
    <br />
    <asp:Label ID="date" runat="server" Text="date"></asp:Label>
    <br />
    <asp:Label ID="session_count" runat="server" Text="session_info"></asp:Label>
    <br />
    <asp:Button ID="session_1" runat="server" OnClick="session_1_Click" Text="session_add" />
</asp:Panel>

