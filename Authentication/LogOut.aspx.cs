using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Authentication_LogOut : System.Web.UI.Page
{
    HttpCookie cookie;
    private long ProviderId=0;

    protected void Page_Load(object sender, EventArgs e)
    {
        DeleteCookie();
    }

    private void DeleteCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];
        cookie.Expires = DateTime.Now;
        Response.SetCookie(cookie);
        Response.Redirect("~/Default.aspx");
    }
}