using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderEmploymentDTO
/// </summary>
public class ProviderEmploymentDTO
{
    private long employmentId;

    public long EmploymentId
    {
        get { return employmentId; }
        set { employmentId = value; }
    }
    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }
    private string organizationName;

    public string OrganizationName
    {
        get { return organizationName; }
        set { organizationName = value; }
    }
    private string position;

    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    private string fromMonth;

    public string FromMonth
    {
        get { return fromMonth; }
        set { fromMonth = value; }
    }
    private string fromYear;

    public string FromYear
    {
        get { return fromYear; }
        set { fromYear = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private bool currentlyWorkhere;

    public bool CurrentlyWorkhere
    {
        get { return currentlyWorkhere; }
        set { currentlyWorkhere = value; }
    }
    private string responsibilities;

    public string Responsibilities
    {
        get { return responsibilities; }
        set { responsibilities = value; }
    }
    private string toMonth;

    public string ToMonth
    {
        get { return toMonth; }
        set { toMonth = value; }
    }
    private string toYear;

    public string ToYear
    {
        get { return toYear; }
        set { toYear = value; }
    }
    private string employmentSkills;

    public string EmploymentSkills
    {
        get { return employmentSkills; }
        set { employmentSkills = value; }
    }

	public ProviderEmploymentDTO()
	{
        employmentId = 0;
        providerId = 0;
        organizationName = "";
        toMonth = "";
        toYear = "";
        responsibilities = "";
        currentlyWorkhere = false;
        description = "";
        fromMonth = "";
        fromYear = "";
        position = "";
        employmentSkills = "";
	}
}