using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProfileMasterPage : System.Web.UI.MasterPage
{
    HttpCookie cookie;
    private long providerid = 0;
    private string userName ="";
    private string password ="";

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public long ProviderId
    {
        get { return providerid; }
        set { providerid = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            providerid = Convert.ToInt64(cookie["ProviderId"]);
            userName = cookie["UserName"].ToString();
            password = cookie["Password"].ToString();
        }
    }
}
