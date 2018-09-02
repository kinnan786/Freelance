using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search_AdvanceSearch : System.Web.UI.Page
{
    private List<CategoryDTO> category;
    private CategoryBL categorybl;
    private ProjectBL projectbl;
    private List<ProjectDTO> project;
    private string categorys;

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


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            category = new List<CategoryDTO>();
            categorybl = new CategoryBL();

            category = categorybl.GetCategory();
            

            foreach(CategoryDTO cat in categorybl.GetCategory())
                RadioButtonListCat.Items.Add(new ListItem(cat.CategoryName,cat.CategoryId.ToString()));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetCheckedValues();
        if(RaBtnProject.Checked == true)
        {
            string category = RadioButtonListCat.SelectedItem.Text.ToString();
            category = category.Replace("&", "and");
            Response.Redirect("~/Project/ViewAllProject.aspx?searchtext=" + TxtSearch.Text.ToString() + "&Categories=" + category + "&JobType=" + jobtype + "&Postedsince=" + Postedsince + "&TimeLeft=" + TimeLeft);
        }
        else
        {
             Response.Redirect("");
        }
    }

    protected void GetCheckedValues()
    {
        jobtype = RdbtnJobType.Text.ToString();
        jobtype = jobtype.Replace("&", "and");

        if(RdBtn0.Checked == true)
            Postedsince = RdBtn0.Text.ToString();
        else if (RdBtn1.Checked == true)
            Postedsince = RdBtn1.Text.ToString();
        else if (RdBtn2.Checked == true)
            Postedsince = RdBtn2.Text.ToString();
        else if (RdBtn3.Checked == true)
            Postedsince = RdBtn3.Text.ToString();
        else if (RdBtn4.Checked == true)
            Postedsince = RdBtn4.Text.ToString();
        else if (RdBtn5.Checked == true)
            Postedsince = RdBtn5.Text.ToString();

        if (RdBtn6.Checked == true)
            TimeLeft = RdBtn6.Text.ToString();
        else if (RdBtn7.Checked == true)
            TimeLeft = RdBtn7.Text.ToString();
        else if (RdBtn8.Checked == true)
            TimeLeft = RdBtn8.Text.ToString();
        else if (RdBtn9.Checked == true)
            TimeLeft = RdBtn9.Text.ToString();
        else if (RdBtn10.Checked == true)
            TimeLeft = RdBtn10.Text.ToString();
        else if (RdBtn11.Checked == true)
            TimeLeft = RdBtn11.Text.ToString();


    }
}