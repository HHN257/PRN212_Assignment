using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface ICandidateProfileRepo
    {
        public CandidateProfile GetCandidateProfile(String id);
        public List<CandidateProfile> GetCandidateProfiles();
        public bool AddCandidateProfile(CandidateProfile CandidateProfile);
        public bool DeleteCandidateProfile(String profileID);
        public bool UpdateCandidateProfile(CandidateProfile CandidateProfile);
    }
}
