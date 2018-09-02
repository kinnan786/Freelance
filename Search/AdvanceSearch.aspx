<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="AdvanceSearch.aspx.cs" Inherits="Search_AdvanceSearch" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" runat="Server">
    <div class="gray_container">
    
    <table width="100%">
        <tr>
            <td style="width:150px;">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width:100px;">&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TxtSearch" Width="250px" runat="server"></asp:TextBox>
             </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
             </td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
                <asp:RadioButton ID="RaBtnProject" runat="server" Text="Project" Checked="true" GroupName="SearchBy" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td>&nbsp;</td>
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
            <td>Categories</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
            <table width="100%">
                <tr>
                    <td style="width:20px;"></td>
                    <td><asp:RadioButtonList ID="RadioButtonListCat" AppendDataBoundItems = "true"  runat="server" >
                <asp:ListItem Selected="True" Value="ALL" >All</asp:ListItem>
                </asp:RadioButtonList></td>
                </tr>
            </table>
                
             </td>
            <td>&nbsp;</td>
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
            <td>Job type</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton 
                    ID="RdbtnJobType" runat="server" Checked="True" 
                    Text="Fixed Price Job" />
             </td>
            <td>&nbsp;</td>
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
            <td>Posted Since</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:RadioButton ID="RdBtn0" runat="server"  Text="All" GroupName="Timeframe" Checked="true" /><br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:RadioButton ID="RdBtn1" runat="server"  Text="Last 24 Hours" GroupName="Timeframe"  /><br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:RadioButton ID="RdBtn2" runat="server"  Text="Last 3 Days" GroupName="Timeframe"/><br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:RadioButton ID="RdBtn3" runat="server"  Text="Last 7 Days" GroupName="Timeframe"/><br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:RadioButton ID="RdBtn4" runat="server"  Text="Last 14 Days" GroupName="Timeframe"/><br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:RadioButton ID="RdBtn5" runat="server"  Text="Last 30 Days" GroupName="Timeframe"/>

             </td>
            <td>&nbsp;</td>
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
            <td>Time Left</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn6" runat="server" Text="All" Checked="true" GroupName="TimeLeft"  /><br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn7" runat="server" Text="Less than 24 hours" GroupName="TimeLeft"/><br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn8" runat="server" Text="Less than 3 days Left" GroupName="TimeLeft"/><br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn9" runat="server" Text="Less than 7 days Left" GroupName="TimeLeft"/><br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn10" runat="server" Text="Less than 14 days Left" GroupName="TimeLeft"/><br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RdBtn11" runat="server" Text="Less than 30 days" GroupName="TimeLeft"/><br />

             </td>
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

    </div>
    
</asp:Content>
