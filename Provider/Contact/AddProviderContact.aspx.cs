using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Contact_AddProviderContact : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private ProviderDTO provider;
    private ProviderBL providerbl;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();
        if (!IsPostBack)
        {
            //System.Diagnostics.Debugger.Break();
            providerbl = new ProviderBL();
            provider = providerbl.GetProviderContactById(ProviderId);

            TxtAddress1.Text = provider.Address1;
            TxtAddress2.Text = provider.Address2;
            TxtPhone.Text = provider.Phone;
            TxtMobile.Text = provider.Mobile;
            TxtFax.Text = provider.Fax ;
            TxtEmail.Text = provider.Email;
            TxtWebsite.Text = provider.Website;

        }
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        provider = new ProviderDTO();
        provider.ProviderId = ProviderId;
        provider.Address1 = TxtAddress1.Text;
        provider.Address2 = TxtAddress2.Text;
        //provider.Country = DListCountry.SelectedItem.Text;
        provider.Phone = TxtPhone.Text;
        provider.Mobile = TxtMobile.Text;
        provider.Fax = TxtFax.Text;
        provider.Email = TxtEmail.Text;
        provider.Website = TxtWebsite.Text;

        providerbl = new ProviderBL();
        providerbl.UpdateProviderContact(provider);

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