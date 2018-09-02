<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmBid.aspx.cs" Inherits="Bid_ConfirmBid" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MasterHeadContent" Runat="Server">
<style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" Runat="Server">
<table class="TableStyle" width="100%">
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
                Job Title</td>
            <td>
                <asp:Label ID="LblJobTitle" runat="server"></asp:Label>
            </td>
            <td>
                Estimated Duration</td>
            <td>
                 <asp:Label ID="LblEstimatedduration" runat="server"></asp:Label></td>
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
                Fixed Price</td>
            <td>
                <asp:Label ID="LblAmount" runat="server"></asp:Label>
            </td>
            <td>
                Attachments</td>
            <td>
               <asp:Label ID="LblAttachemnts" runat="server"></asp:Label></td>
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
                Description</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LblDescription" runat="server"></asp:Label>
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
                <asp:Button ID="BtnConfirmAndPost" runat="server" Text="Confirm and Post" onclick="BtnConfirmAndPost_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

