using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderCertificationDTO
/// </summary>
public class ProviderCertificationDTO
{
	public ProviderCertificationDTO()
	{
		providerId =0;
        certificationId = 0;
        certificationName ="";
        yearCompleted="";
        score=0;
        percentage=0;
        description="";
	}

    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }
    private long certificationId;

    public long CertificationId
    {
        get { return certificationId; }
        set { certificationId = value; }
    }
    private string certificationName;

    public string CertificationName
    {
        get { return certificationName; }
        set { certificationName = value; }
    }
    private string yearCompleted;

    public string YearCompleted
    {
        get { return yearCompleted; }
        set { yearCompleted = value; }
    }
    private int score;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }
    private Int16 percentage;

    public Int16 Percentage
    {
        get { return percentage; }
        set { percentage = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

}