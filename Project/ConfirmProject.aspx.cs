using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Project_ConfirmProject : System.Web.UI.Page
{
    private ProjectDTO project;
    private ProjectBL projectbl;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();

        if (!IsPostBack)
        {
            project = (ProjectDTO)Session["ProjectDTO"];
            LblProjectName.Text = project.ProjectTitle;
            LblDescription.Text = project.Description;
            LblBudget.Text = project.Budget;
            LblCategory.Text = project.ProjectCategory;
            LblSubCategory.Text = project.ProjectsubCategory;
            LblBidOpenTill.Text = project.BidOpenTill.ToString();
            LblSkill.Text = project.ProjectSkills;
            Lbllocation.Text = project.ProjectLocation;
            LblBidOpenTill.Text = project.BidOpenTill.ToString();
        }
    }

    protected void BtnConfirmAndPost_Click(object sender, EventArgs e)
    {
        project = (ProjectDTO)Session["ProjectDTO"];
        projectbl = new ProjectBL();
        // Update Flow
        if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
        {
            project.ProjectId = Convert.ToInt64(Request.QueryString["ProjectId"]);
            projectbl.UpdateProject(project);
        }
        // insert flow
        else
        {
            projectbl.InsertProject(project);
        }
        Response.Redirect("~/WorkSpace/ProviderWorkSpace.aspx");

    }

    protected void Btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WorkSpace/AddNewProject.aspx");

    }
}