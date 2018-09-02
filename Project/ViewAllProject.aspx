<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ViewAllProject.aspx.cs" Inherits="Project_ViewAllProject" %>
<%@ MasterType VirtualPath="~/Site.master" %>

<asp:Content ID="ViewAllProjectMainContent" ContentPlaceHolderID="MasterMainContent"
    runat="Server">
    <table width="100%" class="TableStyle">
        <tr>
            <td style="width:100px;">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Search Project</td>
            <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
            &nbsp; &nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Search" Width="150px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Search/AdvanceSearch.aspx">Advance Search</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><label id="LblNorecord" runat="server" text="No Record Found" visible="false">No Record Found</label></la</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <asp:DataList ID="DataListProject" runat="server" Width="100%" 
            onitemdatabound="DataListProject_ItemDataBound" >
            <AlternatingItemStyle CssClass="AlternateItemonHover" />
            <ItemStyle CssClass="ItemonHover" />
            <ItemTemplate>
                <table width="100%" >
                    <tr>
                        <td colspan=3 style="width:100%">
                            <asp:HyperLink ID="LnkName" runat="server" >
                           
                            </asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td style="width:150px;">
                        <b>Posted By:</b>&nbsp;&nbsp;<asp:Label ID="LblPostedby" runat="server"  />
                          
                        </td>
                        <td style="width:200px;">
                            <b>Category:</b>&nbsp;&nbsp;<asp:Label ID="LblJobCategory" runat="server"  />
                        </td>
                        <td style="width:150px;"> <b>Total Bids:</b>&nbsp;&nbsp;<asp:Label ID="LblTotalbids" runat="server"  /></td>
                    </tr>
                    <tr>
                    <td><b>Budget:</b>&nbsp;&nbsp;<asp:Label ID="LblBudget" runat="server" /></td>
                    <td><b>Bid Open Till:</b>&nbsp;&nbsp; <asp:Label ID="LblBidOpenTill" runat="server"  /></td>
                    <td><b>Posted :</b>&nbsp;&nbsp; <asp:Label ID="LblPostedOn" runat="server"  /></td>
                    </tr>
                    <tr>
                        <td colspan="4" style="width:100%;">
                            <b>Skill:</b>&nbsp;&nbsp;<asp:Label ID="LblSkill" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="width:100%;">
                        <asp:Label ID="LblDescription" runat="server"  />
                        </td>
                    </tr>
                 </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <table width="100%" cellpadding="0" border="0">
        <tr>
            <td align="center">
                <asp:LinkButton ID="lbtnFirst" runat="server" CausesValidation="false" OnClick="lbtnFirst_Click">First</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="lbtnPrevious" runat="server" CausesValidation="false" OnClick="lbtnPrevious_Click">Previous</asp:LinkButton>&nbsp;&nbsp;
                &nbsp;&nbsp;<asp:LinkButton ID="lbtnNext" runat="server" CausesValidation="false"
                    OnClick="lbtnNext_Click">Next</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="lbtnLast" runat="server" CausesValidation="false" OnClick="lbtnLast_Click">Last</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="5" align="center" style="height: 30px" valign="middle">
                <asp:Label ID="lblPageInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
