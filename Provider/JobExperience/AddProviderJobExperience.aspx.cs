using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provider_JobExperience_AddProviderJobExperience : System.Web.UI.Page
{
    private HttpCookie cookie;
    private ProviderEmploymentDTO ProviderEmployment;
    private ProviderEmploymentBL Provideremploymentbl;
    private long ProviderId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int year = DateTime.Now.Year; year > (DateTime.Now.Year - 58); year--)
            {
                ListItem item = new ListItem(year.ToString(), year.ToString());
                DDListFromYear.Items.Add(item);
                DDListToYear.Items.Add(item);
            }
        }
        GetCookie();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        ProviderEmployment = new ProviderEmploymentDTO();
        Provideremploymentbl = new ProviderEmploymentBL();

        ProviderEmployment.ProviderId = ProviderId;
        ProviderEmployment.OrganizationName = TxtOrganizationName.Text;
        ProviderEmployment.Position = TxtPosition.Text;

        if (DDListFromMonth.SelectedItem.Value != 0.ToString() && DDListFromYear.SelectedItem.Value != 0.ToString())
        {
            ProviderEmployment.FromMonth = DDListFromMonth.SelectedItem.Value;
            ProviderEmployment.FromYear = DDListFromYear.SelectedItem.Value;
        }

        if (DDListToMonth.SelectedItem.Value != 0.ToString() && DDListToYear.SelectedItem.Value != 0.ToString())
        {
            ProviderEmployment.ToMonth = DDListToMonth.SelectedItem.Value;
            ProviderEmployment.ToYear = DDListToYear.SelectedItem.Value;
        }

        if (ChkCurrentlyWorkHere.Checked == true)
        {
            ProviderEmployment.CurrentlyWorkhere = ChkCurrentlyWorkHere.Checked;
        }

        ProviderEmployment.Responsibilities = lstResponsibilites.Text;

        string strresponsibilities = "";
        if( Convert.ToInt32(lstResponsibilites.Items.Count) > 0)
        {
            for (int i=0;i<lstResponsibilites.Items.Count;i++)
            {
                strresponsibilities += lstResponsibilites.Items[i].ToString();
                strresponsibilities += ",";
            }
            ProviderEmployment.Responsibilities = strresponsibilities;
        }

        string strlstSkills = "";
        if (Convert.ToInt32(lstSkills.Items.Count) > 0)
        {
            for (int i = 0; i < lstSkills.Items.Count; i++)
            {
                strlstSkills += lstSkills.Items[i].ToString();
                strlstSkills += ", ";
            }
            ProviderEmployment.EmploymentSkills = strlstSkills;
        }

        ProviderEmployment.CurrentlyWorkhere = (bool)ChkCurrentlyWorkHere.Checked;

        Provideremploymentbl.InsertProviderEmployment(ProviderEmployment);
        Response.Redirect("~/Provider/ProfilePage.aspx");
    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }
    protected void LinkAddEmployment_Click(object sender, ImageClickEventArgs e)
    {
        if (txtresponsibility.Text != null && txtresponsibility.Text != "" && lstResponsibilites.Items.Count < 10)
        {
            ListItem item = new ListItem(txtresponsibility.Text);
            lstResponsibilites.Items.Add(item);
            txtresponsibility.Text = "";
            txtresponsibility.Focus();
        }
        else
        {
            txtresponsibility.Text = "";
           
        }
    }

    protected void LinkDeleteEmployment_Click(object sender, ImageClickEventArgs e)
    {
        if (lstResponsibilites.Items.Count > 0)
        {
            lstResponsibilites.Items.RemoveAt(Convert.ToInt32(lstResponsibilites.SelectedIndex));
        }
    }

    protected void LinkEditEmployment_Click(object sender, ImageClickEventArgs e)
    {
        txtresponsibility.Text = lstResponsibilites.SelectedItem.Text.ToString();
        lstResponsibilites.Items.RemoveAt(Convert.ToInt32(lstResponsibilites.SelectedIndex));
    }

    protected void LinkAddToolsused_Click(object sender, ImageClickEventArgs e)
    {
        if (txtskills.Text != null && txtskills.Text != "" && lstSkills.Items.Count < 5)
        {
            ListItem skillitems = new ListItem(txtskills.Text);
            lstSkills.Items.Add(skillitems);
            txtskills.Text = "";
            txtskills.Focus();
        }
        else
        {
            txtskills.Text = "";
        }
    }

    protected void LinkDeleteToolUsed_Click(object sender, ImageClickEventArgs e)
    {
        if (lstSkills.Items.Count > 0)
        {
            lstSkills.Items.RemoveAt(Convert.ToInt32(lstSkills.SelectedIndex));
        }
    }
}