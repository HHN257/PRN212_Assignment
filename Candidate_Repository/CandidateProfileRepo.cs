using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        public bool AddCandidateProfile(CandidateProfile CandidateProfile) => CandidateProfileDAO.Instance.AddCandidateProfile(CandidateProfile);

        public bool DeleteCandidateProfile(string profileID) => CandidateProfileDAO.Instance.DeleteCandidateProfile(profileID);

        public CandidateProfile GetCandidateProfile(string id) => CandidateProfileDAO.Instance.GetCandidateProfileById(id);

        public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDAO.Instance.GetCandidateProfiles();

        public bool UpdateCandidateProfile(CandidateProfile CandidateProfile) => CandidateProfileDAO.Instance.UpdateCandidateProfile(CandidateProfile);
    }
}
