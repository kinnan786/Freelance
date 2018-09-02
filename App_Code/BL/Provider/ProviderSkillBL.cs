using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderSkillBL
/// </summary>
public class ProviderSkillBL
{
    private ProviderSkillDTO ProviderEmployment;
    private ProviderSkillDAL ProviderSkilldal;

	public ProviderSkillBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public ProviderSkillDTO GetProviderSkillBySkillIDAndProviderID(long providerid, int SkillId)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.GetProviderSkillBySkillIDAndProviderID(providerid, SkillId);
    }

    public List<ProviderSkillDTO> GetSkillByCategory(int SkillCategoryId)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.GetSkillByCategory(SkillCategoryId);
    }

    public List<ProviderSkillDTO> GetProviderSkills(long ProviderId)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.GetProviderSkills(ProviderId);
    }

    public int DeleteProviderSkill(long ProviderId, int skillid)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.DeleteProviderSkill(ProviderId,skillid);
    }

    public int InsertProviderSkill(ProviderSkillDTO ProviderSkill)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.InsertProviderSkill(ProviderSkill);
    }

    public string FunGetProviderSkills(long providerid)
    {
        ProviderSkilldal = new ProviderSkillDAL();
        return ProviderSkilldal.FunGetProviderSkills(providerid);
    
    }
}