using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobProjectDTO
/// </summary>
public class ProjectDTO
{
	public ProjectDTO()
	{
        projectId = 0;
        projectTitle = "";
        description = "";
        projectCategory = "";
        budget = "";
        providerId = 0;
        ProjectsubCategory = "";
        projectCategory = "";
        projectCreatedOn = null;
        bidOpenTill = null;
        providerName = null;
        plannedStart = "";
	}

    private long projectId;

    public long ProjectId
    {
        get { return projectId; }
        set { projectId = value; }
    }
    private string projectTitle;

    public string ProjectTitle
    {
        get { return projectTitle; }
        set { projectTitle = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private string projectCategory;

    public string ProjectCategory
    {
        get { return projectCategory; }
        set { projectCategory = value; }
    }
    private string budget;

    public string Budget
    {
        get { return budget; }
        set { budget = value; }
    }
    private long providerId;

    public long ProviderId
    {
        get { return providerId; }
        set { providerId = value; }
    }

    private string projectSkills;

    public string ProjectSkills
    {
        get { return projectSkills; }
        set { projectSkills = value; }
    }

    private string projectsubCategory;

    public string ProjectsubCategory
    {
        get { return projectsubCategory; }
        set { projectsubCategory = value; }
    }

    private DateTime? bidOpenTill;

    public DateTime? BidOpenTill
    {
        get { return bidOpenTill; }
        set { bidOpenTill = value; }
    }

    private DateTime? projectCreatedOn;

    public DateTime? ProjectCreatedOn
    {
        get { return projectCreatedOn; }
        set { projectCreatedOn = value; }
    }
    private string projectLocation;

    public string ProjectLocation
    {
        get { return projectLocation; }
        set { projectLocation = value; }
    }

    private string providerName;

    public string ProviderName
    {
        get { return providerName; }
        set { providerName = value; }
    }

    private int bidCount;

    public int BidCount
    {
        get { return bidCount; }
        set { bidCount = value; }
    }

    private string plannedStart;

    public string PlannedStart
    {
        get { return plannedStart; }
        set { plannedStart = value; }
    }

    private string projectStatus;

    public string ProjectStatus
    {
        get { return projectStatus; }
        set { projectStatus = value; }
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

}