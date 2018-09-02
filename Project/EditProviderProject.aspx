<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="EditProviderProject.aspx.cs" Inherits="Project_EditProviderProject" %>

<%@ MasterType VirtualPath="~/Site.master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="ViewProjectHeadContent" ContentPlaceHolderID="MasterHeadContent"
    runat="Server">
</asp:Content>
<asp:Content ID="ViewProjectMainContent" ContentPlaceHolderID="MasterMainContent"
    runat="Server">
    <table class="TableStyle" width="100%">
        <tr>
            <td style="width: 5%;">
                &nbsp;
            </td>
            <td style="width: 15%;">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td style="width: 10%;">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Job Posted By</b>
            </td>
            <td>
                <asp:HyperLink ID="LinkJobPostedBy" runat="server"></asp:HyperLink>
            </td>
            <td>
                <b>&nbsp;&nbsp;Project Name</b>
            </td>
            <td>
                &nbsp;&nbsp;<asp:Label ID="LblProjectName" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Category</b>
            </td>
            <td>
                <asp:Label ID="LblCategory" runat="server"></asp:Label>
            </td>
            <td>
                <b>&nbsp; Budget</b>
            </td>
            <td>
                &nbsp;
                <asp:Label ID="LblBudget" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Bid Open Till</b>
            </td>
            <td>
                <asp:Label ID="LblBidOpenTill" runat="server"></asp:Label>
            </td>
            <td>
                <b>&nbsp; Location</b>
            </td>
            <td>
                &nbsp;
                <asp:Label ID="LblLocation" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Attachment</b>
            </td>
            <td>
                <asp:Label ID="LblAttachment" runat="server"></asp:Label>
            </td>
            <td>
                <b>&nbsp;&nbsp;Skills</b>
            </td>
            <td>
                &nbsp;
                <asp:Label ID="LblSkill" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Planned Start</b>
            </td>
            <td>
                <asp:Label ID="LblPlannedStart" runat="server" Text=""></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <b>Description</b>
            </td>
            <td id="LblDescription">
                &nbsp;
            </td>
            <td id="LblDescription">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td colspan="4">
                <asp:Label ID="LblDescription" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="text-align: center;">
                &nbsp;
            </td>
            <td colspan="4" style="text-align: center;">
                <asp:Button ID="BtnBid" runat="server" Text="Bid" Width="85px" OnClick="BtnBid_Click" />
            </td>
            <td style="text-align: center;">
                &nbsp;
            </td>
        </tr>
        <tr style="height: 10px;">
            <td>
                &nbsp;
            </td>
            <td colspan="4">
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <br />
    <table width="100%" class="style1">
        <tr>
            <td>
                <asp:TabContainer ID="TabContainerBids" runat="server" ActiveTabIndex="0" Width="100%">
                    <asp:TabPanel Width="100%" runat="server" HeaderText="Bids" ID="TabPanelBids">
                        <ContentTemplate>
                            <div style="text-align: center; height: 20px;">
                                <label id="LblNoBids" runat="server" visible="true">
                                    No Bids</label></div>
                            <asp:DataList ID="DataListBidOnProject" Visible="true" runat="server" Width="100%"
                                OnItemDataBound="DataListBidOnProject_ItemDataBound">
                                <AlternatingItemStyle CssClass="AlternateItemonHover" />
                                <ItemStyle CssClass="ItemonHover" />
                                <ItemTemplate>
                                    <table width="100%" cellpadding="0" cellspacing="0" style="text-align: left; border-width: 0px;
                                        border-style: none;">
                                        <tr>
                                            <td style="width: 60px;">
                                                <asp:Image ImageUrl="~/Images/nopicture.gif" ID="Imglogo" Width="50px" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="vertical-align: top; margin: 0 0 0 0;">
                                                <asp:HyperLink ID="LnkName" runat="server">
                                                    <asp:Label ID="Name" runat="server" />
                                                </asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblCountry" runat="server" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblAmount" runat="server" />
                                                <div style="text-align: right;">
                                                    <asp:LinkButton ID="BtnViewtBid" runat="server" Text="View Bid">View Bid</asp:LinkButton></div></td></tr><tr>
                                            <td style="vertical-align: top;">
                                                <asp:Label ID="LblProviderSkill" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="vertical-align: top;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="LblDescription" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </ContentTemplate>
                    </asp:TabPanel>
                </asp:TabContainer>
            </td>
        </tr>
    </table>
</asp:Content>
