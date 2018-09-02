using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Provider_SearchProvider : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private ProviderDTO provider;
    private ProviderBL providerbl;
    private List<ProviderDTO> providers;
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;


    #region Private Properties
    private int CurrentPage
    {
        get
        {
            object objPage = ViewState["_CurrentPage"];
            int _CurrentPage = 1;
            if (objPage == null)
            {
                _CurrentPage = 1;
            }
            else
            {
                _CurrentPage = (int)objPage;
            }
            return _CurrentPage;
        }
        set { ViewState["_CurrentPage"] = value; }
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindItemsList();
            SetMetaTags();
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Provider/SearchProvider.aspx?SearchQuery=" + TxtSearchworkers.Text.ToString());
    }

    private void BindItemsList()
    {
        ViewState["TotalPages"] = "";

        providerbl = new ProviderBL();
        providers = new List<ProviderDTO>();

        providers = providerbl.SelectAllProvider(CurrentPage, 10);

        ViewState["TotalPages"] = providers[1].TotalPage.ToString();
        DataListProvider.DataSource = providers;
        DataListProvider.DataBind();

        this.lblPageInfo.Text = "Page " + (CurrentPage) + " of " + providers[1].TotalPage.ToString();

        if (CurrentPage - 1 == 0)
            lbtnPrevious.Enabled = false;
        else
            lbtnPrevious.Enabled = true;

        if (CurrentPage == Convert.ToInt32(ViewState["TotalPages"]))
            lbtnNext.Enabled = false;
        else
            lbtnNext.Enabled = true;

        if (CurrentPage == 1)
            lbtnFirst.Enabled = false;
        else
            lbtnFirst.Enabled = true;

        if (CurrentPage == Convert.ToInt32(ViewState["TotalPages"]))
            lbtnLast.Enabled = false;
        else
            lbtnLast.Enabled = true;

    }

    protected void lbtnNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        this.BindItemsList();
    }
    protected void lbtnPrevious_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        this.BindItemsList();
    }

    protected void lbtnLast_Click(object sender, EventArgs e)
    {
        CurrentPage = (Convert.ToInt32(ViewState["TotalPages"]));
        this.BindItemsList();
    }

    protected void lbtnFirst_Click(object sender, EventArgs e)
    {
        CurrentPage = 1;
        this.BindItemsList();
    }


    protected void DataListProvider_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        provider = (ProviderDTO)e.Item.DataItem;

        HyperLink LnkName = (HyperLink)e.Item.FindControl("LnkName");
        Label FirstName = (Label)e.Item.FindControl("FirstName");
        Label LastName = (Label)e.Item.FindControl("LastName");
        Label LblCountry = (Label)e.Item.FindControl("LblCountry");
        Label LblOverView = (Label)e.Item.FindControl("LblOverView");
        Image imagename = (Image)e.Item.FindControl("Imglogo");

        LnkName.NavigateUrl = "~/Provider/ViewProfile.aspx?ProviderId="+ provider.ProviderId.ToString();
        FirstName.Text = provider.FirstName;
        LastName.Text = provider.LastName;
        LblCountry.Text = provider.Country;

        providerbl = new ProviderBL();
        if (providerbl.GetProviderImage(provider.ProviderId) != null)
            imagename.ImageUrl = "~/ShowImage.ashx?ProviderId=" + provider.ProviderId.ToString();
        else
            imagename.ImageUrl = "~/Images/nopicture.gif";

        short count;
        if (provider.OverView.Length > 400)
            count = 400;
        else
            count = Convert.ToInt16(provider.OverView.Length);

        LblOverView.Text = provider.OverView.Substring(0, count) +" ...";

     
    }

    protected void SetMetaTags()
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        description.Content = "Browse Profiles & Reviews of Engineers, Freelancers & Programmers - Work4Sale";
        keyword.Content = " Offshore outsourcing, Freelancers, India, Russia, Ukraine, php Programmers, Coders, Developers, Writers, Web Designers, Website Design, Technical Writers";
        title.Text = "Browse Profiles & Reviews of Engineers, Freelancers & Programmers - Work4Sale";
    }
}