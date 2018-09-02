using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Introduction : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId=0;
    private ProviderDTO provider;
    private ProviderBL providerbl;

    protected void Page_Load(object sender, EventArgs e)
    {
       // System.Diagnostics.Debugger.Break();
        GetCookie();

        if (!IsPostBack)
        {
            providerbl = new ProviderBL();
            provider = providerbl.GetProviderIntroductionById(ProviderId);

            TxtFirstName.Text = provider.FirstName;
            TxtLastName.Text = provider.LastName;
            TxtMiddleName.Text = provider.MiddleName;
            TxtHaves.Value = provider.Haves;
            TxtWants.Value = provider.Wants;
            TxtOverView.Value = provider.OverView;
            DListCountry.SelectedValue = provider.Country;

        }
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        provider = new ProviderDTO();
        providerbl = new ProviderBL();

        provider.ProviderId = ProviderId;
        provider.FirstName = TxtFirstName.Text;
        provider.LastName = TxtLastName.Text;
        provider.MiddleName = TxtMiddleName.Text;
        provider.Haves = TxtHaves.Value;
        provider.Wants = TxtWants.Value;
        provider.OverView = TxtOverView.Value;
        provider.Country = DListCountry.SelectedItem.Value.ToString();
        providerbl.UpdateProviderIntroducation(provider);
        Response.Redirect("~/Provider/ProfilePage.aspx");

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