<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
      //RegisterRoutess(System.Web.Routing.RouteTable.Routes);
    }

    private static void RegisterRoutess(System.Web.Routing.RouteCollection Routes)
    {
        Routes.Add("EmpOperation", new System.Web.Routing.Route("{action}/{url}-{Id}", new FreelanceRouteHandler()));
        //Routes.Add(new System.Web.Routing.Route("{action}-{id}.aspx", new FreelanceRouteHandler()));
       // Routes.Add(new System.Web.Routing.Route("{controller}/{action}/{id}", new FreelanceRouteHandler()));
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
