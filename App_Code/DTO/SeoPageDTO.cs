using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SeoPage
/// </summary>
public class SeoPageDTO
{

    private string pageName;

    public string PageName
    {
        get { return pageName; }
        set { pageName = value; }
    }
    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private string content;

    public string Content
    {
        get { return content; }
        set { content = value; }
    }

	public SeoPageDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}


}