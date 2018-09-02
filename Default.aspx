<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterMainContent" runat="Server">
    <!-- start container -->
    <div id="container">
        <!-- start gray container -->
        <h1>
            Remote staffing for long-term work</h1>
        Hire, manage, and pay a distributed team as if everyone were in your office. guaranteed
        <div class="gray_container">
            <div class="box">
                <h1>
                    Where the world's top talent works online</h1>
                <!-- common box1 -->
                <div class="common_box">
                    <div class="imgbox">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Provider/SearchProvider.aspx">
                    <img src="Images/Workforce.jpg" alt="Banner" height="150px" width="280px" />
                        </asp:HyperLink>
                    </div>
                    <h3>
                        Talented Work Force</h3>
                    <p>
                        As the world's leading platform for online employment, Work4Sale helps businesses
                        hire and manage in the cloud. For businesses looking to staff-up a team on an hourly
                        or project basis, Work4Sale offers instant access to qualified professionals who
                        work online and provides the tools to hire, view work as it progresses and pay for
                        results</p>
                </div>
                <!-- common box1 -->
                <!-- common box2 -->
                <div class="common_box">
                    <div class="imgbox">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Project/ViewAllProject.aspx">
                <img src="images/release.jpg" alt="Banner" height="150px" width="280px" /></a></div>
                    </asp:HyperLink>
                    <h3>
                        Projects</h3>
                    <p>
                        If you are looking to jump-start a project, broaden your reach or just simply get
                        things done, you will find that Work4Sale is faster and more cost-effective than
                        job boards, staffing firms and traditional outsourcing. You name it and workforce
                        will deliver results, often with a flourish: from writing code, crafting a marketing
                        plan, designing your website, managing your day-to-day schedule and a thousand other
                        projects.
                    </p>
                </div>
                <!-- common box2 -->
                <!-- common box3 -->
                <div class="common_box">
                    <div class="imgbox">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Provider/SearchProvider.aspx">
                <img src="Images/it-contractors.jpg" alt="Banner" height="150px" width="280px" />
                        </asp:HyperLink>
                    </div>
                    <h3>
                        Employeer</h3>
                    <p>
                        If you have skills and talent and are seeking independent work online, Work4Sale
                        offers access to qualified clients, a virtual workplace and guaranteed pay for great
                        work. To help make delivering great results easier for you, Work4Sale offers a
                        suite of tools to help make your work life as efficient as possible. .</p>
                </div>
                <div class="common_box last">
                    <div class="imgbox">
                        <a href="#">
                            <img src="Images/Guarrentee.gif" alt="Banner" height="150px" width="280px" /></a></div>
                    <h3>
                        Guarantee</h3>
                    <p>
                        If you have skills and talent and are seeking independent work online, Work4Sale
                        offers access to qualified clients, a virtual workplace and guaranteed pay for great
                        work. To help make delivering great results easier for you, Work4Sale offers a
                        suite of tools to help make your work life as efficient as possible. .</p>
                </div>
                <div class="clear">
                </div>
                <!-- common box3 -->
            </div>
        </div>
        <!-- end gray container -->
        <!-- start white container -->
        <div class="white_container">
            <div class="box">
                <!-- common box1 -->
                <div class="common_box">
                    <h3>
                        Statistics</h3>
                    <p>
                        <b>Total WorkForce</b><br />
                          &nbsp; &nbsp; &nbsp;<asp:HyperLink ID="LnkTotalProjects" runat="server" Text="asdas"
                            NavigateUrl="~/Project/ViewAllProject.aspx"></asp:HyperLink>
                    </p>
                    <p>
                        <b>Total Projects</b><br />
                         &nbsp; &nbsp; &nbsp;<asp:HyperLink ID="LnkTotalworkForce" runat="server" Text="asd"
                            NavigateUrl="~/Provider/SearchProvider.aspx"></asp:HyperLink>
                     
                    </p>
                </div>
                <!-- common box1 -->
                <!-- common box2 -->
                <div class="common_box">
                    <h3>
                        What We Do</h3>
                    <p>
                        Work4Sale.com makes virtual hiring much safer than traditional hiring with a unique
                        combination of industry-leading money-back guarantees for employers.
                    </p>
                    <p>
                        It also makes the process much safer for workers than traditional consulting or
                        freelancing, with industry-leading payment guarantees.
                    </p>
                </div>
                <!-- common box2 -->
                <!-- common box3 -->
                </div>
                <div class="clear"></div>
                <h3>Latest Projects</h3>
<asp:Literal ID="lstProject" runat="server">

</asp:Literal>

                <!-- common box3 -->
            </div>
        </div>
        <!-- end white container -->
    </div>
    <!-- end container -->
</asp:Content>
