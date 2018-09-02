using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Education_UpdateProviderEducation : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private long Educationid = 0;
    private ProviderEducationBL ProviderEducationBl;
    private ProviderEducationDTO ProviderEducationdto;

    protected void Page_Load(object sender, EventArgs e)
    {
       
        GetCookie();
        if (!IsPostBack)
        {
            for (int year = DateTime.Now.Year; year > (DateTime.Now.Year - 58); year--)
            {
                ListItem item = new ListItem(year.ToString(), year.ToString());
                DropDownYears.Items.Add(item);
            }

            Educationid = Convert.ToInt64(Request.QueryString["EducationId"]);
            ProviderEducationdto = new ProviderEducationDTO();
            ProviderEducationBl = new ProviderEducationBL();

            ProviderEducationdto = ProviderEducationBl.GetProviderEducationByEducationId(ProviderId, Educationid);

            TxtDegreeTitle.Text = ProviderEducationdto.DegreeTitle;
            TxtInstitutionName.Text = ProviderEducationdto.InstitutionName;
            if (ProviderEducationdto.YearCompleted != "")
            {
                DropDownYears.Items.FindByValue(ProviderEducationdto.YearCompleted).Selected = true;
            }
            else
            {
                DropDownYears.Items.FindByValue("0").Selected = true;
            }
        }

    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        Educationid = Convert.ToInt64(Request.QueryString["EducationId"]);
        ProviderEducationdto = new ProviderEducationDTO();
        ProviderEducationBl = new ProviderEducationBL();

        ProviderEducationdto.ProviderId = ProviderId;
        ProviderEducationdto.EducationId = Educationid;
        ProviderEducationdto.InstitutionName = TxtInstitutionName.Text.ToString();
        ProviderEducationdto.DegreeTitle = TxtDegreeTitle.Text.ToString();
        if (DropDownYears.SelectedItem.Value != 0.ToString())
        {
            ProviderEducationdto.YearCompleted = DropDownYears.SelectedItem.Value;
        }
        ProviderEducationBl.UpdateProviderEducation(ProviderEducationdto);

        Response.Redirect("~/Provider/ProfilePage.aspx");
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }
}