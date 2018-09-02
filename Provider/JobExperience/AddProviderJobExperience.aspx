<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master"
    AutoEventWireup="true" CodeFile="AddProviderJobExperience.aspx.cs" Inherits="Provider_JobExperience_AddProviderJobExperience" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ProfileMasterPageRightContent" runat="Server">
    <table class="TableStyle" width="850px">
        <tr>
            <td style="width: 50px;">
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
            <td colspan="4">
                &nbsp;
            </td>
            <td style="width: 20px;">
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
                Position
            </td>
            <td>
                &nbsp;
            </td>
            <td colspan="4">
                <asp:TextBox ID="TxtPosition" runat="server" Width="350px" MaxLength="50"></asp:TextBox>
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
            <td colspan="4">
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
                Organization Name
            </td>
            <td>
                &nbsp;
            </td>
            <td colspan="4">
                <asp:TextBox ID="TxtOrganizationName" runat="server" Width="350px" 
                    MaxLength="50"></asp:TextBox>
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
            <td colspan="4">
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
            <td colspan="4">
                <asp:CheckBox ID="ChkCurrentlyWorkHere" runat="server" Text="Currently Work Here" />
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
                From
            </td>
            <td>
                &nbsp;
            </td>
            <td valign="top">
                Month&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DDListFromMonth" runat="server">
                    <asp:ListItem Selected="True" Value="0" Text="Select"></asp:ListItem>
                    <asp:ListItem Value="January" Text="January"></asp:ListItem>
                    <asp:ListItem Value="Feburary" Text="Feburary"></asp:ListItem>
                    <asp:ListItem Value="March" Text="March"></asp:ListItem>
                    <asp:ListItem Value="April" Text="April"></asp:ListItem>
                    <asp:ListItem Value="May" Text="May"></asp:ListItem>
                    <asp:ListItem Value="June" Text="June"></asp:ListItem>
                    <asp:ListItem Value="July" Text="July"></asp:ListItem>
                    <asp:ListItem Value="August" Text="August"></asp:ListItem>
                    <asp:ListItem Value="September" Text="September"></asp:ListItem>
                    <asp:ListItem Value="October" Text="October"></asp:ListItem>
                    <asp:ListItem Value="November" Text="November"></asp:ListItem>
                    <asp:ListItem Value="December" Text="December"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Year &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DDListFromYear" runat="server">
                    <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
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
            <td colspan="4">
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
                To
            </td>
            <td>
                &nbsp;
            </td>
            <td valign="top">
                Month&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DDListToMonth" runat="server">
                    <asp:ListItem Selected="True" Value="0" Text="Select"></asp:ListItem>
                    <asp:ListItem Value="January" Text="January"></asp:ListItem>
                    <asp:ListItem Value="Feburary" Text="Feburary"></asp:ListItem>
                    <asp:ListItem Value="March" Text="March"></asp:ListItem>
                    <asp:ListItem Value="April" Text="April"></asp:ListItem>
                    <asp:ListItem Value="May" Text="May"></asp:ListItem>
                    <asp:ListItem Value="June" Text="June"></asp:ListItem>
                    <asp:ListItem Value="July" Text="July"></asp:ListItem>
                    <asp:ListItem Value="August" Text="August"></asp:ListItem>
                    <asp:ListItem Value="September" Text="September"></asp:ListItem>
                    <asp:ListItem Value="October" Text="October"></asp:ListItem>
                    <asp:ListItem Value="November" Text="November"></asp:ListItem>
                    <asp:ListItem Value="December" Text="December"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Year &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DDListToYear" runat="server">
                    <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
            </td>
            <td>
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
            <td colspan="4">
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
            <td style="vertical-align: top;">
                Responsibilities
            </td>
            <td>
                &nbsp;
            </td>
            <td colspan="4">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtresponsibility" runat="server" Width="560px" 
                            MaxLength="100"></asp:TextBox>
                        <asp:ImageButton ID="LinkAddEmployment" ImageUrl="~/Images/add.png" runat="server"
                            OnClick="LinkAddEmployment_Click" />
                        <asp:ImageButton ID="LinkDeleteEmployment" ImageUrl="~/Images/delete.gif" runat="server"
                            OnClick="LinkDeleteEmployment_Click" style="width: 16px" />
                        <asp:ImageButton ID="LinkEditEmployment" ImageUrl="~/Images/edit_button.gif" runat="server"
                            OnClick="LinkEditEmployment_Click" style="width: 17px" />
                        <br />
                        <asp:ListBox ID="lstResponsibilites" runat="server" Width="566px" Height="175px"
                            Style="border-top: 0px;"></asp:ListBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <%-- <asp:TextBox ID="TxtDescription" runat="server" Height="200px" Width="350px"></asp:TextBox>--%>
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
            <td colspan="4">
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
            <td style="vertical-align: top;">
                Skills
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtskills" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
                        &nbsp;
                        <asp:ImageButton ID="LinkAddToolsused" ImageUrl="~/Images/add.png" runat="server"
                            OnClick="LinkAddToolsused_Click" />
                        <asp:ImageButton ID="LinkDeleteToolUsed" ImageUrl="~/Images/delete.gif" runat="server"
                            OnClick="LinkDeleteToolUsed_Click" Style="height: 16px; width: 16px;" />
                        <br />
                        <asp:ListBox ID="lstSkills" runat="server" Width="206px" Height="175px" Style="border-top: 0px;">
                        </asp:ListBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td style="vertical-align: top;">
            </td>
            <td colspan="2">
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
            <td colspan="4">
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
            <td colspan="4">
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
            <td colspan="4">
                <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" Width="85px" />
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
            <td colspan="4">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
