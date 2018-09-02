using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Bid_BidAccept : System.Web.UI.Page
{
    private HtmlMeta description;
    private HtmlMeta keyword;

    protected void Page_Load(object sender, EventArgs e)
    {

        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");

        description.Content = "asdasdas";
        keyword.Content = "asdasdsadsd,asdasdas,adsda";
    }
}