<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ViewBid.aspx.cs" Inherits="Bid_ViewBid" %>
<%--<%@ MasterType VirtualPath="~/Site.master"%>--%>

<asp:Content ID="ViewBidMainContent" ContentPlaceHolderID="MasterMainContent" Runat="Server">
    <table class="TableStyle" width="100%">
        <tr>
            <td style=" width:5%;">
                &nbsp;</td>
            <td style=" width:15%;">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style=" width:10%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <b>Project Name</b></td>
            <td>
                <asp:HyperLink ID="LinkProjectName" runat="server"></asp:HyperLink>
            </td>
            <td>
               <b> &nbsp;&nbsp;Provider Name</b></td>
            <td>
                &nbsp;&nbsp;<asp:Label ID="LblProvidername" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <b>Skills</b></td>
            <td>
                <asp:Label ID="LblProviderSkills" runat="server"></asp:Label>
            </td>
            <td>
                 <b>&nbsp; Provider Country</b></td>
            <td>
                &nbsp;
                <asp:Label ID="LblProviderCountry" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 &nbsp;</td>
            <td>
                 <b>Amount</b></td>
            <td>
                <asp:Label ID="LblAmount" runat="server"></asp:Label>
            </td>
            <td>
                 <b>&nbsp; Duration</b></td>
            <td>
                &nbsp;
                <asp:Label ID="LblDuration" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 &nbsp;</td>
            <td>
                 <b>AdvancePayment</b>
            </td>
            <td>
                <asp:Label ID="LblAdvancePayment" runat="server"></asp:Label>
            </td>
            <td>
                 <b>&nbsp;&nbsp;BidOn</b></td>
            <td>
                &nbsp;
                <asp:Label ID="LblBidOn" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td>&nbsp;</td>
            <td colspan="3">
                 <b>Description</b>
            </td>
            <td></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td colspan="3">
              <asp:Label ID="LblDescription" runat="server"></asp:Label>
            </td>
            <td>
               
            </td>
          </tr>
          <tr>
          <td colspan="6"></td>
          </tr>

          <tr>
            <td colspan="6" style=" text-align:center;">
                <asp:Button ID="BtnAcceptBid" runat="server" Text="Accept" />
            </td>
          </tr>

          <tr>
            <td colspan="6"></td>
          </tr>

        </table>
</asp:Content>

