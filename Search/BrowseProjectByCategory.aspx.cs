using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search_BrowseProjectByCategory : System.Web.UI.Page
{
    private CategoryBL categorybl;
    private CategoryDTO category;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            categorybl = new CategoryBL();
            DatLstCategories.DataSource = categorybl.GetProjectCategories();
            DatLstCategories.DataBind();
        }
    }


    protected void DatLstCategories_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        category = new CategoryDTO();
        category = (CategoryDTO)e.Item.DataItem;

        HyperLink lnkSubcategory;
        Label lblCategory;

        lnkSubcategory = (HyperLink)e.Item.FindControl("LnkSubCategory");
        lblCategory = (Label)e.Item.FindControl("LblCategory");

        lnkSubcategory.Text = category.SubCategoryName;
        lnkSubcategory.NavigateUrl = "~/Project/ViewAllProject.aspx?SubCategory=" + category.SubCategoryName.ToString();

        lblCategory.Text = category.CategoryName.ToString();

        
    }
}