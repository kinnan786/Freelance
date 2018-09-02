using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WorkSpace_ProviderWorkspace : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long providerid = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();
       
    }


    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            providerid = Convert.ToInt64(cookie["ProviderId"]);
        }

    }
}