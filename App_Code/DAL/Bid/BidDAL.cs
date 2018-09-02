using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for BidDAL
/// </summary>
public class BidDAL
{
    private BidDTO bid;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;

	public BidDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public long InsertBid(BidDTO Bid)
    {
        command = new SqlCommand(StoredProcedureName.Names.InsertBid.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@JobId", SqlDbType.BigInt);
        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@Amount", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Description", SqlDbType.VarChar, 5000);
        command.Parameters.Add("@BidOn", SqlDbType.DateTime);
        command.Parameters.Add("@AdvancePayment", SqlDbType.Int);
        command.Parameters.Add("@Duration ", SqlDbType.VarChar, 50);
       

        command.Parameters[0].Value = Bid.JobId;
        command.Parameters[1].Value = Bid.ProviderId;
        command.Parameters[2].Value = Bid.Amount;
        command.Parameters[3].Value = Bid.Description;
        command.Parameters[4].Value = Bid.BidOn;
        command.Parameters[5].Value = Bid.AdvancePayment;
        command.Parameters[6].Value = Bid.Duration;

        
        long Bidid = 0;

        connection.Open();

        Bidid = command.ExecuteNonQuery();

        connection.Close();

        return Bidid;
    }

    public int UpdateBid(BidDTO Bid)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateBid.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BidId", SqlDbType.BigInt);
        command.Parameters.Add("@JobId", SqlDbType.BigInt);
        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@Amount", SqlDbType.VarChar, 50);
        command.Parameters.Add("@Comments", SqlDbType.VarChar, 500);

        command.Parameters[0].Value = Bid.BidId;
        command.Parameters[1].Value = Bid.JobId;
        command.Parameters[2].Value = Bid.ProviderId;
        command.Parameters[3].Value = Bid.Amount;
        //command.Parameters[4].Value = Bid.Comments;

        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }


    public BidDTO SelectBidById(long BidId)
    {
        command = new SqlCommand(StoredProcedureName.Names.SelectBidById.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BidId", SqlDbType.BigInt);

        command.Parameters[0].Value = BidId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            bid = new BidDTO();
            bid.BidId = Convert.ToInt64(datareader["BidId"]);
            bid.JobId = Convert.ToInt64(datareader["JobId"]);
            bid.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            bid.ProviderName = datareader["ProviderName"].ToString();
            bid.ProviderSkill = datareader["ProviderSkills"].ToString();
            bid.ProviderCountry = datareader["ProviderCountry"].ToString();
            bid.ProjectTitle = datareader["ProjectTitle"].ToString();
            bid.Amount = datareader["Amount"].ToString();
            bid.Description = datareader["Description"].ToString();
            //bid.BidOn = Convert.ToDateTime(datareader["BidOn"].ToString());
            //bid.AdvancePayment = Convert.ToInt16(datareader["AdvancePayment"].ToString());
            bid.Duration = datareader["Duration"].ToString();

        }
        connection.Close();
        return bid;
    }

    public List<BidDTO> SelectBidByJobId(long JobId)
    {
        List<BidDTO> Bids = new List<BidDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SelectBidByJobId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@JobId", SqlDbType.BigInt);

        command.Parameters[0].Value = JobId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            bid = new BidDTO();
            bid.BidId = Convert.ToInt64(datareader["BidId"]);
            bid.JobId = Convert.ToInt64(datareader["JobId"]);
            bid.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            bid.ProviderName = datareader["ProviderName"].ToString();
            bid.ProviderSkill = datareader["ProviderSkills"].ToString();
            bid.ProviderCountry = datareader["ProviderCountry"].ToString();
            //bid.BidOn = Convert.ToDateTime(datareader["BidOn"].ToString());
            bid.Amount = datareader["Amount"].ToString();
            bid.Description = datareader["Description"].ToString();
            //bid.AdvancePayment = Convert.ToInt16(datareader["AdvancePayment"]);
            bid.Duration = datareader["Duration"].ToString();


            Bids.Add(bid);
        }
        connection.Close();
        return Bids;
    }

    public List<BidDTO> SelectBidByProviderId(long ProviderId, int PageNo, int PageSize)
    {
        List<BidDTO> Bids = new List<BidDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SelectBidByProviderId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@VProviderId", SqlDbType.Int);
        command.Parameters.Add("@PageNo", SqlDbType.Int);
        command.Parameters.Add("@PageSize", SqlDbType.Int);

        command.Parameters[0].Value = ProviderId;
        command.Parameters[1].Value = PageNo;
        command.Parameters[2].Value = PageSize;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            bid = new BidDTO();
            bid.BidId = Convert.ToInt64(datareader["BidId"]);
            bid.JobId = Convert.ToInt64(datareader["JobId"]);
            bid.ProjectTitle = datareader["ProjectTitle"].ToString();
            bid.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            if (datareader["BidOn"] != DBNull.Value)
                bid.BidOn = Convert.ToDateTime(datareader["BidOn"].ToString());
            bid.Amount = datareader["Amount"].ToString();
            bid.Description = datareader["Description"].ToString();
            if (datareader["AdvancePayment"] != DBNull.Value | datareader["AdvancePayment"].ToString() != "")
               bid.AdvancePayment = Convert.ToInt16(datareader["AdvancePayment"]);
            bid.Duration = datareader["Duration"].ToString();
            bid.TotalPage = Convert.ToInt32(datareader["TotalPage"].ToString());
            bid.TotalRec = Convert.ToInt32(datareader["TotalRec"].ToString());
            Bids.Add(bid);
        }
        connection.Close();
        return Bids;
        
    }



}