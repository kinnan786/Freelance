<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProviderJobs.aspx.cs" Inherits="WorkSpace_ProviderJobs" %>

<asp:Content ID="ProviderHeadContent" ContentPlaceHolderID="MasterMainContent" Runat="Server">

<table width="100%" border="0" style=" border-style:solid; border-color:gray; background-color:Gray;">
<tr>
    <td>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="LnkNewJob" runat="server" NavigateUrl="~/Project/AddNewProject.aspx" ForeColor="White" Font-Bold="false" Font-Size="Medium">NEW JOB</asp:HyperLink> 
    </td>
</tr>
</table>
 <asp:DataList ID="DataListProject" runat="server" Width="100%" 
            onitemdatabound="DataListProject_ItemDataBound">
             <AlternatingItemStyle CssClass="AlternateItemonHover" />
            <ItemStyle CssClass="ItemonHover" />
            <ItemTemplate>
            <br />
                <table width="100%">
                    <tr>
                        <td colspan=4>
                            <asp:HyperLink ID="LnkName" runat="server" >
                           
                            </asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <b>Skill:</b>&nbsp;&nbsp;<asp:Label ID="LblSkill" runat="server" />
                        </td>
                        <td>
                            <b>Category:</b>&nbsp;&nbsp;<asp:Label ID="LblJobCategory" runat="server"  />
                        </td>
                        <td><b>Total Bids:</b>&nbsp;&nbsp;<asp:Label ID="LblTotalbids" runat="server"  /></td>
                        <td><b>Posted By:</b>&nbsp;&nbsp;<asp:Label ID="LblPostedby" runat="server"  /></td>
                    </tr>
                    <tr>
                    <td><b>Budget:</b>&nbsp;&nbsp;<asp:Label ID="LblBudget" runat="server" /></td>
                    <td><b>Bid Open Till:</b>&nbsp;&nbsp; <asp:Label ID="LblBidOpenTill" runat="server"  /></td>
                    <td><b>Posted :</b>&nbsp;&nbsp; <asp:Label ID="LblPostedOn" runat="server"  /></td>
                    <td></td>
                    </tr>
                    <tr>
                        <td colspan="4" >
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
                <asp:LinkButton ID="lbtnFirst" runat="server" CausesValidation="false" OnClick="lbtnFirst_Click" Visible="false">First</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="lbtnPrevious" runat="server" CausesValidation="false" OnClick="lbtnPrevious_Click" Visible="false">Previous</asp:LinkButton>&nbsp;&nbsp;
                &nbsp;&nbsp;<asp:LinkButton ID="lbtnNext" runat="server" CausesValidation="false" Visible="false"
                    OnClick="lbtnNext_Click">Next</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="lbtnLast" runat="server" CausesValidation="false" OnClick="lbtnLast_Click" Visible="false">Last</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="5" align="center" style="height: 30px" valign="middle">
                <asp:Label ID="lblPageInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

