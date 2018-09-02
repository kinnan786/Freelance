using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Register : System.Web.UI.Page
{
    private ProviderBL providerbl;
    private ProviderDTO provider;
    private long providerId;
    private HttpCookie cookie;
    private HtmlMeta keyword;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
       // System.Diagnostics.Debugger.Break();
    }

    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            provider = new ProviderDTO();
            providerbl = new ProviderBL();

            provider.FirstName = TxtFirstName.Text.ToString();
            provider.LastName = TxtLastName.Text.ToString();
            provider.UserName = TxtUserName.Text.ToString();
            provider.Email = TxtUserName.Text.ToString();
            provider.Password = TxtPassword.Text.ToString();
            provider.Country = DdlCountry.SelectedItem.Text;

            providerId = providerbl.InsertProvider(provider);

            if (providerId != -1)
            {
                cookie = new HttpCookie("Freelancing");
                cookie.Values.Add("ProviderId", providerId.ToString());
                cookie.Values.Add("UserName", provider.UserName);
                cookie.Values.Add("Password", provider.Password);
                Response.SetCookie(cookie);
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                LblNameExist.Visible = true;
            }
        }

    }

    protected void SetMetaTags(ProviderDTO providerseo)
    {
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        keyword.Content = "Offshore outsourcing, Freelancers, India, Russia, Ukraine, php Programmers, Coders, Developers, Writers, Web Designers, Website Design, Technical Writers";
        title.Text = "Register an Account - Work4Sale";


    }




}