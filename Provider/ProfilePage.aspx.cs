using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

public partial class Provider_ProfilePage : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderBL providerbl;
    private ProviderDTO provider;
    private ProviderEmploymentBL ProvideremploymentBL;
    private ProviderEducationBL ProviderEducationBl;
    private ProviderCertificationBL ProviderCertificationBl;
    private ProviderSkillBL ProviderSkillbl;
    private long ProviderId = 0;
    private byte[] image;


    protected void Page_Load(object sender, EventArgs e)
    {
        
        GetCookie();

        if (!IsPostBack)
        {
            ProvideremploymentBL = new ProviderEmploymentBL();
            ProviderEducationBl = new ProviderEducationBL();
            ProviderCertificationBl = new ProviderCertificationBL();
            providerbl = new ProviderBL();
            ProviderSkillbl = new ProviderSkillBL();
        }

            Image1.ImageUrl = "~/ShowImage.ashx?ProviderId=" + ProviderId.ToString();

            GridViewJobExperience.DataSource = ProvideremploymentBL.GetEmploymentByProviderId(ProviderId);
            GridViewJobExperience.DataBind();

            GridViewEducation.DataSource = ProviderEducationBl.GetProviderEducationByProviderId(ProviderId);
            GridViewEducation.DataBind();

            GridViewCertification.DataSource = ProviderCertificationBl.GetProviderCertification(ProviderId);
            GridViewCertification.DataBind();

            provider = providerbl.GetProviderIntroductionById(ProviderId);
            LblFirstName.Text = provider.FirstName.ToString();
            LblLastName.Text = provider.LastName.ToString();
            LblMiddleName.Text = provider.MiddleName.ToString();
            LblHave.Text = provider.Haves;
            Lblwants.Text = provider.Wants;
            LblOverView.Text =provider.OverView;

            provider = providerbl.GetProviderContactById(ProviderId);
            LblAddress1.Text = provider.Address1;
            LblPhone.Text = provider.Phone;
            LblEmail.Text = provider.Email;


            DataListSkills.DataSource = ProviderSkillbl.GetProviderSkills(ProviderId);
            DataListSkills.DataBind();

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