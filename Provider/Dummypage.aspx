<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dummypage.aspx.cs" Inherits="Provider_Dummypage" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"
   Width="100%" BorderColor="#336699" BorderStyle="Solid" BorderWidth="2px">
   
   <ItemTemplate>
      <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductName") %>' Font-Bold="True"
         Font-Size="10pt" ForeColor="#336699" Width="100%" />
      <br /> 
      <asp:Image ID="Image1" runat="server" 
         ImageUrl='<%# "GetImage.aspx?id=" + Eval("ProductID") %>' />
   </ItemTemplate>
   <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"  />
</asp:DataList>
    </div>
    </form>
</body>
</html>
