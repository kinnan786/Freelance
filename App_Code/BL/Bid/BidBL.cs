using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BidBL
/// </summary>
public class BidBL
{
    private BidDTO bid;
    private BidDAL biddal;

	public BidBL()
	{
	}

    public long InsertBid(BidDTO Bid)
    {
        biddal = new BidDAL();
        return biddal.InsertBid(Bid);
    }

    public int UpdateBid(BidDTO Bid)
    {
        biddal = new BidDAL();
        return biddal.UpdateBid(Bid);
    }

    public BidDTO SelectBidById(long Bidid)
    {
        biddal = new BidDAL();
        return biddal.SelectBidById(Bidid);
    }

    public List<BidDTO> SelectBidByJobId(long JobId)
    {
        biddal = new BidDAL();
        return biddal.SelectBidByJobId(JobId);
    }

    public List<BidDTO> SelectBidByProviderId(long ProviderId, int PageNo, int PageSize)
    {
        biddal = new BidDAL();
        return biddal.SelectBidByProviderId(ProviderId, PageNo, PageSize);
    }
}