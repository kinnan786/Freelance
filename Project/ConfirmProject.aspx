<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmProject.aspx.cs" Inherits="Project_ConfirmProject" %>
<%@ MasterType VirtualPath="~/Site.master"%>
<asp:Content ID="ConfirmProjectHeadContent" ContentPlaceHolderID="MasterHeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="ConfirmProjectMainContent" ContentPlaceHolderID="MasterMainContent" Runat="Server">
    <table class="gray_container">
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
        <td style=" width:100px;">
           <b> Project Name</b></td>
        <td>
            
            <asp:Label ID="LblProjectName" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
<b>            Category</b></td>
        <td>
            
            <asp:Label ID="LblCategory" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
   
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <b>Sub Category</b></td>
        <td>
           <asp:Label ID="LblSubCategory" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
     <tr>
        <td valign="top">
            &nbsp;</td>
        <td valign="top">
            <b>Skill</b></td>
        <td>
            <asp:Label ID="LblSkill" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <b>Budget</b></td>
        <td>
        <asp:Label ID="LblBudget" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <b>Bid Open Till</b></td>
        <td>
       <asp:Label ID="LblBidOpenTill" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
  
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <b>Attachments</b></td>
        <td>
       <asp:Label ID="LblAttachments" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td valign="top">
            &nbsp;</td>
        <td valign="top">
            <b>location</b></td>
        <td>
        <asp:Label ID="Lbllocation" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style=" vertical-align:top;">
            &nbsp;</td>
        <td style=" vertical-align:top;">
            <b>Description</b></td>
        <td>
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
            <asp:Label ID="LblDescription" runat="server"></asp:Label></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style=" text-align:center;">
            &nbsp;</td>
        <td colspan="3" style=" text-align:center;">
            <asp:Button ID="Btnback" runat="server" Text="Back" Width="150px" 
                onclick="Btnback_Click" />
            <asp:Button ID="BtnConfirmAndPost" runat="server" Text="Confirm And Post" Width="150px" 
                onclick="BtnConfirmAndPost_Click"/>
        </td>
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
    </tr>
</table>
</asp:Content>

