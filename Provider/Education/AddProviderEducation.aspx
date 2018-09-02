<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master" AutoEventWireup="true" CodeFile="AddProviderEducation.aspx.cs" Inherits="Provider_Education_AddProviderEducation" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ProfileMasterPageRightContent" Runat="Server">
    <table class="TableStyle" style="width: 500px;">
    <tr>
         <td style=" width:70px;">
            &nbsp;</td>
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
            Institution Name</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TxtInstitutionName" runat="server" Width="200px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorInsitutionName" 
                runat="server" ErrorMessage="*" ControlToValidate="TxtInstitutionName">*</asp:RequiredFieldValidator>
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
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            Degree Title</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TxtDegreeTitle" runat="server" Width="200px"></asp:TextBox>
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
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            Year Completed</td>
        <td>
            &nbsp;</td>
        <td>
        <asp:DropDownList ID="DropDownYears" runat="server" Width="75px">
                <asp:ListItem Selected="True" Text="Select" Value=0></asp:ListItem>
            </asp:DropDownList>
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
            <asp:Button ID="BtnSave" runat="server" Text="Save" Width="85px" 
                onclick="BtnSave_Click" />
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
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

