<%@ WebHandler Language="C#" Class="ShowImage" %>

using System;
using System.Web;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;

public class ShowImage : IHttpHandler 
{
    private string tablename;
    private string columnname;
    private string pkcolumname;
    private int id;
   
    
    public void ProcessRequest(HttpContext context)
    {
       if (context.Request.QueryString["ProviderId"] != null )
            id = Convert.ToInt32(context.Request.QueryString["ProviderId"]);

       context.Response.ContentType = "image/jpeg";
       Stream strm = new ProviderBL().GetProviderImage(id);

       if (strm != null)
       {
           byte[] buffer = new byte[Convert.ToInt32(strm.Length)];
           int byteSeq = strm.Read(buffer, 0, Convert.ToInt32(strm.Length));

           while (byteSeq > 0)
           {
               context.Response.OutputStream.Write(buffer, 0, byteSeq);
               byteSeq = strm.Read(buffer, 0, Convert.ToInt32(strm.Length));
           }
           context.Response.BinaryWrite(buffer);
       }
    }
    
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    public byte[] imageToByteArray(System.Drawing.Image imageIn)
    {
        MemoryStream ms = new MemoryStream();
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        return ms.ToArray();
    }
}