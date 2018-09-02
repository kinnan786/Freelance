using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Education_AddProviderEducation : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private ProviderEducationBL ProviderEducationBl;
    private ProviderEducationDTO ProviderEducationdto;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();
        if (!IsPostBack)
        {
            for (int year = DateTime.Now.Year; year > (DateTime.Now.Year - 58); year--)
            {
                ListItem item = new ListItem(year.ToString(), year.ToString());
                DropDownYears.Items.Add(item);
            }
        }
        GetCookie();
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ProviderEducationdto = new ProviderEducationDTO();
        ProviderEducationBl = new ProviderEducationBL();

        ProviderEducationdto.ProviderId = ProviderId;
        ProviderEducationdto.InstitutionName = TxtInstitutionName.Text.ToString();
        ProviderEducationdto.DegreeTitle = TxtDegreeTitle.Text.ToString();
        if (Convert.ToInt32(DropDownYears.SelectedItem.Value) != 0)
        {
            ProviderEducationdto.YearCompleted = DropDownYears.SelectedItem.Value;
        }
        ProviderEducationBl.AddProviderEducation(ProviderEducationdto);

        Response.Redirect("~/Provider/ProfilePage.aspx");
    }
}