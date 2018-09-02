using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Summary description for CategoryBL
/// </summary>
public class CategoryDAL
{
    private CategoryDTO Category;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private List<CategoryDTO> Categories;

    public CategoryDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public List<CategoryDTO> GetCategory()
    {
        Categories = new List<CategoryDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetCategory.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Category = new CategoryDTO();
            Category.CategoryId = Convert.ToInt32(datareader["JobCategoryId"]);
            Category.CategoryName = datareader["JobCategoryName"].ToString();
         
            Categories.Add(Category);
        }
        connection.Close();
        return Categories;
    }

    public List<CategoryDTO> GetSubCategory(int categoryid)
    {
        Categories = new List<CategoryDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetSubCategory.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@JobCategoryId", SqlDbType.BigInt);
        command.Parameters[0].Value = categoryid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Category = new CategoryDTO();
            Category.CategoryId = Convert.ToInt32(datareader["JobCategoryId"]);
            //Category.CategoryName = datareader["JobCategoryName"].ToString();
            Category.SubCategoryId = Convert.ToInt32(datareader["JobSubCategoryId"]);
            Category.SubCategoryName = datareader["SubCategoryName"].ToString();


            Categories.Add(Category);
        }
        connection.Close();
        return Categories;
    }

    public List<CategoryDTO> GetProjectCategories()
    {
        Categories = new List<CategoryDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetProjectCategories.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;


        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Category = new CategoryDTO();
            Category.CategoryName = datareader["JobCategoryName"].ToString();
            Category.SubCategoryName = datareader["SubCategoryName"].ToString();
            Categories.Add(Category);
        }
        connection.Close();
        return Categories;
    }

}