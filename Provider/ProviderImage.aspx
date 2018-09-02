<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master" AutoEventWireup="true" CodeFile="ProviderImage.aspx.cs" Inherits="Provider_ProviderImage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ProfileMasterPageRightContent" Runat="Server">
    <table width="100%" class="TableStyle">
<tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>
    <asp:Image ID="ImgPic" runat="server" Width="150px" /></td>
    
</tr>
<tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>
        &nbsp;</td>
</tr>
<tr>
    <td>&nbsp;</td>
    <td>Image/Logo</td>
    <td>
        &nbsp;</td>
    <td>
        <asp:FileUpload ID="ImgUpld" Width="400px" runat="server" />
<br />
    </td>
</tr>
<tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>
        &nbsp;</td>
</tr>
<tr>
    <td>&nbsp;</td>
    <td>
    </td>
    <td></td>
    <td>
            <asp:Button ID="BtnImgSave" runat="server" Text="Save" Width="80px" onclick="BtnImgSave_Click" /></td>
</tr>
</table> 
</asp:Content>

