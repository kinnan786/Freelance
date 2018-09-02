using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderSkillDTO
/// </summary>
public class ProviderSkillDTO
{
    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }

    private int skillId;

    public int SkillId
    {
        get { return skillId; }
        set { skillId = value; }
    }

    private string skillName;

    public string SkillName
    {
        get { return skillName; }
        set { skillName = value; }
    }
    
    private int skillCategoryId;

    public int SkillCategoryId
    {
        get { return skillCategoryId; }
        set { skillCategoryId = value; }
    }

    private string proficency;

    public string Proficency
    {
        get { return proficency; }
        set { proficency = value; }
    }
    private string years;

    public string Years
    {
        get { return years; }
        set { years = value; }
    }
    private string projectUrl;

    public string ProjectUrl
    {
        get { return projectUrl; }
        set { projectUrl = value; }
    }

    private string categoryName;

    public string CategoryName
    {
        get { return categoryName; }
        set { categoryName = value; }
    }

	public ProviderSkillDTO()
	{
        providerId = 0;
        skillId = 0;
        categoryName = "";
        projectUrl = "";
        years = "";
        proficency = "";
        skillName = "";
	}
}