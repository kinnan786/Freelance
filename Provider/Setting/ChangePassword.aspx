<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Provider_Setting_ChangePassword" %>
<%@ MasterType VirtualPath="~/Provider/ProfileMasterPage.master" %>

<asp:Content ID="ChangePassswordRightContent" ContentPlaceHolderID="ProfileMasterPageRightContent" Runat="Server">

    <table class="gray_container" style="width: 100%" >
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Old Password</td>
        <td>
            <asp:TextBox ID="TxtOldPassword" runat="server" Width="200px" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            New Password</td>
        <td>
            <asp:TextBox ID="TxtNewPassword" runat="server" Width="200px" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Retype Password</td>
        <td>
            <asp:TextBox ID="TxtRetypePassword" runat="server" Width="200px" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="LblPasswordChanged" runat="server" Visible="False"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="BtnChangePassword" runat="server" Text="Change Password" 
                onclick="BtnChangePassword_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>

</asp:Content>

