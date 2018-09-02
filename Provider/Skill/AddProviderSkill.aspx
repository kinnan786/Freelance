<%@ Page Title="" Language="C#" MasterPageFile="~/Provider/ProfileMasterPage.master"
    AutoEventWireup="true" CodeFile="AddProviderSkill.aspx.cs" Inherits="Provider_Skill_AddProviderSkill" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ProfileMasterPageRightContent" runat="Server">
    <style type="text/css">
        .button
        {
            position: relative;
            background-repeat: no-repeat;
            white-space: nowrap;
            display: block;
            width: 76px;
            height: 31px;
            margin: 0px;
            padding: 0px;
        }
        .button a
        {
            display: block;
            color: #666;
            font-weight: bold;
            width: 76px;
            height: 31px;
            display: block;
            float: left;
            text-decoration: none;
        }
        .button img
        {
            width: 76px;
            height: 31px;
            border: 0;
        }
        .button img
        {
            width: 76px;
            height: 31px;
            border: 0;
        }
        * html a:hover
        {
            visibility: visible;
        }
        .button a:hover img
        {
            visibility: hidden;
        }
        .button a:hover span
        {
            visibility: visible;
        }
        .button span
        {
            visibility: hidden;
            padding-right: 0px;
            padding-left: 0px;
            left: 0px;
            padding-bottom: 0px;
            margin: 0px;
            cursor: pointer;
            padding-top: 0px;
            position: absolute;
            width: 76px;
            height: 31px;
            text-align: center;
            background-image: url('Images/delete.gif');
            background-repeat: no-repeat;
        }
    </style>
    <table class="TableStyle" style="width: 800px;">
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
                Category
            </td>
            <td>
                <asp:DropDownList ID="DropDownSkillCategory" runat="server" Width="200px" DataSourceID="ObjectDataSourceCategory"
                    DataTextField="CategoryName" DataValueField="SkillCategoryId" AppendDataBoundItems="true"
                    AutoPostBack="true">
                    <asp:ListItem Value="0" Selected="True">Select</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*"
                    ControlToValidate="DropDownSkillCategory" Operator="NotEqual" ValueToCompare="0"></asp:CompareValidator>
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
                Skill
            </td>
            <td>
                <asp:DropDownList ID="DropDownSkill" runat="server" Width="200px" DataSourceID="ObjectDataSourceSkill"
                    DataTextField="SkillName" DataValueField="SkillId">
                </asp:DropDownList>
                &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="*"
                    ControlToValidate="DropDownSkill" Operator="NotEqual" ValueToCompare="Select"></asp:CompareValidator>
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
                Proficency
            </td>
            <td>
                <asp:DropDownList ID="DrpDwnLstProficency" runat="server">
                    <asp:ListItem Selected="True" Value="" Text="Select" ></asp:ListItem>
                    <asp:ListItem Text="Beginner" Value="Beginner"></asp:ListItem>
                    <asp:ListItem Text="Intermediate" Value="Intermediate"></asp:ListItem>
                    <asp:ListItem Text="Expert" Value="Expert"></asp:ListItem>
                </asp:DropDownList>
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
                Years
            </td>
            <td>
                <asp:DropDownList ID="DrpDwnYears" runat="server">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                    <asp:ListItem Text="<10" Value="10"></asp:ListItem>
                </asp:DropDownList>
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
                Project URL
            </td>
            <td>
                <asp:TextBox ID="TxtProjectUrl" runat="server" Width="200px"></asp:TextBox>
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
                <asp:Button ID="BtnSave" runat="server" Text="Save" Width="85px" OnClick="BtnSave_Click" />
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
                <asp:Label ID="LblAlreadyAdded" runat="server" Font-Bold="True" ForeColor="Red" Visible="False">Already added</asp:Label>
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
            <td colspan="3">
                <asp:GridView ID="GridViewProviderSkill" runat="server" CellPadding="0" ForeColor="#333333"
                    Width="100%" AutoGenerateColumns="False">
                    <EmptyDataTemplate>
                        No Skills Added
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:TemplateField HeaderText="Skill Name">
                            <ItemTemplate>
                                <asp:Label ID="LblSkillName" runat="server" Text='<%# Eval("SkillName")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Category">
                            <ItemTemplate>
                                <asp:Label ID="LblCategoryName" runat="server" Text='<%# Eval("CategoryName")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Proficency">
                            <ItemTemplate>
                                <asp:Label ID="LblProficency" runat="server" Text='<%# Eval("Proficency")%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Years">
                            <ItemTemplate>
                                <asp:Label ID="LblYears" runat="server" Text='<%# Eval("Years") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Project URL">
                            <ItemTemplate>
                                <asp:Label ID="LblProjectURL" runat="server" Text='<%# Eval("ProjectURL") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="">
                            <ItemTemplate>
                            <%--<asp:ImageButton ID="LinkEditProviderSkill" ImageUrl="~/Images/edit_button.gif" 
                                    PostBackUrl='<%# Eval("SkillId", "~/Provider/Skill/DeleteProviderSkill.aspx?SkillId="+"{0}")%>'
                                    runat="server" />--%>
                                <asp:ImageButton ID="LinkDeleteProviderSkill" ImageUrl="~/Images/delete.gif"
                                    PostBackUrl='<%# Eval("SkillId", "~/Provider/Skill/DeleteProviderSkill.aspx?SkillId="+"{0}")%>'
                                    runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="20px" />
                        </asp:TemplateField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <HeaderStyle BackColor="#546E96" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:GridView>
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
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="ObjectDataSourceCategory" runat="server" SelectMethod="GetAllSkillCategory"
        TypeName="SkillCategoryBL"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSourceSkill" runat="server" SelectMethod="GetSkillByCategory"
        TypeName="ProviderSkillBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownSkillCategory" Name="SkillCategoryId" PropertyName="SelectedValue"
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>
