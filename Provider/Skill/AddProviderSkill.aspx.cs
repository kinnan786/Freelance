using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_Skill_AddProviderSkill : System.Web.UI.Page
{
    private HttpCookie cookie;
    private long ProviderId = 0;
    private ProviderSkillBL ProviderSkillbl;
    private ProviderSkillDTO ProviderSkill;
    private int Skillid = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();
        ProviderSkillbl = new ProviderSkillBL();
        GridViewProviderSkill.DataSource = ProviderSkillbl.GetProviderSkills(ProviderId);
        GridViewProviderSkill.DataBind();
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ProviderSkill = new ProviderSkillDTO();
        ProviderSkillbl = new ProviderSkillBL();

        ProviderSkill.ProviderId = ProviderId;
        ProviderSkill.SkillId = Convert.ToInt32(DropDownSkill.SelectedValue);
        ProviderSkill.Proficency = DrpDwnLstProficency.SelectedItem.Value;
        ProviderSkill.Years = DrpDwnYears.SelectedItem.Value;
        ProviderSkill.ProjectUrl = TxtProjectUrl.Text;

        int rowinserted = -1;
        rowinserted = ProviderSkillbl.InsertProviderSkill(ProviderSkill);

        if (rowinserted == -1)
        {
            LblAlreadyAdded.Visible = true;
        }
        else
        {
            Response.Redirect("~/Provider/Skill/AddProviderSkill.aspx");
        }
          
        
    }
}