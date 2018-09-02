using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

public partial class Project_AddNewProject : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProjectId = 0;
    private long ProviderId = 0;
    private ProjectDTO project;
    private ProjectBL projectbl;
    private int LstSelectedIndex = -1;
    private CategoryBL category;

    protected void Page_Load(object sender, EventArgs e)
    {
        TxtOwnRangeRequiredFieldValidator.Enabled = false;
        TxtOwnRangeRequiredFieldValidator.Visible = false;

        TxtDescription.config.toolbar = new object[]
			{
				new object[] {"Clear", "Preview" },
				new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord" },
                new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
                new object[] { "Form", "Checkbox", "Radio", "TextField", "Textarea", "Select", "Button", "ImageButton", "HiddenField" },
                "/",
				new object[] { "Bold", "Italic", "Underline", "Strike", "-", "Subscript", "Superscript" },
				new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote" },
				new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
                new object[] { "BidiLtr", "BidiRtl" },
                new object[] { "Link", "Unlink", "Anchor" },
                new object[] { "Image", "Flash", "Table", "HorizontalRule", "Smiley", "SpecialChar", "PageBreak", "Iframe" },
                "/",
				new object[] { "Styles", "Format", "Font", "FontSize" },
				new object[] { "TextColor", "BGColor" },
				new object[] { "Maximize", "ShowBlocks" }
			};

        //System.Diagnostics.Debugger.Break();
        if (!IsPostBack)
        {
            category = new CategoryBL();
            DateTime MaxDate = new DateTime();
            MaxDate = DateTime.Today.AddYears(1);

            ValidateData();

            DrpdlstCategory.DataSource = category.GetCategory();
            DrpdlstCategory.DataBind();

            RangeValidator1.MinimumValue = DateTime.Today.ToShortDateString();
            RangeValidator1.MaximumValue = DateTime.Today.AddYears(1).ToShortDateString();
            RangeValidator1.ErrorMessage = "Date should be between" + DateTime.Today.ToShortDateString() + " and " + DateTime.Today.AddYears(1).ToShortDateString();

            //Edit Flow
            

            if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
            {
                project = new ProjectDTO();
                projectbl = new ProjectBL();

                project = projectbl.SelectProjectById(Convert.ToInt64(Request.QueryString["ProjectId"]));

                TxtProjectName.Text = project.ProjectTitle;
                DdlBudget.SelectedValue = project.Budget;

                TxtDescription.Text = project.Description;
                TxtBidOpenTill.Text = Convert.ToDateTime(project.BidOpenTill).ToString("dd/MM/yyyy");

                DrpdlstCategory.Visible = false;
                DrpdlstSubcategory.Visible = false;
               // CmpvalCategory.Visible = false;
                //Cmpvalsubcategory.Visible = false;

                DrpdlstCategory.Enabled = false;
                DrpdlstSubcategory.Enabled = false;
               // CmpvalCategory.Enabled = false;
                //Cmpvalsubcategory.Enabled = false;

                LblCategory.Text = project.ProjectCategory;
                Lblsubcategory.Text = project.ProjectsubCategory;

                LblCategory.Visible = true;
                Lblsubcategory.Visible = true;

                string[] skills = Regex.Split(project.ProjectSkills.ToString(), ", ");
                foreach (string skill in skills)
                {
                    ListItem newskill = new ListItem(skill, skill);
                    ListBoxSkills.Items.Add(newskill);
                    ListBoxSkills.DataBind();
                }

                if (project.ProjectLocation.ToString().ToLower() != "No Preference".ToLower())
                {
                    RadioBtnPreferredlocation.Checked = true;
                    Page.RegisterStartupScript("ShowCountryKey", "<script>ShowCountry(true)</script>");
                    drplstCountry.SelectedValue = project.ProjectLocation.ToString();
                }
                else
                    RadioBtnPrefrence.Checked = true;

                if (project.Budget.Substring(0,1) == "$")
                {
                    DdlBudget.SelectedValue = "Enter My Own Ranges";
                    LblMyownRange.Visible = true;
                    TxtOwnRange.Visible = true;
                    TxtOwnRange.Enabled = true;
                    TxtOwnRange.Text = project.Budget.Replace("$", "");
                }
                else
                {
                    DdlBudget.SelectedValue = project.Budget;
                }

                if (project.PlannedStart == "Immediately")
                    RdBtnStartImmediately.Checked = true;
                else
                {
                    RdioBtnStartDate.Checked = true;
                    Page.RegisterStartupScript("StartDateTextBoxKey", "<script>ShowStartDateTextBox(true)</script>");
                    TxtStartDate.Text = Convert.ToDateTime(project.ProjectCreatedOn).ToString("dd/MM/yyyy");
                }
                RadioBtnPrefrence.Attributes.Add("onClick", "   (false)");
                RadioBtnPreferredlocation.Attributes.Add("onClick", "ShowCountry(true)");
                RdBtnStartImmediately.Attributes.Add("onClick", "ShowStartDateTextBox(false)");
                RdioBtnStartDate.Attributes.Add("onClick", "ShowStartDateTextBox(true)");
            }
            else
            {
                RadioBtnPrefrence.Attributes.Add("onClick", "ShowCountry(false)");
                RadioBtnPreferredlocation.Attributes.Add("onClick", "ShowCountry(true)");
                RdBtnStartImmediately.Attributes.Add("onClick", "ShowStartDateTextBox(false)");
                RdioBtnStartDate.Attributes.Add("onClick", "ShowStartDateTextBox(true)");
                DrpdlstSubcategory.SelectedIndex = 0;
            }
        }
    }

    protected void BtnPost_Click(object sender, EventArgs e)
    {
            GetCookie();

            project = new ProjectDTO();
            project.ProviderId = ProviderId;
            project.ProjectTitle = TxtProjectName.Text;
            project.Description = TxtDescription.Text;
            project.BidOpenTill = Convert.ToDateTime(TxtBidOpenTill.Text.ToString());

            if (DdlBudget.SelectedValue.ToString() != "Enter My Own Ranges")
            {
                project.Budget = DdlBudget.SelectedValue;
            }
            else
            {
                project.Budget = "$" + TxtOwnRange.Text.ToString();
            }

            if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
            {
                project.ProjectCategory = LblCategory.Text.ToString();
                project.ProjectsubCategory = Lblsubcategory.Text.ToString();

            }
            else
            {
                project.ProjectCategory = DrpdlstCategory.SelectedItem.Text.ToString();
                project.ProjectsubCategory = DrpdlstSubcategory.SelectedItem.Text.ToString(); 
            }

            for (int i = 0; i < ListBoxSkills.Items.Count; i++)
            {
                if (i == 0)
                    project.ProjectSkills += ListBoxSkills.Items[i].Text.ToString();
                else
                    project.ProjectSkills += ", " + ListBoxSkills.Items[i].Text.ToString();
            }

            if (RadioBtnPrefrence.Checked)
                project.ProjectLocation = "No Preference";
            else
            {
                if (drplstCountry.SelectedIndex != 0)
                    project.ProjectLocation = drplstCountry.SelectedItem.Text.ToString();
                else
                    project.ProjectLocation = "No Preference";
            }

            if (RdBtnStartImmediately.Checked)
            {
                project.PlannedStart = "Immediately";
                project.ProjectCreatedOn = DateTime.Now;
            }
            else
            {
                project.ProjectCreatedOn = Convert.ToDateTime("01/01/2010");
            }

            Session["ProjectDTO"] = project;
        if (Request.QueryString["ProjectId"] != null && Request.QueryString["ProjectId"] != "")
           Response.Redirect("~/Project/ConfirmProject.aspx" + "?ProjectId=" + Request.QueryString["ProjectId"]);
        else
           Response.Redirect("~/Project/ConfirmProject.aspx");

    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }
    }

    protected void BtnAddskill_Click(object sender, EventArgs e)
    {
        if (ListBoxSkills.Items.Count < 5 && TxtSkill.Text != "")
        {
            ListItem olditem = new ListItem();
            olditem = null;
            olditem = ListBoxSkills.Items.FindByText(TxtSkill.Text.ToString());

            if (olditem == null)
            {
                ListItem newitem = new ListItem(TxtSkill.Text.ToString(), TxtSkill.ToString());
                ListBoxSkills.Items.Add(newitem);
                ListBoxSkills.DataBind();
            }
            TxtSkill.Text = "";
        }
    }

    protected void BtnRemoveSkill_Click(object sender, EventArgs e)
    {
        if (ListBoxSkills.Items.Count >= 0 && ListBoxSkills.SelectedIndex >= 0)
        {
            ListBoxSkills.Items.RemoveAt(Convert.ToInt16(ListBoxSkills.SelectedIndex));
        }
    }

    protected void DllCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BtnAddskill.Enabled = true;
    }

    protected void DrpdlstCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        category = new CategoryBL();
        DrpdlstSubcategory.DataSource = category.GetSubCategory(Convert.ToInt32(DrpdlstCategory.SelectedItem.Value));
        DrpdlstSubcategory.DataBind();



        //if (DrpdlstCategory.SelectedItem.Value.ToString() == "Web Development")
        //{
        //    DrpdlstCategory.SelectedIndex = 1;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Web Design", "Web Design"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Web Programming", "Web Programming"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Ecommerce", "Ecommerce"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("UI Design", "UI Design"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Website QA", "Website QA"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Website Project Management", "Website Project Management"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Web Development", "Other - Web Development"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Software Development")
        //{
        //    DrpdlstCategory.SelectedIndex = 2;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Desktop Applications", "Desktop Applications"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Game Development", "Game Development "));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Scripts & Utilities", "Scripts & Utilities"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Software Plug-ins ", "Software Plug-ins "));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Mobile Apps", "Website QA"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Software QA", "Software QA"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Software Development", "Other - Software Development"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Networking & Information Systems")
        //{
        //    DrpdlstCategory.SelectedIndex = 3;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Network Administration", "Network Administration"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("DBA - Database Administration", "DBA - Database Administration"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Server Administration", "Server Administration"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("ERP / CRM Implementation", "ERP / CRM Implementation"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Networking & Information Systems", "Other - Networking & Information Systems"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Writing & Translation")
        //{
        //    DrpdlstCategory.SelectedIndex = 4;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Technical Writing", "Technical Writing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Website Content", "Website Content"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Blog & Article Writing", "Blog & Article Writing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Copywriting", "Copywriting"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Translation", "Translation"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Creative Writing", "Creative Writing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Writing & Translation", "Other - Writing & Translation"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Administrative Support")
        //{
        //    DrpdlstCategory.SelectedIndex = 5;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Data Entry", "Data Entry"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Personal Assistant", "Personal Assistant"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Web Research", "Web Research"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Transcription", "Transcription"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Administrative Support", "Other - Administrative Support"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Design & Multimedia")
        //{
        //    DrpdlstCategory.SelectedIndex = 6;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Graphic Design", "Graphic Design"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Logo Design", "Logo Design"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Illustration", "Illustration"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Print Design", "Print Design"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("3D Modeling & CAD", "3D Modeling & CAD"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Audio Production", "Audio Production"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Video Production", "Video Production"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Animation", "Animation"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Presentations", "Presentations"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Design & Multimedia", "Other - Design & Multimedia"));

        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "Sales & Marketing")
        //{
        //    DrpdlstCategory.SelectedIndex = 7;
        //    DrpdlstSubcategory.Items.Clear();
        //    DrpdlstSubcategory.Items.Add(new ListItem("Advertising", "Advertising"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Email Marketing", "Email Marketing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("SEO - Search Engine Optimization", "SEO - Search Engine Optimization"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("SEM - Search Engine Marketing", "SEM - Search Engine Marketing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("SMM - Social Media Marketing", "SMM - Social Media Marketing"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Telemarketing & Telesales", "Telemarketing & Telesales"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Market Research & Surveys", "Market Research & Surveys"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Sales & Lead Generation", "Sales & Lead Generation"));
        //    DrpdlstSubcategory.Items.Add(new ListItem("Other - Sales & Marketing", "Other - Sales & Marketing"));
        //}
        //else if (DrpdlstCategory.SelectedItem.Value.ToString() == "--- Select Category ---")
        //{
        //    DrpdlstCategory.SelectedIndex = 1;
        //    DrpdlstSubcategory.Items.Clear();
        //}






    }

    protected void RadioBtnPrefrence_CheckedChanged(object sender, EventArgs e)
    {
        //TblCountry.Visible = false;
    }

    protected void RadioBtnPreferredlocation_CheckedChanged(object sender, EventArgs e)
    {
        //TblCountry.Visible = true;
    }

    protected void DdlBudget_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DdlBudget.SelectedValue.ToString() == "Enter My Own Ranges".ToString())
        {
            TxtOwnRange.Visible = true;
            TxtOwnRange.Enabled = true;
            LblMyownRange.Visible = true;
            TxtOwnRangeRequiredFieldValidator.Enabled = true;
            TxtOwnRangeRequiredFieldValidator.Visible = true;
        }
        else
        {
            TxtOwnRange.Visible = false;
            TxtOwnRange.Enabled = false;
            LblMyownRange.Visible = false;
            TxtOwnRangeRequiredFieldValidator.Enabled = false;
            TxtOwnRangeRequiredFieldValidator.Visible = false;
        }
    }

    protected void ListBoxSkills_SelectedIndexChanged(object sender, EventArgs e)
    {
        LstSelectedIndex = ListBoxSkills.SelectedIndex;
        TxtOwnRangeRequiredFieldValidator.Enabled = true;
        TxtOwnRangeRequiredFieldValidator.Visible = true;
    }

    protected bool ValidateData()
    {
        if (drplstCountry.SelectedIndex != 10 && TxtOwnRange.Text != "")
        {

            return false;
        }

        if (drplstCountry.SelectedIndex != 10 && TxtOwnRange.Text != "")
        {

            return false;
        }

        if (drplstCountry.SelectedIndex != 10 && TxtOwnRange.Text != "")
        {

            return false;
        }


        return true;
    }
}