<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ViewProfile.aspx.cs" Inherits="Provider_ViewProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" runat="Server">
    <table width="950px" cellpadding="0" cellspacing="0" style="margin-left: auto; margin-right: auto;">
        <tr>
            <td>
                <table class="CascadeTable" border="0" cellspacing="0">
                    <tr>
                        <td class="TableHeader" style="font-weight: bold;">
                            Logo
                        </td>
                        <td class="TableHeader" style="width: 100px; text-align: right;">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 100px">
                         <asp:Image ID="Image1" runat="server" Width="130px" Height="100" />
                        </td>
                    </tr>
                </table>
            </td>
            <td colspan="2" rowspan="2">
                <table class="CascadeTable" style="width: 500px;" border="0" cellspacing="0">
                    <tr>
                        <td class="TableHeader " style="text-align: left; font-weight: bold;">
                            KeySkills
                        </td>
                        <td class="TableHeader" style="text-align: right;">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 30px;" colspan="2">
                            <asp:DataList ID="DataListSkills" runat="server" Width="100px" CellPadding="0" ForeColor="#333333"
                                RepeatColumns="6" RepeatDirection="Horizontal" Style="border-bottom: 0;">
                                <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                <HeaderStyle BackColor="#546E96" Font-Bold="True" ForeColor="White" />
                                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <ItemTemplate>
                                    <table cellpadding="5" cellspacing="5" width="100%">
                                        <tr>
                                            <td style="width: 15%">
                                            </td>
                                            <td style="width: 70%">
                                                <asp:Label runat="server"><%# Eval("SkillName") %></asp:Label>
                                            </td>
                                            <td style="width: 15%">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="CascadeTable" style="width: 200px; text-align: left;" border="0" cellspacing="0">
                    <tr>
                        <td class="TableHeader " style="text-align: left; font-weight: bold;">
                            Contact
                        </td>
                        <td class="TableHeader" style="text-align: right;">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 50px;">
                            <table width="100%">
                                <tr>
                                    <td style="font-weight: bold;">
                                        Address
                                    </td>
                                    <td>
                                        <asp:Label ID="LblAddress1" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">
                                        Phone
                                    </td>
                                    <td>
                                        <asp:Label ID="LblPhone" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">
                                        Email
                                    </td>
                                    <td>
                                        <asp:Label ID="LblEmail" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="4">
            </td>
        </tr>
    </table>
    <br />
    <hr style=" width:100%;" />
    <table width="100%" cellpadding="0" cellspacing="0" style="  min-height:50px;">
        <tr>
            <td  style="text-align: right; width: 100%;">
            </td>
        </tr>
        <tr>
            <td style=" height:30px; vertical-align: top;">
                <asp:Label ID="LblFirstName" runat="server"></asp:Label>
                &nbsp;
                <asp:Label ID="LblMiddleName" runat="server"></asp:Label>
                &nbsp;
                <asp:Label ID="LblLastName" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
        <td style=" height:30px; vertical-align: top;">
            <b>Total Jobs Completed: </b> <asp:Label ID="LblJobsCompleted" runat="server" Text=""></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <b>Total Jobs InProgress: </b><asp:Label ID="LblJobsinprogress" runat="server" Text=""></asp:Label>
        </td>
        </tr>
    </table>
    <hr />
    <br />
    <table width="920px" cellpadding="0" cellspacing="0" class="CascadeTable" style="text-align: left;">
        <tr>
            <td class="TableHeader " style="text-align: left; font-weight: bold;">
                About
            </td>
            <td class="TableHeader" style="text-align: right;">
            </td>
        </tr>
        <tr>
            <td style="min-height: 50px;" colspan="2">
                <table width="100%">
                    <tr>
                        <td style="width: 200px; font-weight: bold;" colspan="2">
                            Have's
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 10px;">
                        </td>
                        <td>
                            <asp:Label ID="LblHave" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 200px; font-weight: bold;" colspan="2">
                            Want's
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Label ID="Lblwants" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 200px; font-weight: bold;" colspan="2">
                            OverView
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Label ID="LblOverView" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <br />
    <table width="920px" cellpadding="0" cellspacing="0" class="CascadeTable">
        <tr>
            <td class="TableHeader " style="text-align: left; font-weight: bold;">
                Work Experience
            </td>
            <td class="TableHeader" style="text-align: right;">
            </td>
        </tr>
        <tr>
            <td style="min-height: 50px;" colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#546E96" GridLines="Horizontal"
                    Width="100%" AutoGenerateColumns="false" Style="border-bottom: 0;">
                    <EmptyDataTemplate>
                        Provider Did not Add Job Experience
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField HeaderText="Company">
                            <ItemTemplate>
                                <asp:Label ID="LblCompanyName" runat="server" Text='<%# Eval("OrganizationName")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Position">
                            <ItemTemplate>
                                <asp:Label ID="LblPosition" runat="server" Text='<%# Eval("Position")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Responsibilities">
                            <ItemTemplate>
                                <asp:Label ID="LblResponsibilities" runat="server" Text='<%# Eval("Responsibilities")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TimePeriod">
                            <ItemTemplate>
                                <asp:Label ID="LblTimePeriod" runat="server" Text='<%# Eval("FromMonth") %>'></asp:Label>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("FromYear") %>'></asp:Label>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("ToMonth") %>'></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("FromYear") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <HeaderStyle BackColor="#546E96" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
    <table width="920px" cellpadding="0" cellspacing="0" class="CascadeTable">
        <tr>
            <td class="TableHeader " style="text-align: left; font-weight: bold;">
                Job Experience
            </td>
            <td class="TableHeader" style="text-align: right;">
            </td>
        </tr>
        <tr>
            <td style="min-height: 50px; vertical-align: top;" colspan="2">
                <asp:GridView ID="GridViewJobExperience" runat="server" CellPadding="0" CellSpacing="0"
                    ForeColor="#333333" Width="100%" AutoGenerateColumns="false" ShowHeader="false"
                    Style="border-bottom: 0;">
                    <EmptyDataTemplate>
                        Provider Did not Add Job Experience
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField HeaderStyle-Height="0px">
                            <ItemTemplate>
                                <table width="100%" border="1">
                                    <tr>
                                        <td align="left">
                                            <b>Position:&nbsp; </b>
                                            <asp:Label ID="LblPosition" runat="server" Text='<%# Eval("Position")%>'></asp:Label>
                                        </td>
                                        <td align="right">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            &nbsp; <b>Skill used:&nbsp; </b>
                                            <asp:Label ID="LblSkillused" runat="server" Text='<%# Eval("OrganizationName")%>'></asp:Label>
                                        </td>
                                        <td align="left">
                                            &nbsp; <b>Tools used:&nbsp; </b>
                                            <asp:Label ID="LblToolused" runat="server" Text='<%# Eval("OrganizationName")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            &nbsp; <b>Company Name:&nbsp; </b>
                                            <asp:Label ID="LblCompanyName1" runat="server" Text='<%# Eval("OrganizationName")%>'></asp:Label>
                                        </td>
                                        <td align="left">
                                            &nbsp; <b>Time Period:&nbsp; </b>
                                            <asp:Label ID="LblTimePeriod" runat="server" Text='<%# Eval("FromMonth") %>'></asp:Label>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("FromYear") %>'></asp:Label>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ToMonth") %>'></asp:Label>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("FromYear") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" align="left">
                                            &nbsp; <b>Responsibilities:&nbsp; </b>
                                            <asp:Label ID="LblResponsibilities" runat="server" Text='<%# Eval("Responsibilities")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" td align="left">
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
    <table width="920px" cellpadding="0" cellspacing="0" class="CascadeTable">
        <tr>
            <td class="TableHeader " style="text-align: left; font-weight: bold;">
                Education
            </td>
            <td class="TableHeader" style="text-align: right;">
            </td>
        </tr>
        <tr>
            <td style="min-height: 50px; vertical-align: top;" colspan="2">
                <asp:GridView ID="GridViewEducation" runat="server" CellPadding="0" ForeColor="#333333"
                    ShowHeader="false" GridLines="both" Width="100%" AutoGenerateColumns="false"
                    CellSpacing="0" Style="border-bottom: 0;">
                    <EmptyDataTemplate>
                        Provider Did not Add Education
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table width="100%" border="0">
                                    <tr>
                                        <td rowspan="2" width="10%">
                                            <asp:Label ID="LblYearCompleted" runat="server" Font-Bold="true" Text='<%# Eval("YearCompleted")%>'></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:Label ID="LblInstitutionName" runat="server" Text='<%# Eval("InstitutionName")%>'></asp:Label>
                                        </td>
                                        <td align="right">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left">
                                            <asp:Label ID="LblDegreeTitle" runat="server" Text='<%# Eval("DegreeTitle")%>'></asp:Label>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
    <table width="920px" cellpadding="0" cellspacing="0" class="CascadeTable">
        <tr>
            <td class="TableHeader " style="text-align: left; font-weight: bold;">
                Certification
            </td>
            <td class="TableHeader" style="text-align: right;">
            </td>
        </tr>
        <tr>
            <td style="min-height: 50px; vertical-align: top;" colspan="2">
                <asp:GridView ID="GridViewCertification" runat="server" CellPadding="0" ForeColor="#333333"
                    ShowHeader="false" GridLines="Both" Width="100%" AutoGenerateColumns="false"
                    CellSpacing="0" Style="border-bottom: 0;">
                    <EmptyDataTemplate>
                        Provider did not Added Certification
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table width="100%" border="0">
                                    <tr>
                                        <td width="10%">
                                            <b>
                                                <asp:Label ID="LblYearCompleted" runat="server" Text='<%# Eval("YearCompleted")%>'></asp:Label></b>
                                        </td>
                                        <td align="left">
                                            <asp:Label ID="LblCertificationName" runat="server" Text='<%# Eval("CertificationName")%>'></asp:Label>
                                            <br />
                                            (<asp:Label ID="LblPercentage" runat="server" Text='<%# Eval("Percentage")%>'></asp:Label>%)
                                        </td>
                                        <td align="right">
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
