using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProviderEmploymentBL
/// </summary>
public class ProviderEmploymentBL
{
    private ProviderEmploymentDTO ProviderEmployment;
    private ProviderEmploymentDAL ProviderEmploymentdal;

    public ProviderEmploymentBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public long InsertProviderEmployment(ProviderEmploymentDTO provideremployment)
    {
        ProviderEmploymentdal = new ProviderEmploymentDAL();
        return ProviderEmploymentdal.InsertEmployment(provideremployment);
    }

    public int UpdateProviderEmployment(ProviderEmploymentDTO provideremployment)
    {
        ProviderEmploymentdal = new ProviderEmploymentDAL();
        return ProviderEmploymentdal.UpdateProviderEmployment(provideremployment);
    }

    public ProviderEmploymentDTO GetEmploymentById(long EmploymentId, long ProviderId)
    {
        ProviderEmploymentdal = new ProviderEmploymentDAL();
        return ProviderEmploymentdal.GetEmploymentById(EmploymentId, ProviderId);
    }

    public List<ProviderEmploymentDTO> GetEmploymentByProviderId(long ProviderId)
    {
        ProviderEmploymentdal = new ProviderEmploymentDAL();
        return ProviderEmploymentdal.GetEmploymentByProviderId(ProviderId);
    }

    public void DeleteProviderEmployment(long providerid, long employmentid)
    {
        ProviderEmploymentdal = new ProviderEmploymentDAL();
        ProviderEmploymentdal.DeleteProviderEmployment(providerid, employmentid);
    }


}