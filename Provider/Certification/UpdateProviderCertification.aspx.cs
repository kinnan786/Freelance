using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Certification_UpdateProviderCertification : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderCertificationDTO ProviderCertification;
    private ProviderCertificationBL ProviderCertificationbl;
    private long CertificationId = 0;
    private long ProviderId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();
        GetCookie();

        if (!IsPostBack)
        {
            for (int year = DateTime.Now.Year; year > (DateTime.Now.Year - 58); year--)
            {
                ListItem item = new ListItem(year.ToString(), year.ToString());
                DropDownYears.Items.Add(item);
            }
        
            CertificationId = Convert.ToInt64(Request.QueryString["CertificationId"]);

            ProviderCertificationbl = new ProviderCertificationBL();
            ProviderCertification = new ProviderCertificationDTO();

            ProviderCertification = ProviderCertificationbl.GetProviderCertificationByCertificationId(ProviderId, CertificationId);

            TxtCertificationName.Text = ProviderCertification.CertificationName;
            TxtPercentage.Text = ProviderCertification.Percentage.ToString();
            
            if (ProviderCertification.YearCompleted != "")
            {
                DropDownYears.Items.FindByValue(ProviderCertification.YearCompleted).Selected = true;
            }
            else
            {
                DropDownYears.Items.FindByValue("0").Selected = true;
            }
        }
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        CertificationId = Convert.ToInt64(Request.QueryString["CertificationId"]);
        ProviderCertification = new ProviderCertificationDTO();

        ProviderCertification.ProviderId = ProviderId;
        ProviderCertification.CertificationId = CertificationId;
        ProviderCertification.CertificationName = TxtCertificationName.Text.ToString();
        if (TxtPercentage.Text != null && TxtPercentage.Text != "")
        {
           ProviderCertification.Percentage = Convert.ToInt16(TxtPercentage.Text);
        }
        if (DropDownYears.SelectedItem.Value != 0.ToString())
        {
            ProviderCertification.YearCompleted = DropDownYears.SelectedItem.Value;
        }

        ProviderCertificationbl = new ProviderCertificationBL();
        ProviderCertificationbl.UpdateProviderCertification(ProviderCertification);
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