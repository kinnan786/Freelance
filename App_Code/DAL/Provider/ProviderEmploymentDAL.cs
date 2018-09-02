using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for ProviderEmploymentDAL
/// </summary>
public class ProviderEmploymentDAL
{
    private ProviderEmploymentDTO ProviderEmployment;
    private List<ProviderEmploymentDTO> ProviderEmploymentList;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private long employmentid = 0;

	public ProviderEmploymentDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public ProviderEmploymentDTO GetEmploymentById(long employmentid, long providerid)
    {
        command = new SqlCommand(StoredProcedureName.Names.GetEmploymentById.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@EmploymentId", SqlDbType.BigInt);
        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = employmentid;
        command.Parameters[1].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderEmployment = new ProviderEmploymentDTO();
            ProviderEmployment.EmploymentId = Convert.ToInt64(datareader["EmploymentId"]);
            ProviderEmployment.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderEmployment.CurrentlyWorkhere = false;
            ProviderEmployment.Description = datareader["Description"].ToString();
            ProviderEmployment.FromMonth = datareader["FromMonth"].ToString();
            ProviderEmployment.FromYear = datareader["FromYear"].ToString();
            ProviderEmployment.ToMonth = datareader["ToMonth"].ToString();
            ProviderEmployment.ToYear = datareader["ToYear"].ToString();
            ProviderEmployment.Responsibilities = datareader["Responsibilities"].ToString();
            ProviderEmployment.Position = datareader["Position"].ToString();
            ProviderEmployment.OrganizationName = datareader["OrganizationName"].ToString();
            ProviderEmployment.EmploymentSkills = datareader["EmploymentSkills"].ToString();
        }
        connection.Close();
        return ProviderEmployment;
    }

    public long InsertEmployment(ProviderEmploymentDTO provideremployment)
    {
        command = new SqlCommand(StoredProcedureName.Names.InsertEmployment.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.VarChar, 50);
        command.Parameters.Add("@OrganizationName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Position", SqlDbType.VarChar, 50);
        command.Parameters.Add("@FromMonth", SqlDbType.VarChar, 100);
        command.Parameters.Add("@FromYear", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Description", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Current", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Responsibilities", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ToMonth", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ToYear", SqlDbType.VarChar, 50);
        command.Parameters.Add("@EmploymentSkills", SqlDbType.VarChar);

        command.Parameters[0].Value = provideremployment.ProviderId;
        command.Parameters[1].Value = provideremployment.OrganizationName;
        command.Parameters[2].Value = provideremployment.Position;
        command.Parameters[3].Value = provideremployment.FromMonth;
        command.Parameters[4].Value = provideremployment.FromYear;
        command.Parameters[5].Value = provideremployment.Description;
        command.Parameters[6].Value = provideremployment.CurrentlyWorkhere;
        command.Parameters[7].Value = provideremployment.Responsibilities;
        command.Parameters[8].Value = provideremployment.ToMonth;
        command.Parameters[9].Value = provideremployment.ToYear;
        command.Parameters[10].Value = provideremployment.EmploymentSkills;

        connection.Open();

        employmentid = Convert.ToInt64(command.ExecuteScalar());

        connection.Close();

        return employmentid;
    }

    public int UpdateProviderEmployment(ProviderEmploymentDTO provideremployment)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateEmployment.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@EmploymentId", SqlDbType.BigInt);
        command.Parameters.Add("@OrganizationName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Position", SqlDbType.VarChar, 50);
        command.Parameters.Add("@FromMonth", SqlDbType.VarChar, 100);
        command.Parameters.Add("@FromYear", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Description", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Current", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Responsibilities", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ToMonth", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ToYear", SqlDbType.VarChar, 50);
        command.Parameters.Add("@EmploymentSkills", SqlDbType.VarChar);


        command.Parameters[0].Value = provideremployment.ProviderId;
        command.Parameters[1].Value = provideremployment.EmploymentId;
        command.Parameters[2].Value = provideremployment.OrganizationName;
        command.Parameters[3].Value = provideremployment.Position;
        command.Parameters[4].Value = provideremployment.FromMonth;
        command.Parameters[5].Value = provideremployment.FromYear;
        command.Parameters[6].Value = provideremployment.Description;
        command.Parameters[7].Value = provideremployment.CurrentlyWorkhere;
        command.Parameters[8].Value = provideremployment.Responsibilities;
        command.Parameters[9].Value = provideremployment.ToMonth;
        command.Parameters[10].Value = provideremployment.ToYear;
        command.Parameters[11].Value = provideremployment.EmploymentSkills;

        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }


    public List<ProviderEmploymentDTO> GetEmploymentByProviderId(long providerid)
    {
        ProviderEmploymentList = new List<ProviderEmploymentDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetEmploymentByProviderId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderEmployment = new ProviderEmploymentDTO();
            ProviderEmployment.EmploymentId = Convert.ToInt64(datareader["EmploymentId"]);
            ProviderEmployment.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderEmployment.CurrentlyWorkhere = false;
            ProviderEmployment.Description = datareader["Description"].ToString();
            ProviderEmployment.FromMonth = datareader["FromMonth"].ToString();
            ProviderEmployment.FromYear = datareader["FromYear"].ToString();
            ProviderEmployment.ToMonth = datareader["ToMonth"].ToString();
            ProviderEmployment.ToYear = datareader["ToYear"].ToString();
            ProviderEmployment.Responsibilities = datareader["Responsibilities"].ToString();
            ProviderEmployment.Position = datareader["Position"].ToString();
            ProviderEmployment.OrganizationName = datareader["OrganizationName"].ToString();
            ProviderEmployment.EmploymentSkills = datareader["EmploymentSkills"].ToString();
            ProviderEmploymentList.Add(ProviderEmployment);
        }
        connection.Close();
        return ProviderEmploymentList;
    }

    public void DeleteProviderEmployment(long providerid, long employmentid)
    {
        command = new SqlCommand(StoredProcedureName.Names.DeleteProviderEmployment.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@EmploymentId", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = employmentid;

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }


}