using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for StatisticsDAL
/// </summary>
public class StatisticsDAL
{
    private string connectionstring;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader datareader;

	public StatisticsDAL()
	{
        connectionstring = ConfigurationManager.ConnectionStrings["FreelancingConnectionString"].ConnectionString.ToString();
        connection = new SqlConnection(connectionstring);
	}

    public string[] GetWebStatistics()
    {
        string[] str = new string[2];
    
        command = new SqlCommand(StoredProcedureName.Names.GetStatistics.ToString(), connection);
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();
        datareader = command.ExecuteReader();

        if (!datareader.HasRows)
            return null;
        while (datareader.Read())
        {
            str[0] = datareader["TotalProjects"].ToString();
            str[1] = datareader["TotalProviders"].ToString();

        }
        connection.Close();

        return str;
    }
}