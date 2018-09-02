<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="SearchProvider.aspx.cs" Inherits="Provider_SearchProvider" %>
<%@ MasterType VirtualPath="~/Site.master" %>

<asp:Content ID="SearchProviderMainContent" ContentPlaceHolderID="MasterMainContent" runat="Server">
      <table class="TableStyle" width="100%">
        <tr>
            <td style="width:100px;">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Search Provider</td>
            <td>
            <asp:TextBox ID="TxtSearchworkers" runat="server" Width="250px"></asp:TextBox>
            &nbsp; &nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Search" Width="150px" 
                    onclick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <asp:DataList ID="DataListProvider" runat="server" Width="100%" 
          CellPadding="0" CellSpacing="0" style=" text-align:left;" 
          onitemdatabound="DataListProvider_ItemDataBound">
            <AlternatingItemStyle CssClass="AlternateItemonHover" />
            <ItemStyle CssClass="ItemonHover" />
            <ItemTemplate>
            <br />
                <table width="100%" CellPadding="2px" CellSpacing="0"  style=" text-align:left; border-width:0; border-style:none;">
                    <tr>
                        <td rowspan="4" style=" width:80px; vertical-align:top;">
                            <asp:Image ID="Imglogo" Width="80px" Height="80px" runat="server" ImageUrl="~/Images/nopicture.gif" />
                        </td>
                    </tr>
                    <tr>
                        <td style="vertical-align: top; margin: 0 0 0 0; ">
                            <asp:HyperLink ID="LnkName" runat="server" >
                                <asp:Label ID="FirstName" runat="server"  />
                                &nbsp;
                                <asp:Label ID="LastName" runat="server"  />
                            </asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblCountry" runat="server"  />
                        </td>
                    </tr>
                    <tr>
                        <td style="vertical-align:top;">
                        <asp:Label ID="LblProviderSkill" runat="server"  />
                        </td>
                    </tr>
                    <tr>
                       <td style="vertical-align:top;">
                         <asp:Label ID="LblOverView" runat="server"   />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
      <br />
      <table width="100%" cellpadding="0" border="0">
        <tr>
            <td align="center">
                <asp:LinkButton ID="lbtnFirst" runat="server" CausesValidation="false" OnClick="lbtnFirst_Click">First</asp:LinkButton>&nbsp; <asp:LinkButton ID="lbtnPrevious" runat="server" CausesValidation="false" OnClick="lbtnPrevious_Click">Previous</asp:LinkButton>&nbsp;&nbsp;
                &nbsp;&nbsp;<asp:LinkButton ID="lbtnNext" runat="server" CausesValidation="false"
                    OnClick="lbtnNext_Click">Next</asp:LinkButton>&nbsp; <asp:LinkButton ID="lbtnLast" runat="server" CausesValidation="false" OnClick="lbtnLast_Click">Last</asp:LinkButton></td></tr><tr >
            <td colspan="5" align="center" style="height: 30px" valign="middle">
                <asp:Label ID="lblPageInfo" runat="server"></asp:Label></td></tr></table></asp:Content>