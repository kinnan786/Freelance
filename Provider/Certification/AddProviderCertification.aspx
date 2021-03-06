﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master" AutoEventWireup="true" CodeFile="AddProviderCertification.aspx.cs" Inherits="Provider_Certification_AddProviderCertification" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ProfileMasterPageRightContent" Runat="Server">
    <table class="TableStyle" style="width: 530px;">
    <tr>
        <td style=" width:20px;">
                &nbsp;
            </td>
            <td style="height: 19px">
                &nbsp;
            </td>
            <td style=" width:10px;">
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td style="height: 19px">
                &nbsp;
            </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            Certification Name*</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TxtCertificationName" runat="server" Width="350px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldCertificationName" runat="server" 
                ControlToValidate="TxtCertificationName" ErrorMessage="*">*</asp:RequiredFieldValidator>
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
            Percentage</td>
        <td>
            &nbsp;</td>
        <td>
            
            <asp:TextBox ID="TxtPercentage" runat="server" Width="75px" MaxLength="3"></asp:TextBox>
            %
            <asp:FilteredTextBoxExtender ID="FtextTxtPercentage" runat="server" 
                FilterType="Numbers" TargetControlID="TxtPercentage"  >
            </asp:FilteredTextBoxExtender>
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

