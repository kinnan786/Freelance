using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Setting_ChangePassword : System.Web.UI.Page
{
    HttpCookie cookie;
    private long providerid = 0;
    private string userName;
    private string password;
    private ProviderBL providerbl;
    private ProviderDTO provider;

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
        
        provider = new ProviderDTO();
        providerbl = new ProviderBL();

    }

    protected void BtnChangePassword_Click(object sender, EventArgs e)
    {
        provider = new ProviderDTO();
        providerbl = new ProviderBL();
        bool passwordchanged = false;

        provider.ProviderId = Master.ProviderId;
        provider.Password = TxtOldPassword.Text;

        passwordchanged = providerbl.ChangePassword(provider, TxtNewPassword.Text);

        if(passwordchanged == true)
        {
            TxtNewPassword.Text = "";
            TxtOldPassword.Text = "";
            TxtRetypePassword.Text = "";
            LblPasswordChanged.Visible = true;
            LblPasswordChanged.Text = "Password Changed";
            LblPasswordChanged.ForeColor = System.Drawing.Color.Black;
        }
        else
        {
            LblPasswordChanged.Visible = true;
            LblPasswordChanged.Text ="Password Not Changed";
            LblPasswordChanged.ForeColor = System.Drawing.Color.Red;
        }

    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
            userName = cookie["UserName"].ToString();
        }

    }




}