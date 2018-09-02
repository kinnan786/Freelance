using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for SeoPageDAL
/// </summary>
public class SeoPageDAL
{
    private SeoPageDTO Page;
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;
    private List<SeoPageDTO> Pages;
    private short pageid;

	public SeoPageDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public short AddSeoPage(ProjectDTO Project)
    {
        command = new SqlCommand(StoredProcedureName.Names.AddSeoPage.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@PageName", SqlDbType.VarChar);
        command.Parameters.Add("@Title", SqlDbType.VarChar);
        command.Parameters.Add("@Description", SqlDbType.VarChar);
        command.Parameters.Add("@Content", SqlDbType.VarChar);
     
        command.Parameters[0].Value = Project.ProviderId;
        command.Parameters[1].Value = Project.ProjectTitle;
        command.Parameters[2].Value = Project.Description;
        command.Parameters[3].Value = Project.ProjectCategory;


        pageid = 0;

        connection.Open();

        pageid = (Int16)command.ExecuteNonQuery();

        connection.Close();

        return pageid;
    }



}