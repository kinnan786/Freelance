using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Bid_ViewBid : System.Web.UI.Page
{
    private long bid = 0;
    private BidDTO bidDTO;
    private BidBL bidbl;
    private HtmlMeta description;
    private HtmlMeta keyword;

    protected void Page_Load(object sender, EventArgs e)
    {

        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");

        description.Content = "asdasdas";
        keyword.Content = "asdasdsadsd,asdasdas,adsda";



        bid = Convert.ToInt64(Request.QueryString["BidId"]);

        bidbl = new BidBL();
        bidDTO = bidbl.SelectBidById(bid);

        LinkProjectName.Text = bidDTO.ProjectTitle.ToString();
        LinkProjectName.NavigateUrl = "~/Project/ViewProject.aspx?ProjectId="+ bidDTO.JobId.ToString();

        LblProvidername.Text = bidDTO.ProviderName.ToString();
        LblProviderSkills.Text = bidDTO.ProviderSkill.ToString();
        LblProviderCountry.Text = bidDTO.ProviderCountry.ToString();
        LblDuration.Text = bidDTO.Duration.ToString();
        LblBidOn.Text = bidDTO.BidOn.ToString();
        LblAmount.Text = "$ "+bidDTO.Amount.ToString();
        LblAdvancePayment.Text = "$ " + bidDTO.AdvancePayment.ToString();
        LblDescription.Text = bidDTO.Description.ToString();

        BtnAcceptBid.PostBackUrl = "~/Bid/BidAccept.aspx";
    }
}