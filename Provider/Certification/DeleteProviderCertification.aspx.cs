using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Certification_DeleteProviderCertification : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderCertificationDTO ProviderCertification;
    private ProviderCertificationBL ProviderCertificationbl;
    private long CertificationId = 0;
    private long ProviderId = 0;
    private long rowsaffected = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();

        if (!IsPostBack)
        {

            CertificationId = Convert.ToInt64(Request.QueryString["CertificationId"]);
            ProviderCertificationbl = new ProviderCertificationBL();
            rowsaffected = ProviderCertificationbl.DeleteProviderCertification(ProviderId, CertificationId);
            Response.Redirect("~/Provider/ProfilePage.aspx");
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
}