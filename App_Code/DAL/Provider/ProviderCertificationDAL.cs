using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for ProviderCertificationDAL
/// </summary>
public class ProviderCertificationDAL
{
    private ProviderCertificationDTO ProviderCertification;
    private List<ProviderCertificationDTO> ProviderCertificationList;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private long CertificationId = 0;

	public ProviderCertificationDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public List<ProviderCertificationDTO> GetProviderCertification(long providerid)
    {
        ProviderCertificationList = new List<ProviderCertificationDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetProviderCertification.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderCertification = new ProviderCertificationDTO();
            ProviderCertification.CertificationId = Convert.ToInt64(datareader["CertificationId"]);
            ProviderCertification.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderCertification.CertificationName = datareader["CertificationName"].ToString();
            ProviderCertification.Description = datareader["Description"].ToString();
            ProviderCertification.Percentage = Convert.ToInt16(datareader["Percentage"]);
            ProviderCertification.Score = Convert.ToInt32(datareader["Score"]);
            ProviderCertification.YearCompleted = datareader["YearCompleted"].ToString();

            ProviderCertificationList.Add(ProviderCertification);
        }
        connection.Close();
        return ProviderCertificationList;
    }

    public ProviderCertificationDTO GetProviderCertificationByCertificationId(long providerid, long certificationid)
    {
        ProviderCertification = new ProviderCertificationDTO();

        command = new SqlCommand(StoredProcedureName.Names.GetProviderCertificationByCertificationId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@CertificationId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = certificationid;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            ProviderCertification.CertificationId = Convert.ToInt64(datareader["CertificationId"]);
            ProviderCertification.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            ProviderCertification.CertificationName = datareader["CertificationName"].ToString();
            ProviderCertification.Description = datareader["Description"].ToString();
            ProviderCertification.Percentage = Convert.ToInt16(datareader["Percentage"]);
            ProviderCertification.Score = Convert.ToInt32(datareader["Score"]);
            ProviderCertification.YearCompleted = datareader["YearCompleted"].ToString();
        }
        connection.Close();
        return ProviderCertification;
    }

    public long AddProviderCertification(ProviderCertificationDTO providerCertification)
    {
        command = new SqlCommand(StoredProcedureName.Names.AddProviderCertification.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@CertificationName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Description", SqlDbType.VarChar);
        command.Parameters.Add("@Percentage", SqlDbType.SmallInt, 100);
        command.Parameters.Add("@Score", SqlDbType.Int, 10);
        command.Parameters.Add("@YearCompleted", SqlDbType.VarChar, 10);

        command.Parameters[0].Value = providerCertification.ProviderId;
        command.Parameters[1].Value = providerCertification.CertificationName;
        command.Parameters[2].Value = providerCertification.Description;
        command.Parameters[3].Value = providerCertification.Percentage;
        command.Parameters[4].Value = providerCertification.Score;
        command.Parameters[5].Value = providerCertification.YearCompleted;


        connection.Open();

        CertificationId = Convert.ToInt64(command.ExecuteScalar());

        connection.Close();

        return CertificationId;
    }

    public int UpdateProviderCertification(ProviderCertificationDTO providerCertification)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateProviderCertification.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@CertificationId", SqlDbType.BigInt);
        command.Parameters.Add("@CertificationName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Description", SqlDbType.VarChar);
        command.Parameters.Add("@Percentage", SqlDbType.SmallInt, 100);
        command.Parameters.Add("@Score", SqlDbType.Int, 10);
        command.Parameters.Add("@YearCompleted", SqlDbType.VarChar, 10);

        command.Parameters[0].Value = providerCertification.ProviderId;
        command.Parameters[1].Value = providerCertification.CertificationId;
        command.Parameters[2].Value = providerCertification.CertificationName;
        command.Parameters[3].Value = providerCertification.Description;
        command.Parameters[4].Value = providerCertification.Percentage;
        command.Parameters[5].Value = providerCertification.Score;
        command.Parameters[6].Value = providerCertification.YearCompleted;

        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }

    public long DeleteProviderCertification(long providerid, long certificationid)
    {
        command = new SqlCommand(StoredProcedureName.Names.DeleteProviderCertification.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@CertificationID", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = certificationid;
       

        connection.Open();

        CertificationId = Convert.ToInt64(command.ExecuteNonQuery());

        connection.Close();

        return CertificationId;
    }
}