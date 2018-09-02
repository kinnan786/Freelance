using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_JobExperience_DeleteProviderJobExperience : System.Web.UI.Page
{

    private HttpCookie cookie;
    private ProviderEmploymentDTO ProviderEmployment;
    private ProviderEmploymentBL ProviderEmploymentbl;
    private long EmploymentId = 0;
    private long ProviderId = 0;
    private long rowsaffected = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();

        if (!IsPostBack)
        {
            EmploymentId = Convert.ToInt64(Request.QueryString["EmploymentId"]);
            ProviderEmploymentbl = new ProviderEmploymentBL();
            ProviderEmploymentbl.DeleteProviderEmployment(ProviderId, EmploymentId);
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