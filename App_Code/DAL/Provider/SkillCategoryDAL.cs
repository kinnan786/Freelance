using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for ProviderSkillCategory
/// </summary>
public class SkillCategoryDAL
{
    private SkillCategoryDTO ProviderSkill;
    private List<SkillCategoryDTO> ProviderSkillList;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;

    public SkillCategoryDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public List<SkillCategoryDTO> GetAllSkillCategory()
    {
        ProviderSkillList = new List<SkillCategoryDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetAllSkillCategory.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderSkill = new SkillCategoryDTO();
            ProviderSkill.SkillCategoryId = Convert.ToInt16(datareader["JobCategoryId"]);
            ProviderSkill.CategoryName = datareader["JobCategoryName"].ToString();
            ProviderSkillList.Add(ProviderSkill);
        }
        connection.Close();
        return ProviderSkillList;
    }
}