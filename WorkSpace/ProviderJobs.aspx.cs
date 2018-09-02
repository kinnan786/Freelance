using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WorkSpace_ProviderJobs : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long providerid = 0;
    private ProjectDTO project;
    private ProjectBL projectbl;
    private List<ProjectDTO> projects;

    #region Private Properties
    private int CurrentPage
    {
        get
        {
            object objPage = ViewState["_CurrentPage"];
            int _CurrentPage = 1;
            if (objPage == null)
            {
                _CurrentPage = 1;
            }
            else
            {
                _CurrentPage = (int)objPage;
            }
            return _CurrentPage;
        }
        set { ViewState["_CurrentPage"] = value; }
    }

    private int TotalPages
    {
        get
        {
            object objPage = ViewState["TotalPages"];
            int _TotalPages;
            if (objPage == null)
            {
                _TotalPages = 0;
            }
            else
            {
                _TotalPages = (int)objPage;
            }
            return _TotalPages;
        }
        set { ViewState["TotalPages"] = value; }
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();
        if (!IsPostBack)
        {
            BindItemsList();
        }
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];
        if (cookie != null)
        {
            providerid = Convert.ToInt64(cookie["ProviderId"]);
        }
    }

    protected void DataListProject_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        project = (ProjectDTO)e.Item.DataItem;

        HyperLink projectlink = (HyperLink)e.Item.FindControl("LnkName");
        Label skill = (Label)e.Item.FindControl("LblSkill");
        Label JobCategory = (Label)e.Item.FindControl("LblJobCategory");
        Label Totalbids = (Label)e.Item.FindControl("LblTotalbids");
        Label Postedby = (Label)e.Item.FindControl("LblPostedby");
        Label Budget = (Label)e.Item.FindControl("LblBudget");
        Label BidOpenTill = (Label)e.Item.FindControl("LblBidOpenTill");
        Label PostedOn = (Label)e.Item.FindControl("LblPostedOn");
        Label Description = (Label)e.Item.FindControl("LblDescription");
        Label Providername = (Label)e.Item.FindControl("LblPostedby");

        projectlink.Text = project.ProjectTitle.ToString();
        projectlink.NavigateUrl = "~/Project/EditProviderProject.aspx?ProjectId=" + project.ProjectId.ToString();

        JobCategory.Text = project.ProjectCategory.ToString();
        Totalbids.Text = project.BidCount.ToString();
        Budget.Text = project.Budget.ToString();
        BidOpenTill.Text = Convert.ToDateTime(project.BidOpenTill).ToString("dd/MM/yyyy");
        PostedOn.Text = project.ProjectCreatedOn.ToString();
        Description.Text = project.Description.ToString();
        skill.Text = project.ProjectSkills.ToString();
        Providername.Text = project.ProviderName.ToString();
    }

    private void BindItemsList()
    {
        ViewState["TotalPages"] = "";
        projectbl = new ProjectBL();
        projects = new List<ProjectDTO>();
        GetCookie();

        projects = projectbl.SelectProjectByProviderId(providerid, CurrentPage, 10);
        if (projects != null)
        {
            ViewState["TotalPages"] = projects[0].TotalPage.ToString();
            DataListProject.DataSource = projects;
            DataListProject.DataBind();

            this.lblPageInfo.Text = "Page " + (CurrentPage) + " of " + projects[0].TotalPage.ToString();

            lbtnPrevious.Visible = true;
            lbtnNext.Visible = true;
            lbtnFirst.Visible = true;
            lbtnLast.Visible = true;

            if (CurrentPage - 1 == 0)
                lbtnPrevious.Enabled = false;
            else
                lbtnPrevious.Enabled = true;

            if (CurrentPage == Convert.ToInt32(ViewState["TotalPages"]))
                lbtnNext.Enabled = false;
            else
                lbtnNext.Enabled = true;

            if (CurrentPage == 1)
                lbtnFirst.Enabled = false;
            else
                lbtnFirst.Enabled = true;

            if (CurrentPage == Convert.ToInt32(ViewState["TotalPages"]))
                lbtnLast.Enabled = false;
            else
                lbtnLast.Enabled = true;
        }
    }

    protected void lbtnNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        this.BindItemsList();

    }
    protected void lbtnPrevious_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        this.BindItemsList();

    }

    protected void lbtnLast_Click(object sender, EventArgs e)
    {
        CurrentPage = (Convert.ToInt32(ViewState["TotalPages"]));
        this.BindItemsList();

    }
    protected void lbtnFirst_Click(object sender, EventArgs e)
    {
        CurrentPage = 1;
        this.BindItemsList();
    }
}