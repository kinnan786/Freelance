using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Provider_RegisterProvider : System.Web.UI.Page
{

    private HttpCookie cookie;
    private ProviderDTO provider;
    private ProviderBL providerbl;
    private long providerid = 0;
    private HtmlMeta keyword;
    private HtmlTitle title;
    private Emails email;

    protected void Page_Load(object sender, EventArgs e)
    {
        SetMetaTags();

        //UpdateMasterPage();
    }

    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        provider = new ProviderDTO();
        email = new Emails();

        provider.FirstName =  TxtFirstName.Text.ToString();
        provider.LastName = TxtLastName.Text.ToString();
        provider.Country = DListCountry.SelectedItem.Text;
        provider.Email = TxtEmail.Text.ToString();

        providerbl = new ProviderBL();
        providerid = providerbl.InsertProvider(provider);

        email.SendLoginAuthenticationEmail(TxtEmail.Text.ToString());

        Response.Redirect("~/Default.aspx");
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            providerid = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void SetMetaTags()
    {
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        keyword.Content = "Offshore outsourcing, Freelancers, India, Russia, Ukraine, php Programmers, Coders, Developers, Writers, Web Designers, Website Design, Technical Writers";
        title.Text = "Register an Account - Work4Sale";
    }




}