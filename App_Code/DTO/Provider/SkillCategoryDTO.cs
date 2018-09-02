using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SkillCategoryDTO
/// </summary>
public class SkillCategoryDTO
{
    private Int16 skillCategoryId;

    public Int16 SkillCategoryId
    {
        get { return skillCategoryId; }
        set { skillCategoryId = value; }
    }
    private string categoryName;

    public string CategoryName
    {
        get { return categoryName; }
        set { categoryName = value; }
    }

	public SkillCategoryDTO()
	{
        skillCategoryId = 0;
        CategoryName = "";
	}
}