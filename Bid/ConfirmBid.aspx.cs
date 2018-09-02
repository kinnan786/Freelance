using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bid_ConfirmBid : System.Web.UI.Page
{
    private BidDTO bid;
    private BidBL bidbl;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bid = (BidDTO)Session["BidDTO"];
            //LblJobTitle.Text = bid.ProviderName.ToString();
            LblEstimatedduration.Text = bid.Duration;
            LblDescription.Text = bid.Description;
            LblAmount.Text = bid.Amount;
        }
    }

    protected void BtnConfirmAndPost_Click(object sender, EventArgs e)
    {
        bid = (BidDTO)Session["BidDTO"];
        bidbl = new BidBL();
        bidbl.InsertBid(bid);
        Response.Redirect("~/Workspace/ProviderBids.aspx");
    }
}