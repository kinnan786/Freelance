using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bid_CreateBid : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private long projectId = 0;
    private long BidId;
    private BidDTO bid;
    private BidBL bidbl;
    private ProjectDTO project;

    protected void Page_Load(object sender, EventArgs e)
    {


        TxtDescription.config.toolbar = new object[]
			{
				new object[] {"Clear", "Preview" },
				new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord" },
                //new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
                //new object[] { "Form", "Checkbox", "Radio", "TextField", "Textarea", "Select", "Button", "ImageButton", "HiddenField" },
                //"/",
				new object[] { "Bold", "Italic", "Underline", "Strike", "-", "Subscript", "Superscript" },
				new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote" },
				new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
                //new object[] { "BidiLtr", "BidiRtl" },
                //new object[] { "Link", "Unlink", "Anchor" },
                //new object[] { "Image", "Flash", "Table", "HorizontalRule", "Smiley", "SpecialChar", "PageBreak", "Iframe" },
                //"/",
				new object[] { "Styles", "Format", "Font", "FontSize" },
				new object[] { "TextColor", "BGColor" },
				new object[] { "Maximize", "ShowBlocks" }
			};

        GetCookie();
        projectId = Convert.ToInt64(Request.QueryString["ProjectId"]);
        if(Session["ProjectDTO"] != null)
        {
            project = (ProjectDTO)Session["ProjectDTO"];
            LinkJobPostedBy.Text = project.ProviderName;
            LblBidOpenTill.Text = Convert.ToDateTime(project.BidOpenTill).ToShortDateString();
            LblBudget.Text = project.Budget.ToString();
            LblCategory.Text = project.ProjectCategory;
            LblLocation.Text = project.ProjectLocation;
            LblPlannedStart.Text = project.PlannedStart;
            LblProjectName.Text = project.ProjectTitle;
            LblSkill.Text = project.ProjectSkills;
            LblDescription.Text = project.Description.ToString();
        }
    }

    protected void BtnPost_Click(object sender, EventArgs e)
    {
        bid = new BidDTO();
        bidbl = new BidBL();

        bid.JobId = projectId;
        bid.ProviderId = ProviderId;
        bid.Description = TxtDescription.Text;
        bid.Amount = TxtAmount.Text;
        bid.BidOn = System.DateTime.Now;
        bid.Duration = DropDownList1.SelectedValue.ToString();

        if (Txtadvancepayment.Text != "")
            bid.AdvancePayment = Convert.ToInt16(Txtadvancepayment.Text);

        Session["BidDTO"] = bid;
        Response.Redirect("~/Bid/ConfirmBid.aspx");
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