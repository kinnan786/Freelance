using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for StoredProcedureName
/// </summary>
public class StoredProcedureName
{
	public StoredProcedureName()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public enum Names
    {
        //Provider
            AuthenticateUser,
            UpdateProviderIntroducation,
            UpdateProvider,
            SelectAllProvider,
            GetProviderIntroductionById,
            GetProviderContactById,
            ChangePassword,
            UpdateProviderContact,
            Get15NewWorkers,
            AddProvider,
            SearchProviderBYQuery,
            ProcGetProviderSkills,
            AddProviderImage,
            GetProviderImage,
            GetProviderPassword,

            //Employment
                GetEmploymentById,
                InsertEmployment,
                UpdateEmployment,
                GetEmploymentByProviderId,
                DeleteProviderEmployment,

            //Education
                GetProviderEducationByProviderId,
                AddProviderEducation,
                UpdateProviderEducation,
                DeleteProviderEducation,
                GetProviderEducationByEducationId,
            
            //Certification
                AddProviderCertification,
                GetProviderCertification,
                UpdateProviderCertification,
                GetProviderCertificationByCertificationId,
                DeleteProviderCertification,
            
            //SKILL
                GetProviderSkills,
                AddProviderSkill,
                UpdateProviderSkill,
                DeleteProviderSkill,
                GetSkillByCategory,
                GetProviderSkillBySkillIDAndProviderID,
                GetAllSkillCategory,

        //Bid
            InsertBid,
            SelectAllBid,
            SelectBidById,
            UpdateBid,
            SelectBidByJobId,
            SelectBidByProviderId,

        //JobProject
            InsertProject,
            SelectAllProject,
            UpdateProject,
            SelectProjectById,
            SelectProjectByProviderId,
            Get15NewProjects,
            SearchProjectBYQuery,
            GetProjectCount,
            GetProjectsPaged,

        //Category
            GetCategory,
            GetSubCategory,
            GetProjectCategories,

        //SeoPage
            AddSeoPage,

        //Statistics
            GetStatistics
    
    }
}