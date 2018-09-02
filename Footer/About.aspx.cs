using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Footer_About : System.Web.UI.Page
{
    private HtmlMeta description;
    private HtmlMeta keyword;
    private HtmlTitle title;

    protected void Page_Load(object sender, EventArgs e)
    {
        SetMetaTags();
    }

    protected void SetMetaTags()
    {
        description = (HtmlMeta)Master.FindControl("Description");
        keyword = (HtmlMeta)Master.FindControl("Keywords");
        title = (HtmlTitle)Master.FindControl("Title");

        description.Content = "Work4Sale is the marketplace for online workteams, with the best business model for both buyers and providers. Our unique approach guarantees to buyers that an hour billed is an";
        keyword.Content = "About Us, Outsourcing Solution, Job Board, High Technology, Programmers, Developers, Web Design, SEO, Work4Sale";
        title.Text = "About Us - The Marketplace for Online Workteams - Work4Sale";
    }
}