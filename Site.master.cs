using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    public HttpCookie cookie;
    public long providerid = 0;
    private string userName;
    private string password;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public long ProviderId
    {
        get { return providerid; }
        set { providerid = value; }
    }

    public HyperLink LinkSetting
    {
        get { return LnkSetting; }
        set { LnkSetting = value; }
    }

    public HyperLink LinkLogOut
    {
        get { return LnkLogut; }
        set { LnkLogut = value; }
    }

    public HyperLink LinkLogIn
    {
        get { return LnkLogIn; }
        set { LnkLogIn = value; }
    }

    public HyperLink LinkRegister
    {
        get { return LnkRegister; }
        set { LnkRegister = value; }
    }

    public HtmlMeta Description
    {
        get { return description; }
        set { description = value; }
    }

    public HtmlMeta Keywords
    {
        get { return keywords; }
        set { keywords = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //// Meta tags and title of resources pages e.g(Resources.aspx, MainCategoryDetails.aspx,SubCategoryDetails.aspx) are managed from their own code behind

            ////////////////// Manage Meta Tags keywords and Title//////////////////
            //string page_name = GetCurrentPageName();

            //pageContent pContent = new pageContentBL().GetPageContentByPageName(page_name);
            //if (pContent != null)
            //{
            //    if (title.Text == null || title.Text.Trim() == "" || title.Text == "Untitled Page") title.Text = pContent.page_title;
            //    if (description.Content == "") description.Attributes.Add("content", pContent.description);
            //    if (keywords.Content == "") keywords.Attributes.Add("content", pContent.keywords);
            //}
            //else
            //{
            //    if (title.Text == null || title.Text.Trim() == "" || title.Text == "Untitled Page") title.Text = Constants.DEFAULT_PAGE_TITLE;
            //    if (description.Content == "") description.Attributes.Add("content", Constants.DEFAULT_META_DESC);
            //    if (keywords.Content == "") keywords.Attributes.Add("content", Constants.DEFAULT_META_KEYWORDS);
            //}
            //////////////////////////////////////End//////////////////////////////////

            //pContent = new pageContentBL().GetPageContentByPageName("footer");
            //lblFooter.Text = pContent.content;

            UpdateMasterPage();
        }
    }
        
    public void UpdateMasterPage()
    {
        GetCookie();
        if (ProviderId != 0)
        {
            LinkSetting.Visible = true;
            LinkLogOut.Visible = true;
            LinkRegister.Visible = false;
            LinkLogIn.Visible = false;

             LiteralMenu.Text +="<ul id=\"navmenu-h\">";
             LiteralMenu.Text += "<li><a href=\"/Default.aspx\">Home&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a></li>";
             LiteralMenu.Text += "<li><a href=\"/Workspace/ProviderWorkspace.aspx\">Workspace&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a></li>";
             LiteralMenu.Text += "<li><a href=\"/Project/ViewAllProject.aspx\" title=\"Jobs\">Jobs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a> </li>";
             LiteralMenu.Text += " <li><a href=\"/Provider/SearchProvider.aspx\" title=\"Workers\">Workers&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>";
             LiteralMenu.Text +=" </li></ul>";

        }
        else
        {
            LinkSetting.Visible = false;
            LinkLogOut.Visible = false;
            LinkRegister.Visible = true;
            LinkLogIn.Visible = true;

            LiteralMenu.Text += "<ul id=\"navmenu-h\">";
            LiteralMenu.Text += "<li><a href=\"/Default.aspx\">Home&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a></li>";
            LiteralMenu.Text += "<li><a href=\"/Project/ViewAllProject.aspx\" title=\"Jobs\">Jobs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a> </li>";
            LiteralMenu.Text += " <li><a href=\"/Provider/SearchProvider.aspx\" title=\"Workers\">Workers&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>";
            LiteralMenu.Text += " </li></ul>";
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

    private void addBlurAtt(Control Textboxes)
    {
        if (Textboxes.Controls.Count > 0)
        {
            foreach (Control childControl in Textboxes.Controls)
            {
                addBlurAtt(childControl);
            }
        }
        if (Textboxes.GetType() == typeof(TextBox))
        {
            TextBox TempTextBox = (TextBox)Textboxes;
            TempTextBox.Attributes.Add("onFocus", "DoFocus(this);");
            TempTextBox.Attributes.Add("onBlur", "DoBlur(this);");
            TempTextBox.Attributes.Add("class", "textboxOutFocus");
        }
        else if (Textboxes.GetType() == typeof(ListBox))
        {
            ListBox TempTextBox = (ListBox)Textboxes;
            TempTextBox.Attributes.Add("onFocus", "DoFocus(this);");
            TempTextBox.Attributes.Add("onBlur", "DoBlur(this);");
            TempTextBox.Attributes.Add("class", "textboxOutFocus");
        }
        else if (Textboxes.GetType() == typeof(HtmlTextArea))
        {
            HtmlTextArea TempTextBox = (HtmlTextArea)Textboxes;
            TempTextBox.Attributes.Add("onFocus", "DoFocus(this);");
            TempTextBox.Attributes.Add("onBlur", "DoBlur(this);");
            TempTextBox.Attributes.Add("class", "textboxOutFocus");
        }
    } 
}
