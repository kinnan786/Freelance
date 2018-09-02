using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Authentication_Login : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderDTO provider;
    private ProviderBL providerbl;
    private long providerid = 0;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Diagnostics.Debugger.Break();
        //UpdateMasterPage();

        SetMetaTags();
        cookie = Request.Cookies["Freelancing"];

        if (cookie == null)
        {
            LblAutentication.Visible = false;
        }

        if (!IsPostBack)
        {
            if (Request.QueryString["Logout"] != "" && Request.QueryString["Logout"] != null)
            {
                if (Convert.ToBoolean(Request.QueryString["Logout"].ToString()) == true)
                {
                    cookie = new HttpCookie("Freelancing");
                    cookie.Expires = DateTime.Now;
                     Response.Cookies.Set(cookie);
                }
            }
        }

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        
        providerbl = new ProviderBL();
        provider = new ProviderDTO();

        provider.Email = Convert.ToString(TxtEmail.Text);
        provider.Password =  Convert.ToString(TxtPassword.Text);
        providerid = providerbl.AuthenticateUser(provider);

        if (providerid == 0)
        {
            LblAutentication.Text = "Incorrect Username Or Password";
            LblAutentication.Visible = true;
        }
        else
        {
            cookie = new HttpCookie("Freelancing");
            cookie.Values.Add("ProviderId", providerid.ToString());
            cookie.Values.Add("UserName", provider.UserName);
            cookie.Values.Add("Password", provider.Password);
            Response.SetCookie(cookie);
            Response.Redirect("~/Default.aspx");
        }
    }

    protected void SetMetaTags()
    {
        title = (HtmlTitle)Master.FindControl("Title");
        title.Text = "Log In - Work4Sale";
    }
}