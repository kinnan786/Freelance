using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for ProviderBL
/// </summary>
public class ProviderBL
{
    private ProviderDTO provider;
    private ProviderDAL providerdal;

	public ProviderBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public long InsertProvider(ProviderDTO Provider)
    { 
        providerdal = new ProviderDAL();
        return providerdal.InsertProvider(Provider);
    }

    public int UpdateProvider(ProviderDTO Provider)
    {
        providerdal = new ProviderDAL();
        return providerdal.UpdateProvider(Provider);
    }

    public int UpdateProviderIntroducation(ProviderDTO Provider)
    {
        providerdal = new ProviderDAL();
        return providerdal.UpdateProviderIntroducation(Provider);
    }
    public List<ProviderDTO> SelectAllProvider(int PageNo, int PageSize)
    {
        providerdal = new ProviderDAL();
        return providerdal.SelectAllProvider( PageNo, PageSize);
    }

    public ProviderDTO GetProviderIntroductionById(long ProviderId)
    {
        providerdal = new ProviderDAL();
        return providerdal.GetProviderIntroductionById(ProviderId);
    }

    public long AuthenticateUser(ProviderDTO provider)
    {
        providerdal = new ProviderDAL();
        return providerdal.AuthenticateUser(provider);
    }

    public bool ChangePassword(ProviderDTO provider, string NewPassword)
    {
        int result = 0;
        providerdal = new ProviderDAL();
        result =  providerdal.ChangePassword(provider, NewPassword);

        if (result > 0)
            return true;
        return false;
    }

    public long UpdateProviderContact(ProviderDTO Provider)
    {
        providerdal = new ProviderDAL();
        return providerdal.UpdateProviderContact(Provider);
    }

    public ProviderDTO GetProviderContactById(long ProviderId)
    {
        providerdal = new ProviderDAL();
        return providerdal.GetProviderContactById(ProviderId);
    }

    public void AddProviderImage(long providerid, byte[] imagename)
    {
        providerdal = new ProviderDAL();
        providerdal.AddProviderImage(providerid, imagename);
    }

    public Stream GetProviderImage(long providerid)
    {
        providerdal = new ProviderDAL();
        return providerdal.GetProviderImage(providerid);
    }

    public ProviderDTO GetProviderPassword(long providerid)
    {
        providerdal = new ProviderDAL();
        return providerdal.GetProviderPassword(providerid);
    }
}