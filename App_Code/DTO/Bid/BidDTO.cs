using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BidDTO
/// </summary>
public class BidDTO
{
	public BidDTO()
	{
        bidId = 0;
        jobId = 0;
        providerId = 0;
        amount = "";
        description = "";
        advancePayment = 0;
        duration = "";
        projectTitle = "";
	}

    private long bidId;

    public long BidId
    {
        get { return bidId; }
        set { bidId = value; }
    }
    private long jobId;

    public long JobId
    {
        get { return jobId; }
        set { jobId = value; }
    }

    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }
    private string amount;

    public string Amount
    {
        get { return amount; }
        set { amount = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private string providerName;

    public string ProviderName
    {
        get { return providerName; }
        set { providerName = value; }
    }
    private string providerSkill;

    public string ProviderSkill
    {
        get { return providerSkill; }
        set { providerSkill = value; }
    }
    private string providerCountry;

    public string ProviderCountry
    {
        get { return providerCountry; }
        set { providerCountry = value; }
    }

    private DateTime bidOn;

    public DateTime BidOn
    {
        get { return bidOn; }
        set { bidOn = value; }
    }

    private Int16 advancePayment;

    public Int16 AdvancePayment
    {
        get { return advancePayment; }
        set { advancePayment = value; }
    }

    private string duration;

    public string Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    private int totalRec;

    public int TotalRec
    {
        get { return totalRec; }
        set { totalRec = value; }
    }
    private int totalPage;

    public int TotalPage
    {
        get { return totalPage; }
        set { totalPage = value; }
    }

    private string providerSkills;

    public string ProviderSkills
    {
        get { return providerSkills; }
        set { providerSkills = value; }
    }

    private string projectTitle;

    public string ProjectTitle
    {
        get { return projectTitle; }
        set { projectTitle = value; }
    }


}