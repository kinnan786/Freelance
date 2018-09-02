using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderSkillCategory
/// </summary>
public class SkillCategoryBL
{
    private SkillCategoryDTO SkillCategory;
    private SkillCategoryDAL SkillCategorydal;


    public SkillCategoryBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<SkillCategoryDTO> GetAllSkillCategory()
    {
        SkillCategorydal = new SkillCategoryDAL();
        return SkillCategorydal.GetAllSkillCategory();
    }

}