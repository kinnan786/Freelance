using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Education_DeleteProviderEducation : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderEducationDTO ProviderEducation;
    private ProviderEducationBL ProviderEducationbl;
    private long EducationId = 0;
    private long ProviderId = 0;
    private long rowsaffected = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();

        if (!IsPostBack)
        {
            EducationId = Convert.ToInt64(Request.QueryString["EducationId"]);
            ProviderEducationbl = new ProviderEducationBL();
            ProviderEducationbl.DeleteProviderEducation(ProviderId, EducationId);
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