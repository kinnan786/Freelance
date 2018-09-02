using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProjectBL
/// </summary>
public class ProjectBL
{
    private ProjectDTO Project;
    private ProjectDAL Projectdal;

    public ProjectBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public long InsertProject(ProjectDTO project)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.InsertProject(project);
    }

    public int UpdateProject(ProjectDTO project)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.UpdateProject(project);
    }

    public List<ProjectDTO> SelectAllProject(int PageNo, int PageSize)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.SelectAllProject(PageNo, PageSize);
    }

    public ProjectDTO SelectProjectById(long ProjectId)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.SelectProjectById(ProjectId);
    }

    public List<ProjectDTO> SelectProjectByProviderId(long ProjectId, int PageNo, int PageSize)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.SelectProjectByProviderId(ProjectId, PageNo, PageSize);
    }

    public List<ProjectDTO> SearchProjectBYQuery(string searchtext, string Category, string JobType, string Postedsince, string TimeLeft, string Skills)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.SearchProjectBYQuery(searchtext, Category, JobType, Postedsince, TimeLeft, Skills);
    }

    public long projectcount()
    {
        Projectdal = new ProjectDAL();
        return Projectdal.ProjectCount();
    }

    public List<ProjectDTO> GetProjectsPaged(int startRowIndex, int maximumRows)
    {
        Projectdal = new ProjectDAL();
        return Projectdal.GetProjectsPaged(startRowIndex, maximumRows);
    }
}