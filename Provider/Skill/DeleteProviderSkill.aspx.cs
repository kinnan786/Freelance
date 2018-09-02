using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Skill_DeleteProviderSkill : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderSkillDTO ProviderSkill;
    private ProviderSkillBL ProviderSkillbl;
    private long ProviderId = 0;
    private int SkillId = 0;
    private long rowsaffected = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();

        if (!IsPostBack)
        {
            SkillId = Convert.ToInt32(Request.QueryString["SkillId"]);
            ProviderSkillbl = new ProviderSkillBL();
            ProviderSkillbl.DeleteProviderSkill(ProviderId, SkillId);
            Response.Redirect("~/Provider/Skill/AddProviderSkill.aspx");
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

}