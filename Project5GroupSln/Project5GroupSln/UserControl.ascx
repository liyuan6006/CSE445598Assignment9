<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="Project5GroupSln.UserControl" %>
<asp:Panel ID="Panel1" runat="server" Height="115px" BackImageUrl="~/logo.png" style="background-repeat:no-repeat" >
    <asp:Label ID="greeting" runat="server" style="float: right"></asp:Label>
    <asp:Label ID="staff_status" runat="server" style="float: right"></asp:Label>
    <br />
    <asp:Label ID="date" runat="server" style="float: right"></asp:Label>
    <br />
    <asp:Label ID="usersOnlineLabel" runat="server" style="float: right"></asp:Label>
    <br />
    <asp:Button ID="quoteBtn" runat="server" OnClick="quoteBtn_Click" Text="New Inspirational Quote" style="height: 26px;float: right" />
    <br />
    <br />
    <asp:Label ID="inspirational_quote" runat="server"></asp:Label>
</asp:Panel>

