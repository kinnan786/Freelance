<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="~/Authentication/Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content24654" ContentPlaceHolderID="MasterMainContent" Runat="Server">
     <table width="100%" style=" text-align:left; height:500px; background-image:url(../images/cock_bg.gif); background-repeat:repeat-x;" cellpadding="0" cellspacing="0">
       <tr>
        <td valign="top">
            <center>
                <table width="80%">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>First Name</td>
                        <td>
                            <asp:TextBox ID="TxtFirstName" runat="server" MaxLength="50" 
                                ValidationGroup="A" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TxtFirstName" ErrorMessage="First Name Required" 
                                ValidationGroup="A" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td>Last Name</td>
                        <td>
                            <asp:TextBox ID="TxtLastName" runat="server" MaxLength="50" ValidationGroup="A" 
                                Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TxtLastName" ErrorMessage="Last Name Required " 
                                SetFocusOnError="True" ValidationGroup="A">*</asp:RequiredFieldValidator>
                         </td>
                    </tr>
                     <tr>
                        <td>Country</td>
                        <td>
                            <asp:DropDownList ID="DdlCountry" runat="server" ValidationGroup="A" 
                                Width="200px">
                                <asp:ListItem Selected="True">Select</asp:ListItem>
                                <asp:ListItem>Pakistan</asp:ListItem>
                                <asp:ListItem>England</asp:ListItem>
                            </asp:DropDownList>
                           
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToValidate="DdlCountry" ErrorMessage="Country Not Selected" 
                                Operator="NotEqual" ValidationGroup="A" ValueToCompare="Select">*</asp:CompareValidator>
                           
                         </td>
                    </tr>
                     <tr>
                        <td>Username/Email</td>
                        <td>
                            <asp:TextBox ID="TxtUserName" runat="server" ValidationGroup="A" Width="200px" 
                                MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="TxtUserName" ErrorMessage="UserName Required" 
                                ValidationGroup="A" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="TxtUserName" ErrorMessage="Email Required" 
                                SetFocusOnError="True" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ValidationGroup="A">*</asp:RegularExpressionValidator>
                         </td>
                    </tr>
                     <tr>
                        <td>Password</td>
                        <td>
                            <asp:TextBox ID="TxtPassword" runat="server" ValidationGroup="A" Width="200px" 
                                TextMode="Password" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="TxtPassword" ErrorMessage="Password Required" 
                                ValidationGroup="A" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                         </td>
                    </tr>
                     <tr>
                        <td>Retype Password</td>
                        <td>
                            <asp:TextBox ID="TxtRetypePassword" runat="server" ValidationGroup="A" 
                                Width="200px" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="TxtRetypePassword" ErrorMessage="Re-type Password Required" 
                                ValidationGroup="A" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                ControlToCompare="TxtPassword" ControlToValidate="TxtRetypePassword" 
                                ErrorMessage="Password Donot Match" SetFocusOnError="True" 
                                ValidationGroup="A">*</asp:CompareValidator>
                         </td>
                    </tr>
                     <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                ShowMessageBox="True" ValidationGroup="A" />
                            <asp:Label ID="LblNameExist" runat="server" Text="UserName Exist" 
                                Visible="False" BorderColor="Red" ForeColor="Red" ></asp:Label>
                         </td>
                    </tr>
                     <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="BtnRegister" runat="server" Text="Register" 
                                onclick="BtnRegister_Click" Width="150px" ValidationGroup="A" />
                         </td>
                    </tr>
                </table>
            </center>
        </td>
       </tr>
   </table>

   <div class=" footer">
        <table>
        <tr>
            <td style="text-align: center;">
                ©2011 Kintechno Corporation. Use of this Web site constitutes acceptance of the
                Kintechno User Agreement and incorporated Policies. The terms "Employer" and "Provider"
                are used in the generic sense and are not meant to define the legal relationship
                between the two parties.
            </td>
            <td style="width: 100px;">
            </td>
            </tr> 
            </table>
        </div>
</asp:Content>