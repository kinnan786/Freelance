using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StatisticsBL
/// </summary>
public class StatisticsBL
{
    private StatisticsDAL statisticsdal;

	public StatisticsBL()
	{
		
	}

    public string[] GetWebStatistics()
    {
        statisticsdal = new StatisticsDAL();
        return statisticsdal.GetWebStatistics();
    }
}