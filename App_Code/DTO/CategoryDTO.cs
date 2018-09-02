using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryDTO1
/// </summary>
public class CategoryDTO
{
    public CategoryDTO()
    {
        categoryId = -1;
        subCategoryId = -1;
    }

    private int categoryId;

    public int CategoryId
    {
        get { return categoryId; }
        set { categoryId = value; }
    }
    private int subCategoryId;

    public int SubCategoryId
    {
        get { return subCategoryId; }
        set { subCategoryId = value; }
    }
    private string categoryName;

    public string CategoryName
    {
        get { return categoryName; }
        set { categoryName = value; }
    }
    private string subCategoryName;

    public string SubCategoryName
    {
        get { return subCategoryName; }
        set { subCategoryName = value; }
    }
}