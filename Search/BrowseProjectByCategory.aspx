<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BrowseProjectByCategory.aspx.cs" Inherits="Search_BrowseProjectByCategory" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" Runat="Server">
    <asp:DataList ID="DatLstCategories" Width="100%" runat="server" RepeatDirection="Horizontal" RepeatColumns="4" onitemdatabound="DatLstCategories_ItemDataBound">
    <ItemTemplate>
        <asp:Label ID="LblCategory" runat="server" Text="Label"></asp:Label>,&nbsp;&nbsp;
        <asp:HyperLink ID="LnkSubCategory" runat="server" />
    </ItemTemplate>
    </asp:DataList>
</asp:Content>

