using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Project_EditProviderProject : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProjectId = 0;
    private long ProviderId = 0;
    private ProjectDTO project;
    private ProjectBL projectbl;
    private BidDTO bid;
    private BidBL bidbl;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();

        GetCookie();
        project = new ProjectDTO();
        projectbl = new ProjectBL();
        bid = new BidDTO();
        bidbl = new BidBL();



        if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
        {
            ProjectId = Convert.ToInt64(Request.QueryString["ProjectId"]);
            project = projectbl.SelectProjectById(ProjectId);

            if (ProviderId == project.ProviderId)
            {
                BtnBid.Text = "Edit";
            }
            else
            {
                BtnBid.Text = "Bid";
            }
            LinkJobPostedBy.Text = project.ProviderName;
            LblCategory.Text = project.ProjectCategory;
            LblBidOpenTill.Text = project.BidOpenTill.ToString();
            LblDescription.Text = project.Description;
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
                LblNoBids.Visible = true;
            }
        }
    }

    protected void BtcAcceptBid_Click(object sender, EventArgs e)
    {
        //Response.Redirect("~/Bid/ViewBid.aspx?BidId=" + );
    }

    protected void BtnBid_Click(object sender, EventArgs e)
    {
        if (ProviderId != 0)
        {
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

    protected void DataListBidOnProject_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        bid = (BidDTO)e.Item.DataItem;

        HyperLink LnkName = (HyperLink)e.Item.FindControl("LnkName");
        Label Name = (Label)e.Item.FindControl("Name");
        Label LblCountry = (Label)e.Item.FindControl("LblCountry");
        Label LblAmount = (Label)e.Item.FindControl("LblAmount");
        Label LblProviderSkill = (Label)e.Item.FindControl("LblProviderSkill");
        Label LblDescription = (Label)e.Item.FindControl("LblDescription");
        LinkButton LnkBtnViewtBid = (LinkButton)e.Item.FindControl("BtnViewtBid");

        LnkName.NavigateUrl = "~/Provider/ViewProfile.aspx?ProviderId=" + bid.ProviderId.ToString(); // bid.BidId.ToString();
        Name.Text = bid.ProviderName.ToString();
        LblCountry.Text = bid.ProviderCountry.ToString();
        LblAmount.Text ="<b>Bid Amount:</b> $ " +bid.Amount.ToString();
        LblProviderSkill.Text = bid.ProviderSkill.ToString();
        LnkBtnViewtBid.PostBackUrl = "~/Bid/ViewBid.aspx?BidId="+ bid.BidId.ToString();
        LblDescription.Text = bid.Description.ToString();
    }
}