using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Provider_ViewProfile : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderBL providerbl;
    private ProviderDTO provider;
    private ProviderEmploymentBL ProvideremploymentBL;
    private ProviderEducationBL ProviderEducationBl;
    private ProviderCertificationBL ProviderCertificationBl;
    private ProviderSkillBL ProviderSkillbl;
    private long ProviderId = 0;
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProviderId = Convert.ToInt64(Request.QueryString["Providerid"]);
        
        providerbl = new ProviderBL();
        if (providerbl.GetProviderImage(ProviderId) != null)
            Image1.ImageUrl = "~/ShowImage.ashx?ProviderId=" + ProviderId.ToString();
        else
            Image1.ImageUrl = "~/Images/nopicture.gif";

        if (!IsPostBack)
        {
            ProvideremploymentBL = new ProviderEmploymentBL();
            ProviderEducationBl = new ProviderEducationBL();
            ProviderCertificationBl = new ProviderCertificationBL();
            providerbl = new ProviderBL();
            ProviderSkillbl = new ProviderSkillBL();

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
            LblOverView.Text = provider.OverView;

            SetMetaTags(provider);
            //description.Content = provider.OverView.Substring(0, 100);

            provider = providerbl.GetProviderContactById(ProviderId);
            LblAddress1.Text = "Hidden";//provider.Address1;
            LblPhone.Text = "Hidden";//provider.Phone;
            LblEmail.Text = "Hidden";// provider.Email;

            keyword.Content = ProviderSkillbl.FunGetProviderSkills(ProviderId).ToString();

            DataListSkills.DataSource = ProviderSkillbl.GetProviderSkills(ProviderId);
            DataListSkills.DataBind();
        }
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void SetMetaTags(ProviderDTO providerseo)
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        description.Content = provider.OverView.ToString();
        keyword.Content = providerseo.FirstName.ToString() + " " + providerseo.MiddleName.ToString() + " " + providerseo.LastName.ToString() +", "+providerseo.ProviderSkills +", "+providerseo.Haves;
        title.Text = providerseo.FirstName.ToString()+" "+providerseo.MiddleName.ToString()+" "+providerseo.LastName.ToString()+ " - "+ providerseo.Haves.ToString()+" - Work4Sale";


    }

}