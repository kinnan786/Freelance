using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class Provider_ProviderImage : System.Web.UI.Page
{
    private ProviderBL providerbl;
    private HttpCookie cookie;
    private long ProviderId;
    private ProviderDTO providerdto;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetCookie();
        providerbl = new ProviderBL();

        if (providerbl.GetProviderImage(ProviderId) != null)
            ImgPic.ImageUrl = "~/ShowImage.ashx?ProviderId=" + ProviderId.ToString();
        else
            ImgPic.ImageUrl = "~/Images/nopicture.gif";

    }

    private void GetCookie()
    {
        cookie = this.Request.Cookies["Freelancing"];

        if (cookie != null)
        {
            ProviderId = Convert.ToInt64(cookie["ProviderId"]);
        }

    }

    protected void BtnImgSave_Click(object sender, System.EventArgs e)
    {
        GetCookie();
       providerbl = new ProviderBL();

       if (ImgUpld.HasFile && ImgUpld.PostedFile != null)
       {
           byte[] FrontImgByte = null;
           //To create a PostedFile
           HttpPostedFile File = ImgUpld.PostedFile;
           //Create byte Array with file len
           FrontImgByte = new Byte[File.ContentLength];
           //force the control to load data in array
           File.InputStream.Read(FrontImgByte, 0, File.ContentLength);
           providerbl.AddProviderImage(ProviderId, FrontImgByte);
       }
      
    }

    public bool ThumbnailCallback()
    {
        return false;
    }
}