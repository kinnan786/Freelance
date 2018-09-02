using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryBL
/// </summary>
public class CategoryBL
{
    private CategoryDTO Category;
    private  CategoryDAL  categorydal;

    public CategoryBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<CategoryDTO> GetCategory()
    {
        categorydal = new CategoryDAL();
        return categorydal.GetCategory();
    }

    public List<CategoryDTO> GetSubCategory(int categoryid)
    {
        categorydal = new CategoryDAL();
        return categorydal.GetSubCategory(categoryid);
    }

    public List<CategoryDTO> GetProjectCategories()
    {
        categorydal = new CategoryDAL();
        return categorydal.GetProjectCategories();
    }
}