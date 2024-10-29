using Candidate_BusinessObject;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private ICandidateProfileRepo profileRepo;

        public CandidateProfileService()
        {
            profileRepo = new CandidateProfileRepo();
        }
        public bool AddCandidateProfile(CandidateProfile CandidateProfile)
        {
            return profileRepo.AddCandidateProfile(CandidateProfile);
        }

        public bool DeleteCandidateProfile(string profileID)
        {
            return profileRepo.DeleteCandidateProfile(profileID);
        }

        public CandidateProfile GetCandidateProfile(string id)
        {
            return profileRepo.GetCandidateProfile(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return profileRepo.GetCandidateProfiles();
        }

        public bool UpdateCandidateProfile(CandidateProfile CandidateProfile)
        {
            return profileRepo.UpdateCandidateProfile(CandidateProfile);
        }
    }
}
