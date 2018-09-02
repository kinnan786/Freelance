using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Certification_AddProviderCertification : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderCertificationDTO ProviderCertification;
    private ProviderCertificationBL ProviderCertificationbl;
    private long CertificationId = 0;
    private long ProviderId = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
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
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ProviderCertification = new ProviderCertificationDTO();

        ProviderCertification.ProviderId = ProviderId;
        ProviderCertification.CertificationName = TxtCertificationName.Text.ToString();
        if (TxtPercentage.Text != null && TxtPercentage.Text != "")
        {
            ProviderCertification.Percentage = Convert.ToInt16(TxtPercentage.Text);
        }

        if ( Convert.ToInt32(DropDownYears.SelectedItem.Value) != 0)
        {
            ProviderCertification.YearCompleted = DropDownYears.SelectedItem.Value;
        }

        ProviderCertificationbl = new ProviderCertificationBL();
        CertificationId = ProviderCertificationbl.AddProviderCertification(ProviderCertification);
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