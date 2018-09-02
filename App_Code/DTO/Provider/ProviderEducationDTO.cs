using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ProviderEducationDTO
/// </summary>
public class ProviderEducationDTO
{
	public ProviderEducationDTO()
	{
		providerId=0;
        educationId=0;
        institutionName="";
        degreeTitle="";
        yearCompleted = "";
	}

    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }
    private long educationId;

    public long EducationId
    {
        get { return educationId; }
        set { educationId = value; }
    }
    private string institutionName;

    public string InstitutionName
    {
        get { return institutionName; }
        set { institutionName = value; }
    }
    private string degreeTitle;

    public string DegreeTitle
    {
        get { return degreeTitle; }
        set { degreeTitle = value; }
    }
    private string yearCompleted;

    public string YearCompleted
    {
        get { return yearCompleted; }
        set { yearCompleted = value; }
    }
}