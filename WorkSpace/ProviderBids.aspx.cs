using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WorkSpace_ProviderBids : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long providerid = 0;
    private BidDTO bid;
    private BidBL bidbl;
    private List<BidDTO> bids;
    


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
        //System.Diagnostics.Debugger.Break();
       
        if (!IsPostBack)
        {
            BindItemsList();
        }
    }


    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            providerid = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    private void BindItemsList()
    {
        bidbl = new BidBL();
        bids = new List<BidDTO>();
        GetCookie();

        bids = bidbl.SelectBidByProviderId(providerid,CurrentPage, 10);

        if (bids != null)
        {
            ViewState["TotalPages"] = bids[0].TotalPage.ToString();
            DataListProviderBids.DataSource = bids;
            DataListProviderBids.DataBind();

            this.lblPageInfo.Text = "Page " + (CurrentPage) + " of " + bids[0].TotalPage.ToString();

            lbtnPrevious.Visible = true;
            lbtnNext.Visible = true;
            lbtnFirst.Visible = true;
            lbtnLast.Visible = true;

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

    protected void DataListProviderBids_OnItemDataBound(object sender, DataListItemEventArgs e)
    {
        bid = (BidDTO)e.Item.DataItem;

        HyperLink LnkName = (HyperLink)e.Item.FindControl("LnkName");
        Label LblProjectTitle = (Label)e.Item.FindControl("LblProjectTitle");
        Label LblAmount = (Label)e.Item.FindControl("LblAmount");


        LnkName.NavigateUrl= "~/Bid/ViewBid.aspx?BidId="+bid.BidId;
        LblProjectTitle.Text = bid.ProjectTitle;
        LblAmount.Text ="<b>Bid Amount</b> $ " + bid.Amount.ToString();
    }
}