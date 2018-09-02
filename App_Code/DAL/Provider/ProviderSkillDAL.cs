using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for ProviderSkillDAL
/// </summary>
public class ProviderSkillDAL
{
	private ProviderSkillDTO ProviderSkill;
    private List<ProviderSkillDTO> ProviderSkills;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private long SkillId = 0;

    public ProviderSkillDAL()
    {
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
    }


    public ProviderSkillDTO GetProviderSkillBySkillIDAndProviderID(long providerid, int SkillId)
    {
        ProviderSkill = new ProviderSkillDTO();
        command = new SqlCommand(StoredProcedureName.Names.GetProviderSkillBySkillIDAndProviderID.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@SkillId", SqlDbType.Int);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = SkillId;


        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderSkill.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderSkill.SkillId = Convert.ToInt32(datareader["SkillId"]);
            ProviderSkill.SkillName = datareader["SkillName"].ToString();
            ProviderSkill.Proficency = (datareader["Proficency"]).ToString();
            ProviderSkill.ProjectUrl = datareader["ProjectUrl"].ToString();
            ProviderSkill.Years = (datareader["Years"]).ToString();
            ProviderSkill.CategoryName = datareader["CategoryName"].ToString();
        }
        connection.Close();
        return ProviderSkill;
    }

    public int InsertProviderSkill(ProviderSkillDTO ProviderSkill)
    {
        int rowaffected = 0;
        command = new SqlCommand(StoredProcedureName.Names.AddProviderSkill.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@SkillId", SqlDbType.Int);
        command.Parameters.Add("@Proficency", SqlDbType.VarChar);
        command.Parameters.Add("@Years", SqlDbType.VarChar);
        command.Parameters.Add("@ProjectUrl", SqlDbType.VarChar);
        

        command.Parameters[0].Value = ProviderSkill.ProviderId;
        command.Parameters[1].Value = ProviderSkill.SkillId;
        command.Parameters[2].Value = ProviderSkill.Proficency;
        command.Parameters[3].Value = ProviderSkill.Years;
        command.Parameters[4].Value = ProviderSkill.ProjectUrl;

        connection.Open();
        rowaffected= command.ExecuteNonQuery();
        connection.Close();

        return rowaffected;
    }

    public List<ProviderSkillDTO> GetProviderSkills(long providerid)
    {
        ProviderSkills = new List<ProviderSkillDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetProviderSkills.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderSkill = new ProviderSkillDTO();
            ProviderSkill.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderSkill.SkillId = Convert.ToInt32(datareader["SkillId"]);
            ProviderSkill.SkillName = datareader["SkillName"].ToString();
            ProviderSkill.Proficency = (datareader["Proficency"]).ToString();
            ProviderSkill.ProjectUrl = datareader["ProjectUrl"].ToString();
            ProviderSkill.Years = (datareader["Years"]).ToString();
            ProviderSkill.CategoryName = datareader["CategoryName"].ToString();
            ProviderSkills.Add(ProviderSkill);
        }
        connection.Close();
        return ProviderSkills;
    }

    //THIS FUNCTION IS AN EXCEPTION IT IS GETTING ALL THE SKILLS OF THE CATEGORY ID PROVIDED
    public List<ProviderSkillDTO> GetSkillByCategory(int skillCategoryId)
    {
        ProviderSkills = new List<ProviderSkillDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetSkillByCategory.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@SkillCategoryId", SqlDbType.Int);

        command.Parameters[0].Value = skillCategoryId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderSkill = new ProviderSkillDTO();
            ProviderSkill.SkillId = Convert.ToInt32(datareader["SkillId"]);
            ProviderSkill.SkillName = datareader["SkillName"].ToString();
            ProviderSkill.SkillCategoryId = Convert.ToInt16(datareader["SkillCategoryId"]);
            ProviderSkills.Add(ProviderSkill);
        }
        connection.Close();
        return ProviderSkills;
    }

    public int DeleteProviderSkill(long providerid, int Skillid)
    {
        int rowsaffected;

        command = new SqlCommand(StoredProcedureName.Names.DeleteProviderSkill.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@SKillId", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = Skillid;

        connection.Open();
        rowsaffected = command.ExecuteNonQuery();
        connection.Close();
        return rowsaffected;
    }

    public string FunGetProviderSkills(long providerid)
    {
        string providerskill ="";


        command = new SqlCommand(StoredProcedureName.Names.ProcGetProviderSkills.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters[0].Value = providerid;
        
        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            providerskill += datareader["ProviderSkill"].ToString();
        }

        connection.Close();

        return providerskill;
    }


}