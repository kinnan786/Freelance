<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ForgotPassword.aspx.cs" Inherits="Authentication_ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MasterHeadContent" runat="Server">
    <link href="../Styles/Site.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" runat="Server">
    <div class="MiddleCenterAlign">
        <table class="TableStyle" width="400px">
            <tr>
                <th>
                    &nbsp;</th>
                <th>
                </th>
                <th>
                </th>
                <th>
                </th>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
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
                    Email *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldTxtEmail" runat="server" Text="*" ControlToValidate="TxtEmail"
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td align="center">
                    OR
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    UserName *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtUserName" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldUserName" runat="server" Text="*" ControlToValidate="TxtUserName"
                        ValidationGroup="A"></asp:RequiredFieldValidator>
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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Label ID="LblRequiredField" runat="server" Visible="False" Font-Bold="True"
                        ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="BtnResetPassword" runat="server" Text="Reset Password" ValidationGroup="A" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
