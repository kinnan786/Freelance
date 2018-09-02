using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for ProviderEducationDAL
/// </summary>
public class ProviderEducationDAL
{
    private ProviderEducationDTO ProviderEducation;
    private List<ProviderEducationDTO> ProviderEducationList;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private long EducationId = 0;

	public ProviderEducationDAL()
	{
		connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public List<ProviderEducationDTO> GetProviderEducationByProviderId(long providerid)
    {
        ProviderEducationList = new List<ProviderEducationDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetProviderEducationByProviderId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderEducation = new ProviderEducationDTO();
            ProviderEducation.EducationId = Convert.ToInt64(datareader["EducationId"]);
            ProviderEducation.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderEducation.InstitutionName = datareader["InstitutionName"].ToString();
            ProviderEducation.DegreeTitle = datareader["DegreeTitle"].ToString();
            ProviderEducation.YearCompleted = datareader["YearCompleted"].ToString();
            ProviderEducationList.Add(ProviderEducation);
        }
        connection.Close();
        return ProviderEducationList;
    }

    public long AddProviderEducation(ProviderEducationDTO providereducation)
    {
        command = new SqlCommand(StoredProcedureName.Names.AddProviderEducation.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@InstitutionName", SqlDbType.VarChar, 100);
        command.Parameters.Add("@DegreeTitle", SqlDbType.VarChar, 100);
        command.Parameters.Add("@YearCompleted", SqlDbType.VarChar, 10);
      
        command.Parameters[0].Value = providereducation.ProviderId;
        command.Parameters[1].Value = providereducation.InstitutionName;
        command.Parameters[2].Value = providereducation.DegreeTitle;
        command.Parameters[3].Value = providereducation.YearCompleted;
       
        connection.Open();

        EducationId = Convert.ToInt64(command.ExecuteScalar());

        connection.Close();

        return EducationId;
    }

    public int UpdateProviderEducation(ProviderEducationDTO providereducation)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateProviderEducation.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@EducationId", SqlDbType.BigInt);
        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@InstitutionName", SqlDbType.VarChar, 100);
        command.Parameters.Add("@DegreeTitle", SqlDbType.VarChar, 100);
        command.Parameters.Add("@YearCompleted", SqlDbType.VarChar, 10);

        command.Parameters[0].Value = providereducation.EducationId;
        command.Parameters[1].Value = providereducation.ProviderId;
        command.Parameters[2].Value = providereducation.InstitutionName;
        command.Parameters[3].Value = providereducation.DegreeTitle;
        command.Parameters[4].Value = providereducation.YearCompleted;

        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }

    public void  DeleteProviderEducation(long providerid, long educationid)
    {
        command = new SqlCommand(StoredProcedureName.Names.DeleteProviderEducation.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@Educationid", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = educationid;

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public ProviderEducationDTO GetProviderEducationByEducationId(long providerid, long educationid)
    {
        ProviderEducation = new ProviderEducationDTO();

        command = new SqlCommand(StoredProcedureName.Names.GetProviderEducationByEducationId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@EducationId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = educationid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderEducation.EducationId = Convert.ToInt64(datareader["EducationId"]);
            ProviderEducation.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderEducation.InstitutionName = datareader["InstitutionName"].ToString();
            ProviderEducation.DegreeTitle = datareader["DegreeTitle"].ToString();
            ProviderEducation.YearCompleted = datareader["YearCompleted"].ToString();
        }
        connection.Close();

        return ProviderEducation;
    }
}