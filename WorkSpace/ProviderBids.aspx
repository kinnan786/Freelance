<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProviderBids.aspx.cs" Inherits="WorkSpace_ProviderBids" %>

<asp:Content ID="ProviderBidHeadContent" ContentPlaceHolderID="MasterHeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="ProviderBidMainContent" ContentPlaceHolderID="MasterMainContent" Runat="Server">
<asp:DataList ID="DataListProviderBids" runat="server" Width="100%" OnItemDataBound="DataListProviderBids_OnItemDataBound" >
       <AlternatingItemStyle CssClass="AlternateItemonHover" />
            <ItemStyle CssClass="ItemonHover" />
        <ItemTemplate>
            <table width="100%">
                <tr>
                    <td  style=" width:10px;">
                        <asp:HyperLink ID="LnkName" runat="server" >
                            <asp:Label ID="LblProjectTitle" runat="server" />
                        </asp:HyperLink>
                    </td>
                </tr>
                    <tr>
                        <td style=" width:50px;">
                            <asp:Label ID="LblAmount" runat="server"  />
                            &nbsp; <%-- <asp:Label ID="LblComments" runat="server" Text='<%#Eval("Comments") %>' />--%>
                        </td>
                    </tr>
                  <tr>
                  <td>
                  <asp:Label ID="LblBidOpen" runat="server"></asp:Label>
                  </td>
                </tr>
            </table>
            <br />  <br />  <br />
        </ItemTemplate>
    </asp:DataList>
    <br />
        <table width="100%" cellpadding="0" border="0">
        <tr>
            <td align="center">
                <asp:LinkButton ID="lbtnFirst" runat="server" CausesValidation="false" OnClick="lbtnFirst_Click" Visible="false" >First</asp:LinkButton>&nbsp; <asp:LinkButton ID="lbtnPrevious" runat="server" CausesValidation="false" OnClick="lbtnPrevious_Click" Visible="false" >Previous</asp:LinkButton>&nbsp;&nbsp;
                &nbsp;&nbsp;<asp:LinkButton ID="lbtnNext" runat="server" CausesValidation="false" Visible="false"
                    OnClick="lbtnNext_Click">Next</asp:LinkButton>&nbsp; <asp:LinkButton ID="lbtnLast" runat="server" CausesValidation="false" OnClick="lbtnLast_Click" Visible="false">Last</asp:LinkButton></td></tr><tr>
            <td colspan="5" align="center" style="height: 30px" valign="middle">
                <asp:Label ID="lblPageInfo" runat="server"></asp:Label></td></tr></table></asp:Content>