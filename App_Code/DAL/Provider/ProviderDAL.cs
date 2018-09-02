using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

/// <summary>
/// Summary description for ProviderDALcs
/// </summary>
public class ProviderDAL
{
    private ProviderDTO provider;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;

	public ProviderDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public long InsertProvider(ProviderDTO Provider)
    {
        command = new SqlCommand(StoredProcedureName.Names.AddProvider.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Country", SqlDbType.VarChar, 50);
        command.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Password", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = Provider.FirstName;
        command.Parameters[1].Value = Provider.LastName;
        command.Parameters[2].Value = Provider.Country;
        command.Parameters[3].Value = Provider.Email;
        command.Parameters[4].Value = Provider.Password;

        long providerid = 0;

        connection.Open();

        providerid = Convert.ToInt64(command.ExecuteScalar());

        connection.Close();

        return providerid;
    }


    public int UpdateProviderIntroducation(ProviderDTO Provider)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateProviderIntroducation.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Haves", SqlDbType.VarChar);
        command.Parameters.Add("@Wants", SqlDbType.VarChar);
        command.Parameters.Add("@OverView", SqlDbType.VarChar);
        command.Parameters.Add("@Country", SqlDbType.VarChar);


        command.Parameters[0].Value = Provider.ProviderId;
        command.Parameters[1].Value = Provider.FirstName;
        command.Parameters[2].Value = Provider.LastName;
        command.Parameters[3].Value = Provider.MiddleName;
        command.Parameters[4].Value = Provider.Haves;
        command.Parameters[5].Value = Provider.Wants;
        command.Parameters[6].Value = Provider.OverView;
        command.Parameters[7].Value = Provider.Country;


        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }



    public int UpdateProvider(ProviderDTO Provider)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateProvider.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderID", SqlDbType.BigInt);
        command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Address1", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Address2", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Fax", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Email", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Phone", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Website", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Mobile", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Country", SqlDbType.VarChar, 50);
        command.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Password", SqlDbType.VarChar, 50);


        command.Parameters[0].Value = Provider.ProviderId;
        command.Parameters[1].Value = Provider.FirstName;
        command.Parameters[2].Value = Provider.LastName;
        command.Parameters[3].Value = Provider.MiddleName;
        command.Parameters[4].Value = Provider.Address1;
        command.Parameters[5].Value = Provider.Address2;
        command.Parameters[6].Value = Provider.Fax;
        command.Parameters[7].Value = Provider.Email;
        command.Parameters[8].Value = Provider.Phone;
        command.Parameters[9].Value = Provider.Website;
        command.Parameters[10].Value = Provider.Mobile;
        command.Parameters[11].Value = Provider.Country;
        command.Parameters[12].Value = Provider.UserName;
        command.Parameters[13].Value = Provider.Password;

        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }

    public List<ProviderDTO> SelectAllProvider(int PageNo, int PageSize)
    {
        List<ProviderDTO> providers = new List<ProviderDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SelectAllProvider.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@PageNo", SqlDbType.Int);
        command.Parameters.Add("@PageSize", SqlDbType.Int);

        command.Parameters[0].Value = PageNo;
        command.Parameters[1].Value = PageSize;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            provider = new ProviderDTO();
            provider.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            provider.FirstName = datareader["FirstName"].ToString();
            provider.LastName = datareader["LastName"].ToString();
            provider.MiddleName = datareader["MiddleName"].ToString();
            provider.ProviderSkills = datareader["ProviderSkills"].ToString();
            provider.Mobile = datareader["Mobile"].ToString();
            provider.Phone = datareader["Phone"].ToString();
            provider.Website = datareader["Website"].ToString();
            provider.Address1 = datareader["Address1"].ToString();
            provider.Address2 = datareader["Address2"].ToString();
            provider.Country = datareader["Country"].ToString();
            provider.Email = datareader["Email"].ToString();
            provider.Fax = datareader["Fax"].ToString();
            provider.OverView = datareader["Overview"].ToString();
            provider.UserName = datareader["UserName"].ToString();
            provider.Password = datareader["Password"].ToString();
            provider.TotalPage = Convert.ToInt32(datareader["TotalPage"].ToString());
            provider.TotalRec = Convert.ToInt32(datareader["TotalRec"].ToString());

            providers.Add(provider);
        }
        connection.Close();
        return providers;
    }

    public ProviderDTO GetProviderIntroductionById(long ProviderId)
    {
        command = new SqlCommand(StoredProcedureName.Names.GetProviderIntroductionById.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderID", SqlDbType.BigInt);

        command.Parameters[0].Value = ProviderId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            provider = new ProviderDTO();
            provider.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            provider.FirstName = datareader["FirstName"].ToString();
            provider.LastName = datareader["LastName"].ToString();
            provider.MiddleName = datareader["MiddleName"].ToString();
            provider.Haves = datareader["Haves"].ToString();
            provider.Wants = datareader["Wants"].ToString();
            provider.OverView = datareader["Overview"].ToString();
            provider.Country = datareader["Country"].ToString();

        }
        connection.Close();
        return provider;
    }

    public long AuthenticateUser(ProviderDTO provider)
    {
        command = new SqlCommand(StoredProcedureName.Names.AuthenticateUser.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Email", SqlDbType.VarChar);
        command.Parameters.Add("@Password", SqlDbType.VarChar);

        command.Parameters[0].Value = provider.Email;
        command.Parameters[1].Value = provider.Password;

        connection.Open();

        datareader = command.ExecuteReader();

        if (datareader.HasRows)
        {
            datareader.Read();
            return Convert.ToInt64(datareader["ProviderId"].ToString());
        }
        else
            return 0;
    }

    public int ChangePassword(ProviderDTO provider ,string NewPassword)
    {
        int result;

        command = new SqlCommand(StoredProcedureName.Names.ChangePassword.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@OldPassword", SqlDbType.VarChar);
        command.Parameters.Add("@NewPassword", SqlDbType.VarChar);

        command.Parameters[0].Value = provider.ProviderId;
        command.Parameters[1].Value = provider.Password;
        command.Parameters[2].Value = NewPassword;

        connection.Open();

        result = command.ExecuteNonQuery();

        connection.Close();

        return result;
    }


    public ProviderDTO GetProviderContactById(long ProviderId)
    {
        command = new SqlCommand(StoredProcedureName.Names.GetProviderContactById.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderID", SqlDbType.BigInt);

        command.Parameters[0].Value = ProviderId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            provider = new ProviderDTO();
            provider.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            provider.Address1 = datareader["Address1"].ToString();
            provider.Address2 = datareader["Address2"].ToString();
            provider.Email = datareader["Email"].ToString();
            provider.Phone = datareader["Phone"].ToString();
            provider.Fax = datareader["Fax"].ToString();
            provider.Website = datareader["Website"].ToString();
            provider.Mobile = datareader["Mobile"].ToString();
            //provider.Country = datareader["Country"].ToString();

        }
        connection.Close();
        return provider;
    }

    public long UpdateProviderContact(ProviderDTO Provider)
    {

        command = new SqlCommand(StoredProcedureName.Names.UpdateProviderContact.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@Address1", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Address2", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Fax", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Email", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Phone", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Website", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Mobile", SqlDbType.VarChar, 50);
        //command.Parameters.Add("@Country", SqlDbType.VarChar, 50);

        command.Parameters[0].Value = Provider.ProviderId;
        command.Parameters[1].Value = Provider.Address1;
        command.Parameters[2].Value = Provider.Address2;
        command.Parameters[3].Value = Provider.Fax;
        command.Parameters[4].Value = Provider.Email;
        command.Parameters[5].Value = Provider.Phone;
        command.Parameters[6].Value = Provider.Website;
        command.Parameters[7].Value = Provider.Mobile;
        //command.Parameters[8].Value = Provider.Country;


        long providerid = 0;

        connection.Open();

        providerid = command.ExecuteNonQuery();

        connection.Close();

        return providerid;
    }

    public void AddProviderImage(long providerid, byte[] imagename)
    {
        command = new SqlCommand(StoredProcedureName.Names.AddProviderImage.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@ImageName", SqlDbType.Image);

        command.Parameters[0].Value = providerid;
        command.Parameters[1].Value = imagename;

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public Stream GetProviderImage(long providerid)
    {
        command = new SqlCommand(StoredProcedureName.Names.GetProviderImage.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters[0].Value = providerid;


        connection.Open();
        object img = command.ExecuteScalar();
        try
        {
            return new MemoryStream((byte[])img);
        }
        catch
        {
            return null;
        }
        finally
        {
            connection.Close();
        }
    }
    

    public ProviderDTO GetProviderPassword(long providerid)
    {
        command = new SqlCommand(StoredProcedureName.Names.GetProviderPassword.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);

        command.Parameters[0].Value = providerid;

        connection.Open();
        datareader = command.ExecuteReader();

       connection.Open();
       if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            provider = new ProviderDTO();
            provider.Email = datareader["Email"].ToString();
            provider.Password = datareader["Password"].ToString();
        }
        connection.Close();
        return provider;
    }

}