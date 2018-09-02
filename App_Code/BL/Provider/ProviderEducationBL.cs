using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ProviderEducationBL
/// </summary>
public class ProviderEducationBL
{
    private ProviderEducationDTO ProviderEducation;
    private ProviderEducationDAL ProviderEducationdal;
    private List<ProviderEducationDTO> ProviderEducationList; 

    public ProviderEducationBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public long AddProviderEducation(ProviderEducationDTO providereducation)
    {
        ProviderEducationdal = new ProviderEducationDAL();
        return ProviderEducationdal.AddProviderEducation(providereducation);
    }

    public List<ProviderEducationDTO> GetProviderEducationByProviderId(long ProviderId)
    {
        ProviderEducationdal = new ProviderEducationDAL();
        return ProviderEducationdal.GetProviderEducationByProviderId(ProviderId);
    }

    public int UpdateProviderEducation(ProviderEducationDTO providereducation)
    {
        ProviderEducationdal = new ProviderEducationDAL();
        return ProviderEducationdal.UpdateProviderEducation(providereducation);
    }

    public void DeleteProviderEducation(long providerid, long educationid)
    {
        ProviderEducationdal = new ProviderEducationDAL();
        ProviderEducationdal.DeleteProviderEducation(providerid, educationid);
    }

    public ProviderEducationDTO GetProviderEducationByEducationId(long providerid, long educationid)
    {
        ProviderEducationdal = new ProviderEducationDAL();
        return ProviderEducationdal.GetProviderEducationByEducationId(providerid, educationid);
    }
}