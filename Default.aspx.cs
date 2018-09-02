using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Text;

public partial class Default : System.Web.UI.Page
{
    private List<ProjectDTO> projectdto;
    private ProjectBL projectbl;
    private StatisticsBL statisticsbl;
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
        projectbl = new ProjectBL();
        projectdto = new List<ProjectDTO>();

        statisticsbl = new StatisticsBL();

        projectdto = projectbl.SelectAllProject(1,15);

        string[] str = statisticsbl.GetWebStatistics();

        StringBuilder latestproject = new StringBuilder();
        latestproject.Append("<marquee behavior=scroll direction=up height=200px width=600px scrollamount=3 onmouseover=this.stop() onmouseout=this.start() class=gray_container><div style=text-align:left;>");
        latestproject.Append("<ul>");

        if (projectdto != null)
        {
            foreach (ProjectDTO project in projectdto)
            {
                latestproject.Append("<li ><a href=/Project/ViewProject.aspx?ProjectID=" + project.ProjectId.ToString() + " target=_top >" + project.ProjectTitle.ToString() + "</a><BR>by&nbsp;" + project.ProviderName.ToString() + "&nbsp;Posted on&nbsp;" + project.ProjectCreatedOn.ToString() + "&nbsp;</li>");
                latestproject.Append("<br/>");
            }
        }
         latestproject.Append("</ul>");
         latestproject.Append("</div></marquee>");
         lstProject.Text = latestproject.ToString();
         LnkTotalworkForce.Text = str[0].ToString();
         LnkTotalProjects.Text = str[1].ToString();
    }

    protected void SetMetaTags(ProjectDTO projects)
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        title.Text = " Outsource to Freelancers, IT Companies, Programmers, Web Designers from India, Russia, USA, and more ";
        description.Content = "WORK4SALE is a global marketplace that helps employers hire, manage, and pay remote freelancers or teams. It's free to post a job and hire from over 1 million top professionals.";
        keyword.Content = "Earn money, make money online, Work from Home, Post Projects";

    }

}