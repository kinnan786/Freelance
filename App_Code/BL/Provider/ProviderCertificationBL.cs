using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderCertificationBL
/// </summary>
public class ProviderCertificationBL
{
    private ProviderCertificationDTO ProviderCertification;
    private ProviderCertificationDAL ProviderCertificationdal;
    private List<ProviderCertificationDTO> ProviderCertificationList; 


	public ProviderCertificationBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public long AddProviderCertification(ProviderCertificationDTO providerCertification)
    {
        ProviderCertificationdal = new ProviderCertificationDAL();
        return ProviderCertificationdal.AddProviderCertification(providerCertification);
    }

    public List<ProviderCertificationDTO> GetProviderCertification(long ProviderId)
    {
        ProviderCertificationdal = new ProviderCertificationDAL();
        return ProviderCertificationdal.GetProviderCertification(ProviderId);
    }

    public long UpdateProviderCertification(ProviderCertificationDTO providerCertification)
    {
        ProviderCertificationdal = new ProviderCertificationDAL();
        return ProviderCertificationdal.UpdateProviderCertification(providerCertification);
    }

    public ProviderCertificationDTO GetProviderCertificationByCertificationId(long providerid, long certificationid)
    {
        ProviderCertificationdal = new ProviderCertificationDAL();
        return ProviderCertificationdal.GetProviderCertificationByCertificationId(providerid, certificationid);
    }

    public long DeleteProviderCertification(long providerid, long certificationid)
    {
        ProviderCertificationdal = new ProviderCertificationDAL();
        return ProviderCertificationdal.DeleteProviderCertification(providerid, certificationid);
    }

}