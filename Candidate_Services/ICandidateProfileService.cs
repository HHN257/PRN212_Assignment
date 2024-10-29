using Candidate_BusinessObject;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface ICandidateProfileService
    {
        public CandidateProfile GetCandidateProfile(String id);

        public List<CandidateProfile> GetCandidateProfiles();

        public bool AddCandidateProfile(CandidateProfile CandidateProfile);
        public bool DeleteCandidateProfile(String profileID);
        public bool UpdateCandidateProfile(CandidateProfile CandidateProfile);
    }
}
