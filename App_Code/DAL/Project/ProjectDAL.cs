using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for ProjectProjectDAL
/// </summary>
public class ProjectDAL
{
    private ProjectDTO Project;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private List<ProjectDTO> projects;

	public ProjectDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public long InsertProject(ProjectDTO Project)
    {
        command = new SqlCommand(StoredProcedureName.Names.InsertProject.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProviderId", SqlDbType.BigInt);
        command.Parameters.Add("@ProjectTitle", SqlDbType.VarChar);
        command.Parameters.Add("@Description", SqlDbType.Text);
        command.Parameters.Add("@ProjectCategory", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Budget", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ProjectSkills", SqlDbType.VarChar);
        command.Parameters.Add("@ProjectSubCategory", SqlDbType.VarChar);
        command.Parameters.Add("@ProjectCreatedOn", SqlDbType.DateTime);
        command.Parameters.Add("@BidOpenTill", SqlDbType.DateTime);
        command.Parameters.Add("@ProjectLocation", SqlDbType.VarChar);
        command.Parameters.Add("@PlannedStart", SqlDbType.VarChar);
       
        command.Parameters[0].Value = Project.ProviderId;
        command.Parameters[1].Value = Project.ProjectTitle;
        command.Parameters[2].Value = Project.Description;
        command.Parameters[3].Value = Project.ProjectCategory;
        command.Parameters[4].Value = Project.Budget;
        command.Parameters[5].Value = Project.ProjectSkills;
        command.Parameters[6].Value = Project.ProjectsubCategory;
        command.Parameters[7].Value = Project.ProjectCreatedOn;
        command.Parameters[8].Value = Project.BidOpenTill;
        command.Parameters[9].Value = Project.ProjectLocation;
        command.Parameters[10].Value = Project.PlannedStart;


        long Projectid = 0;

        connection.Open();

        Projectid = command.ExecuteNonQuery();

        connection.Close();

        return Projectid;
    }

    public int UpdateProject(ProjectDTO Project)
    {
        command = new SqlCommand(StoredProcedureName.Names.UpdateProject.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProjectId", SqlDbType.BigInt);
        command.Parameters.Add("@ProjectTitle", SqlDbType.VarChar);
        command.Parameters.Add("@Description", SqlDbType.VarChar);
        command.Parameters.Add("@ProjectCategory", SqlDbType.VarChar, 100);
        command.Parameters.Add("@Budget", SqlDbType.VarChar, 50);
        command.Parameters.Add("@ProjectSkills", SqlDbType.VarChar);
        command.Parameters.Add("@ProjectSubCategory", SqlDbType.VarChar);
        command.Parameters.Add("@BidOpenTill", SqlDbType.DateTime);
        command.Parameters.Add("@ProjectLocation", SqlDbType.VarChar);
        command.Parameters.Add("@Plannedstart", SqlDbType.VarChar);

        command.Parameters[0].Value = Project.ProjectId;
        command.Parameters[1].Value = Project.ProjectTitle;
        command.Parameters[2].Value = Project.Description;
        command.Parameters[3].Value = Project.ProjectCategory;
        command.Parameters[4].Value = Project.Budget;
        command.Parameters[5].Value = Project.ProjectSkills;
        command.Parameters[6].Value = Project.ProjectsubCategory;
        command.Parameters[7].Value = Project.BidOpenTill;
        command.Parameters[8].Value = Project.ProjectLocation;
        command.Parameters[9].Value = Project.PlannedStart;


        int rowaffected = 0;

        connection.Open();

        rowaffected = command.ExecuteNonQuery();

        connection.Close();

        return rowaffected;
    }

    public List<ProjectDTO> SelectAllProject(int PageNo, int PageSize)
    {
        projects = new List<ProjectDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SelectAllProject.ToString(), connection);
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
            Project = new ProjectDTO();
            Project.ProjectId = Convert.ToInt64(datareader["ProjectId"]);
            Project.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            Project.ProjectTitle = datareader["ProjectTitle"].ToString();
            Project.Description = datareader["Description"].ToString();
            Project.ProjectCategory = datareader["ProjectCategory"].ToString();
            Project.Budget = datareader["Budget"].ToString();
            Project.ProjectSkills = Convert.ToString(datareader["ProjectSkills"]);
            Project.ProjectCreatedOn = Convert.ToDateTime(datareader["ProjectCreatedOn"]);
            Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"]);
            Project.ProjectLocation = Convert.ToString(datareader["ProjectLocation"]);
            Project.ProjectsubCategory = datareader["ProjectSubCategory"].ToString();
            Project.ProviderName = datareader["ProviderName"].ToString();
            Project.BidCount = Convert.ToInt32(datareader["bidcount"]);
            Project.PlannedStart = datareader["PlannedStart"].ToString();
            Project.TotalPage = Convert.ToInt32(datareader["TotalPage"].ToString());
            Project.TotalRec = Convert.ToInt32(datareader["TotalRec"].ToString());
            projects.Add(Project);
        }
        connection.Close();
        return projects;
    }


    public ProjectDTO SelectProjectById(long ProjectId)
    {
        command = new SqlCommand(StoredProcedureName.Names.SelectProjectById.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@ProjectId", SqlDbType.BigInt);

        command.Parameters[0].Value = ProjectId;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Project = new ProjectDTO();
            Project.ProviderName = datareader["ProviderName"].ToString();
            Project.ProjectId = Convert.ToInt64(datareader["ProjectId"]);
            Project.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            Project.ProjectTitle = datareader["ProjectTitle"].ToString();
            Project.Description = datareader["Description"].ToString();
            Project.ProjectCategory = datareader["ProjectCategory"].ToString();
            Project.Budget = datareader["Budget"].ToString();
            Project.ProjectSkills = Convert.ToString(datareader["ProjectSkills"]);
            Project.ProjectsubCategory = Convert.ToString(datareader["ProjectSubCategory"]);

            if ((DateTime)datareader["ProjectCreatedOn"] > System.Data.SqlTypes.SqlDateTime.MinValue.Value)
                Project.ProjectCreatedOn = (DateTime)datareader["ProjectCreatedOn"];
            else
                Project.ProjectCreatedOn = null;

            if ((DateTime)datareader["ProjectEndDate"] > System.Data.SqlTypes.SqlDateTime.MinValue.Value)
              Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"]);
            else
                Project.BidOpenTill = null;

            Project.ProjectLocation = Convert.ToString(datareader["ProjectLocation"]);
            Project.ProjectSkills = datareader["ProjectSkills"].ToString();
            Project.ProjectsubCategory = datareader["ProjectSubCategory"].ToString();
            Project.ProjectCreatedOn = Convert.ToDateTime(datareader["ProjectCreatedOn"].ToString());
            Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"].ToString());
            Project.ProjectLocation = datareader["ProjectLocation"].ToString();
            Project.PlannedStart = datareader["PlannedStart"].ToString();
        }
        connection.Close();
        return Project;
    }

    public List<ProjectDTO> SelectProjectByProviderId(long ProviderId, int PageNo, int PageSize)
    {
        projects = new List<ProjectDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SelectProjectByProviderId.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@VProviderId", SqlDbType.Int);
        command.Parameters.Add("@pageno", SqlDbType.Int);
        command.Parameters.Add("@pageSize", SqlDbType.Int);

        command.Parameters[0].Value = ProviderId;
        command.Parameters[1].Value = PageNo;
        command.Parameters[2].Value = PageSize;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Project = new ProjectDTO();
            Project.ProjectId = Convert.ToInt64(datareader["ProjectId"]);
            Project.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            Project.ProjectTitle = datareader["ProjectTitle"].ToString();
            Project.Description = datareader["Description"].ToString();
            Project.ProjectCategory = datareader["ProjectCategory"].ToString();
            Project.Budget = datareader["Budget"].ToString();
            Project.ProjectSkills = Convert.ToString(datareader["ProjectSkills"]);
            Project.ProjectsubCategory = Convert.ToString(datareader["ProjectSubCategory"]);
            Project.ProjectLocation = Convert.ToString(datareader["ProjectLocation"]);
            Project.ProjectCreatedOn = Convert.ToDateTime(datareader["ProjectCreatedOn"].ToString());
            Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"].ToString());
            Project.BidCount = Convert.ToInt32(datareader["Bidcount"].ToString());
            Project.ProviderName = datareader["ProviderName"].ToString();
            Project.PlannedStart = datareader["PlannedStart"].ToString();
            Project.TotalPage = Convert.ToInt32(datareader["TotalPage"].ToString());
            Project.TotalRec = Convert.ToInt32(datareader["TotalRec"].ToString());
            projects.Add(Project);
        }
        connection.Close();
        return projects;
    }

    public List<ProjectDTO> SearchProjectBYQuery(string searchtext, string Category, string JobType, string Postedsince, string TimeLeft, string Skills)
    {
        projects = new List<ProjectDTO>();

        command = new SqlCommand(StoredProcedureName.Names.SearchProjectBYQuery.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@SearchText", SqlDbType.VarChar);
        command.Parameters.Add("@Category", SqlDbType.VarChar);
        command.Parameters.Add("@JobType", SqlDbType.VarChar);
        command.Parameters.Add("@Postedsince", SqlDbType.VarChar);
        command.Parameters.Add("@TimeLeft", SqlDbType.VarChar);
        command.Parameters.Add("@Skills", SqlDbType.VarChar);

        command.Parameters[0].Value = searchtext;
        command.Parameters[1].Value = Category;
        command.Parameters[2].Value = JobType;
        command.Parameters[3].Value = Postedsince;
        command.Parameters[4].Value = TimeLeft;
        command.Parameters[5].Value = Skills;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Project = new ProjectDTO();
            Project.ProjectId = Convert.ToInt64(datareader["ProjectId"]);
            Project.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            Project.ProjectTitle = datareader["ProjectTitle"].ToString();
            Project.Description = datareader["Description"].ToString();
            Project.ProjectCategory = datareader["ProjectCategory"].ToString();
            Project.Budget = datareader["Budget"].ToString();
            Project.ProjectSkills = Convert.ToString(datareader["ProjectSkills"]);
            Project.ProjectsubCategory = Convert.ToString(datareader["ProjectSubCategory"]);
            Project.ProjectLocation = Convert.ToString(datareader["ProjectLocation"]);
            Project.ProjectCreatedOn = Convert.ToDateTime(datareader["ProjectCreatedOn"].ToString());
            Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"].ToString());
            Project.BidCount = Convert.ToInt32(datareader["Bidcount"].ToString());
            Project.ProviderName = datareader["ProviderName"].ToString();
            Project.PlannedStart = datareader["PlannedStart"].ToString();
            Project.ProjectStatus = datareader["ProjectStatus"].ToString();

            projects.Add(Project);
        }
        connection.Close();
        return projects;
    }

    public long ProjectCount()
    {
        long projectcount;

        command = new SqlCommand(StoredProcedureName.Names.GetProjectCount.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();
        projectcount = (long)command.ExecuteScalar();
        connection.Close();

        return projectcount;
    }


    public List<ProjectDTO> GetProjectsPaged(int startRowIndex, int maximumRows)
    {
        projects = new List<ProjectDTO>();

        command = new SqlCommand(StoredProcedureName.Names.GetProjectsPaged.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        command.Parameters.Add("@startRowIndex", SqlDbType.Int);
        command.Parameters.Add("@maximumRows", SqlDbType.Int);

        command.Parameters[0].Value = startRowIndex;
        command.Parameters[1].Value = maximumRows;

        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            Project = new ProjectDTO();
            Project.ProjectId = Convert.ToInt64(datareader["ProjectId"]);
            Project.ProviderId = Convert.ToInt64(datareader["ProviderId"]);
            Project.ProjectTitle = datareader["ProjectTitle"].ToString();
            Project.Description = datareader["Description"].ToString();
            Project.ProjectCategory = datareader["ProjectCategory"].ToString();
            Project.Budget = datareader["Budget"].ToString();
            Project.ProjectSkills = Convert.ToString(datareader["ProjectSkills"]);
            Project.ProjectCreatedOn = Convert.ToDateTime(datareader["ProjectCreatedOn"]);
            Project.BidOpenTill = Convert.ToDateTime(datareader["ProjectEndDate"]);
            Project.ProjectLocation = Convert.ToString(datareader["ProjectLocation"]);
            Project.ProjectsubCategory = datareader["ProjectSubCategory"].ToString();
            //Project.ProviderName = datareader["ProviderName"].ToString();
            //Project.BidCount = Convert.ToInt32(datareader["bidcount"]);
            Project.PlannedStart = datareader["PlannedStart"].ToString();
            projects.Add(Project);
        }
        connection.Close();
        return projects;
    }
}