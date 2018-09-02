<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master" AutoEventWireup="true" CodeFile="Setting.aspx.cs" Inherits="Provider_Setting" %>

<asp:Content ID="SettingRightContent" ContentPlaceHolderID="ProfileMasterPageRightContent" Runat="Server">
  <asp:HyperLink ID="LnkChangePassword" runat="server" NavigateUrl="~/Provider/Setting/ChangePassword.aspx">Change Password</asp:HyperLink>
</asp:Content>

