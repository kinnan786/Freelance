using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

public partial class Project_ViewAllProject : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private long ProjectId = 0;
    private ProjectDTO project;
    private ProjectBL projectbl;
    private string categorys;
    private List<ProjectDTO> projects;
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;


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

    #endregion

    public string Categorys
    {
        get { return categorys; }
        set { categorys = value; }
    }
    private string jobtype;

    public string Jobtype
    {
        get { return jobtype; }
        set { jobtype = value; }
    }
    private string postedsince;

    public string Postedsince
    {
        get { return postedsince; }
        set { postedsince = value; }
    }
    private string timeLeft;

    public string TimeLeft
    {
        get { return timeLeft; }
        set { timeLeft = value; }
    }

    private string searchText;

    public string SearchText
    {
        get { return searchText; }
        set { searchText = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        title.Text = "Search Jobs & Work at Home on Largest Online Freelance Job Network - Work4Sale";
        description.Content = "Employers looking for freelancers to work from home on outsourced projects through our global jobs' employment platform. Post your resume or cv and get hired today.";
        keyword.Content = "search job, work from home, online jobs, outsourcing jobs, freelance online, freelancers ";



        if (!IsPostBack)
        {
            if (Request.QueryString.ToString() != "")
            {
                if (Request.QueryString["searchtext"].ToString() != "")
                {
                    SearchText = Request.QueryString["searchtext"].ToString();
                }

                if (Request.QueryString["Categories"].ToString() != "")
                {
                    Categorys = Request.QueryString["Categories"].ToString();
                }

                if (Request.QueryString["JobType"].ToString() != "")
                {
                    Jobtype = Request.QueryString["JobType"].ToString();
                }

                if (Request.QueryString["Postedsince"].ToString() != "")
                {
                    Postedsince = Request.QueryString["Postedsince"].ToString();
                }

                if (Request.QueryString["TimeLeft"].ToString() != "")
                {
                    TimeLeft = Request.QueryString["TimeLeft"].ToString();
                }

                projectbl = new ProjectBL();
                projects = new List<ProjectDTO>();
               
                projects = projectbl.SearchProjectBYQuery(SearchText,categorys,Jobtype,Postedsince,TimeLeft,"");

                if (projects == null)
                    LblNorecord.Visible = true;
                else
                {
                    DataListProject.DataSource = projects;
                    DataListProject.DataBind();
                }
            }
            else
            {
                BindItemsList();
            }
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
        projectlink.NavigateUrl = "~/Project/ViewProject.aspx?ProjectId=" + project.ProjectId.ToString();

        JobCategory.Text = project.ProjectCategory.ToString();
        Totalbids.Text = project.BidCount.ToString();
        Budget.Text = project.Budget.ToString();

        DateTime DateBidOpenTill = new DateTime();
        DateTime DateCreatedOn = new DateTime();
        
        DateCreatedOn = Convert.ToDateTime(project.ProjectCreatedOn.ToString());
        DateBidOpenTill = Convert.ToDateTime(project.BidOpenTill.ToString());

        TimeSpan TimespanCreatedOn;
        if( DateTime.Now > DateCreatedOn)
            TimespanCreatedOn = (DateTime.Now).Subtract(DateCreatedOn);
        else
            TimespanCreatedOn = (DateCreatedOn).Subtract(DateTime.Now);

        TimeSpan Timespanbidopentill;
        if (DateTime.Now > DateBidOpenTill)
            Timespanbidopentill = (DateTime.Now).Subtract(DateBidOpenTill);
        else
            Timespanbidopentill = (DateBidOpenTill).Subtract(DateTime.Now);

        if (TimespanCreatedOn.TotalSeconds <= 60)
            PostedOn.Text = ((int)TimespanCreatedOn.TotalSeconds).ToString() + " Seconds ago";
        else if (TimespanCreatedOn.TotalMinutes <= 60)
            PostedOn.Text = ((int)TimespanCreatedOn.TotalMinutes).ToString() + " Minutes ago";
        else if (TimespanCreatedOn.TotalHours <= 24)
            PostedOn.Text = ((int)TimespanCreatedOn.TotalHours).ToString() + " Hours ago";
        else if (TimespanCreatedOn.TotalDays <= 30)
            PostedOn.Text = ((int)TimespanCreatedOn.TotalDays).ToString() + " Days ago";
        else
            PostedOn.Text = DateCreatedOn.ToString("MM/dd/yyyy");
        
        if (Timespanbidopentill.TotalSeconds <= 60)
            BidOpenTill.Text = (Timespanbidopentill.TotalSeconds).ToString() + " Seconds Left";
        else if (Timespanbidopentill.TotalMinutes <= 60)
            BidOpenTill.Text = ((int)Timespanbidopentill.TotalMinutes).ToString() + " Minutes Left";
        else if (Timespanbidopentill.TotalHours <= 24)
            BidOpenTill.Text = ((int)Timespanbidopentill.TotalHours).ToString() + " Hours Left";
        else if (Timespanbidopentill.TotalDays <= 28)
            BidOpenTill.Text = ((int)Timespanbidopentill.TotalDays).ToString() + " Days Left";
        else
            BidOpenTill.Text = DateBidOpenTill.ToString("MM/dd/yyyy");

        if (project.Description.Length > 500)
            Description.Text = project.Description.Substring(0, 400).Trim().Replace("<br />"," ").ToString() + "...";
        else
            Description.Text = project.Description;

        skill.Text = project.ProjectSkills.ToString();
        Providername.Text = project.ProviderName.ToString();
    }

        public string TrimData(string ab, int a)
        {
            string subab = ab;
            if (subab.Length == 0) 
                return subab;
            subab = removeCharecters(subab);
            if (subab.Length <= a) 
                return subab;
            subab = subab.Substring(0, a);
            return subab;
        }

          public static string removeCharecters(string ab)
       {
           ab = ab.Replace(" ", "-").Replace("?", "").Replace(":", "").Replace(".", "").Replace("!", "").Replace("@", "").Replace("%", "").Replace("#", "").Replace("^", "").Replace(")", "-").Replace("(", "-").Replace("&", "").Replace("/", "-").Replace("*", "").Replace("$", "").Replace("{", "-").Replace("}", "-").Replace("[", "").Replace("]", "").Replace("~", "");
           return ab;
       }


    private void BindItemsList()
    {
        projectbl = new ProjectBL();
        projects = new List<ProjectDTO>();

        projects = projectbl.SelectAllProject(CurrentPage, 10);

        if (projects != null)
        {
            ViewState["TotalPages"] = projects[1].TotalPage.ToString();
            DataListProject.DataSource = projects;
            DataListProject.DataBind();

            this.lblPageInfo.Text = "Page " + (CurrentPage) + " of " + projects[1].TotalPage.ToString();

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

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}