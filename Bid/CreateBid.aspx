<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateBid.aspx.cs" Inherits="Bid_CreateBid" %>
<%@ MasterType VirtualPath="~/Site.master"%>


<asp:Content ID="CreateBidHeadContent" ContentPlaceHolderID="MasterHeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="CreateBidMainContent" ContentPlaceHolderID="MasterMainContent" Runat="Server">



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
                Job Posted By</td>
            <td>
                <asp:HyperLink ID="LinkJobPostedBy" runat="server"></asp:HyperLink>
            </td>
            <td>
                Project Name</td>
            <td>
                <asp:Label ID="LblProjectName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Category</td>
            <td>
                <asp:Label ID="LblCategory" runat="server"></asp:Label>
            </td>
            <td>
                Budget</td>
            <td>
                &nbsp;
                <asp:Label ID="LblBudget" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Bid Open Till</td>
            <td>
                <asp:Label ID="LblBidOpenTill" runat="server"></asp:Label>
            </td>
            <td>
                Location</td>
            <td>
                &nbsp;
                <asp:Label ID="LblLocation" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Attachment
            </td>
            <td>
                <asp:Label ID="LblAttachment" runat="server"></asp:Label>
            </td>
            <td>
                Skills</td>
            <td>
                &nbsp;
                <asp:Label ID="LblSkill" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Planned Start
            </td>
            <td>
                <asp:Label ID="LblPlannedStart" runat="server" Text="" ></asp:Label>
            </td>
            <td>
                &nbsp;</td>
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
                &nbsp;</td>
            <td>
                &nbsp;
            </td>
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
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                Fixed Price</td>
            <td>
                $<asp:TextBox ID="TxtAmount" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TxtAmount" ErrorMessage="Fixed Price Required" 
                    ValidationGroup="A">*</asp:RequiredFieldValidator>
            </td>
            <td>
                Advance Payment</td>
                <td> 
                    $<asp:TextBox ID="Txtadvancepayment" runat="server"></asp:TextBox>
            &nbsp;%</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                Estimated Duration</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Select" Value="Select" Selected="True">Select</asp:ListItem>
                    <asp:ListItem Value="Within 1 day" >Within 1 day</asp:ListItem>
                    <asp:ListItem Value="Within 2 day" >Within 2 day</asp:ListItem>
                    <asp:ListItem Value="Within 3 day" >Within 3 day</asp:ListItem>
                    <asp:ListItem Value="Within 1 week" >Within 1 week</asp:ListItem>
                    <asp:ListItem Value="Within 2 week" >Within 2 week</asp:ListItem>
                    <asp:ListItem Value="Within 3 week" >Within 3 week</asp:ListItem>
                    <asp:ListItem Value="Within 1 month" >Within 1 month</asp:ListItem>
                    <asp:ListItem Value="Within 2 month" >Within 2 month</asp:ListItem>
                    <asp:ListItem Value="Within 3 month" >Within 3 month</asp:ListItem>
                    <asp:ListItem Value="More than 6 month" >More than 6 month</asp:ListItem>
                </asp:DropDownList>
            &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ErrorMessage="Estimate Duration Required" Operator="NotEqual" 
                    ValidationGroup="A" ValueToCompare="Select" 
                    ControlToValidate="DropDownList1">*</asp:CompareValidator>
            </td>
            <td>
                Attachments</td>
                <td> 
                    <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                Description</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TxtDescription" ErrorMessage="Description Required" 
                    ValidationGroup="A">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <CKEditor:CKEditorControl ID="TxtDescription" Width="97%" Height="200px" MaxLength="5000"
                    runat="server" ValidationGroup="A"></CKEditor:CKEditorControl></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="3">
                <asp:CheckBox ID="CheckBox1" runat="server" 
                    Text="By submitting my bid on this Contract, I agree to the terms and conditions of theoDesk User Agreement&nbsp;and incorporated&nbsp;Policies." />
                
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="BtnPost" runat="server" Text="Post" Width="75px" 
                    onclick="BtnPost_Click" ValidationGroup="A" />
            </td>
            <td>
                &nbsp;</td>
                <td> &nbsp;</td>
        </tr>
    </table>



</asp:Content>

