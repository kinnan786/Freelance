using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Compilation;
using System.Web.UI;

/// <summary>
/// Summary description for FreelanceRouteHandler
/// </summary>
public class FreelanceRouteHandler : IRouteHandler
{
	public FreelanceRouteHandler()
	{
       // System.Diagnostics.Debugger.Break();
		//
		// TODO: Add constructor logic here
		//
	}

    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
        HttpContext context = HttpContext.Current;

        string Id = requestContext.RouteData.Values["Id"] as string;
        context.Items.Add("Id", Id);
        

        string action = requestContext.RouteData.Values["action"] as string;
        context.Items.Add("action", action);

        if (action.ToLower() == "projects" || action.ToLower() == "project")
            return BuildManager.CreateInstanceFromVirtualPath("~/Project/ViewProject.aspx", typeof(Page)) as Page;
        else
            return null;
    }
}