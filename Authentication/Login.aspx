<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs"
    Inherits="Authentication_Login" %>
<%@ MasterType VirtualPath="~/Site.master" %>

<asp:Content ID="LoginHeadContent" ContentPlaceHolderID="MasterHeadContent" runat="Server">
    <script src="../Scripts/FreelanceJavascript.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="LoginMainContent" ContentPlaceHolderID="MasterMainContent" runat="Server">
    <div class="MiddleCenterAlign">
      <table class="TableStyle" width="400px">
                        <tr>
                            <th>
                                &nbsp;</th>
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
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                Email *&nbsp;
                            </td>
                            <td>
                                <asp:TextBox ID="TxtEmail" runat="server" Width="200px" MaxLength="50" ValidationGroup="A"
                                    CausesValidation="True" class ="textboxOutFocus"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldUserName" runat="server" Text="*" ValidationGroup="A"
                                    ControlToValidate="TxtEmail"></asp:RequiredFieldValidator>
                            </td>
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
                                Password *&nbsp;
                            </td>
                            <td>
                                <asp:TextBox ID="TxtPassword" runat="server" Width="200px" MaxLength="50" TextMode="Password"
                                    ValidationGroup="A" CausesValidation="True"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" Text="*" ValidationGroup="A"
                                    ControlToValidate="TxtPassword"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <a href="/Provider/RegisterProvider.aspx">Register</a> &nbsp; 
                                <a href="ForgotPassword.aspx">Forgot Password</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
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
                            <td>
                                <asp:Label ID="LblAutentication" runat="server" Visible="False" Font-Bold="True"
                                    ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                            </td>
                            <td>
                                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" ValidationGroup="A" />
                            </td>
                        </tr>
                    </table>
    </div>
</asp:Content>
