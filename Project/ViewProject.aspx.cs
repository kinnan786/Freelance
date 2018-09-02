using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Project_ViewProject : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProjectId = 0;
    private long ProviderId = 0;
    private ProjectDTO project;
    private ProjectBL projectbl;
    private BidDTO bid;
    private BidBL bidbl;
    private BidDTO biddto;
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();

        GetCookie();
        project = new ProjectDTO();
        projectbl = new ProjectBL();
        bid = new BidDTO();
        bidbl = new BidBL();
        biddto = new BidDTO();

        if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
        {
            ProjectId = Convert.ToInt64(Request.QueryString["ProjectId"]);
            project = projectbl.SelectProjectById(ProjectId);
            
            SetMetaTags(project);

            BtnBid.Text = "Bid";
    
            LinkJobPostedBy.Text = project.ProviderName;
            LblCategory.Text = project.ProjectCategory;
            LblBidOpenTill.Text = project.BidOpenTill.ToString();
            LblDescription.Text = project.Description.ToString();
            LblBudget.Text = project.Budget.ToString();
            LblLocation.Text = project.ProjectLocation.ToString();
            LblProjectName.Text = project.ProjectTitle;
            LblSkill.Text = project.ProjectSkills.ToString();
            LblPlannedStart.Text = project.PlannedStart;

            if (bidbl.SelectBidByJobId(ProjectId) != null)
            {
                DataListBidOnProject.Visible = true;
                LblNoBids.Visible = false;
                DataListBidOnProject.DataSource = bidbl.SelectBidByJobId(ProjectId);
                DataListBidOnProject.DataBind();
            }
            else
            {
                DataListBidOnProject.Visible = false;
                LblNoBids.Visible = true    ;
            }

            description.Content = project.ProjectTitle;
            keyword.Content = project.ProjectSkills.ToString();
        }
    }

    protected void BtnBid_Click(object sender, EventArgs e)
    {
        if (ProviderId != 0)
        {
            if (BtnBid.Text == "Bid")
            {
                Session["ProjectDTO"] = project;
                Response.Redirect("~/Bid/CreateBid.aspx?ProjectId=" + ProjectId);
            }
            else
                Response.Redirect("~/Project/AddNewProject.aspx?ProjectId=" + ProjectId);
        }
        else
        {
            Response.Redirect("~/Provider/RegisterProvider.aspx");
        }
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void ItemDataBound_DataListBidOnProject(object sender, DataListItemEventArgs e)
    {
        biddto = (BidDTO)e.Item.DataItem;

        HyperLink LnkName = (HyperLink)e.Item.FindControl("LnkName");
        Label Name = (Label)e.Item.FindControl("Name");
        Label LblCountry = (Label)e.Item.FindControl("LblCountry");
       // Label LblAmount = (Label)e.Item.FindControl("LblAmount");
        Label LblProviderSkill = (Label)e.Item.FindControl("LblProviderSkill");

        LnkName.NavigateUrl = "~/Provider/ViewProfile.aspx?ProviderId=" + biddto.ProviderId.ToString();
        Name.Text = biddto.ProviderName.ToString();
        LblCountry.Text = biddto.ProviderCountry.ToString();
       // LblAmount.Text = "<b>Bid Amount:</b> $ "+biddto.Amount.ToString();
        LblProviderSkill.Text = biddto.ProviderSkill.ToString();
    }

    protected void SetMetaTags(ProjectDTO projects)
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        title.Text = projects.ProjectTitle + "-" + projects.ProjectCategory + "- work4Sale";
        keyword.Content = projects.ProjectSkills.ToString() + "," + projects.ProjectCategory;

        if (project.Description.Length > 700)
            description.Content = projects.Description.Substring(0, 700).Trim().Replace("<br />", " ").ToString();
        else
            description.Content = projects.Description;
    }
}