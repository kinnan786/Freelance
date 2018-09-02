<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ViewProject.aspx.cs" Inherits="Project_ViewProject" %>

<%@ MasterType VirtualPath="~/Site.master" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="ViewProjectHeadContent" ContentPlaceHolderID="MasterHeadContent"
    runat="Server">
</asp:Content>
<asp:Content ID="ViewProjectMainContent" ContentPlaceHolderID="MasterMainContent"
    runat="Server">
    <table class="TableStyle" width="100%">
        <tr>
            <td style=" width:5%;">
                &nbsp;</td>
            <td style=" width:15%;">
                &nbsp;</td>
            <td style=" width:30%;">
                &nbsp;</td>
            <td style=" width:15%;">
                &nbsp;</td>
            <td style=" width:30;">
                &nbsp;</td>
            <td style=" width:5%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style=" width:5%;">
                &nbsp;</td>
            <td colspan="4" style=" width:90%;">
             <asp:Label ID="LblProjectName" runat="server" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            </td>
            <td style=" width:5%;">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td> &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <b>Job Posted By</b></td>
            <td>
                <asp:HyperLink ID="LinkJobPostedBy" runat="server"></asp:HyperLink>
            </td>
            <td> <b>Category</b>
               </td>
            <td>
               <asp:Label ID="LblCategory" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td><b>Planned Start</b></td>
            <td>
                <asp:Label ID="LblPlannedStart" runat="server" Text="" ></asp:Label>
            </td>
            <td>
                 <b>Budget</b></td>
            <td>
                
                <asp:Label ID="LblBudget" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 &nbsp;</td>
            <td>
                 <b>Bid Open Till</b></td>
            <td>
                <asp:Label ID="LblBidOpenTill" runat="server"></asp:Label>
            </td>
            <td>
                 <b>Location</b></td>
            <td>
                
                <asp:Label ID="LblLocation" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 &nbsp;</td>
            <td>
                 <b>Attachment</b>
            </td>
            <td>
                <asp:Label ID="LblAttachment" runat="server"></asp:Label>
            </td>
            <td>
                 <b>Skills</b></td>
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
              
            </td>
            <td>
               
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="4">
              <hr />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                 &nbsp;</td>
            <td>
                 <b>Description</b></td>
            <td id="LblDescription">
                &nbsp;
                </td>
            <td id="LblDescription">
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="4">
                <asp:Label ID="LblDescription" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style=" text-align:center;">
                &nbsp;</td>
            <td colspan="4" style=" text-align:center;">
               <asp:Button ID="BtnBid" runat="server" Text="Bid" Width="85px" OnClick="BtnBid_Click" />
            </td>
            <td style=" text-align:center;">
                &nbsp;</td>
        </tr>
        <tr style=" height:10px;">
        <td >&nbsp;</td>
        <td colspan="4" ></td>
        <td >&nbsp;</td>
        </tr>
        </table>
        <br />
        <table width="800px" class="style1">
        <tr>
            <td>
                <asp:TabContainer ID="TabContainerBids" runat="server" ActiveTabIndex="0" Width="100%">
                    <asp:TabPanel Width="100%" runat="server" HeaderText="Bids" ID="TabPanelBids">
                        <ContentTemplate>
                             <div style=" text-align:center; height:20px;"><label id="LblNoBids" runat="server" visible="true">No Bids</label></div>
                             <asp:DataList ID="DataListBidOnProject" Visible="true" runat="server" Width="100%" OnItemDataBound="ItemDataBound_DataListBidOnProject">
                               <AlternatingItemStyle CssClass="AlternateItemonHover" />
                                <ItemStyle CssClass="ItemonHover" />
                            <ItemTemplate>
                                    <table width="100%" CellPadding="0" CellSpacing="0"  style=" text-align:left; border-width:0; border-style:none;">
                                    <tr>
                                        <td rowspan="4" style=" width:60px;">
                                            <asp:Image ImageUrl="~/Images/nopicture.gif" ID="Imglogo" Width="50px" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="vertical-align: top; margin: 0 0 0 0; ">
                                            <asp:HyperLink ID="LnkName" runat="server" NavigateUrl=''>
                                              <asp:Label ID="Name" runat="server" Text='' />
                                             </asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblCountry" runat="server" Text='' />
                                            <%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblBidOn" runat="server" Text='<%#Eval("BidOn") %>' />--%>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblAmount" runat="server" Text='' />
                                           </td></tr><tr>
                                        <td style="vertical-align:top;">
                                        <asp:Label ID="LblProviderSkill" runat="server" Text='' />
                                        </td>
                                    </tr>
                                    <tr>
                                       <td style="vertical-align:top;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
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
