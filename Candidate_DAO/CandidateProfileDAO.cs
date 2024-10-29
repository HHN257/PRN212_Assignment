using Candidate_BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext dbcontext;
        private static CandidateProfileDAO instance;

		public static CandidateProfileDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CandidateProfileDAO();
				}
				return instance;
			}

		}

		public CandidateProfileDAO()
        {
            dbcontext = new CandidateManagementContext();
        }

        
        public CandidateProfile GetCandidateProfileById(String id)
        {
			return dbcontext.CandidateProfiles.Include(c => c.Posting).SingleOrDefault(m => m.CandidateId.Equals(id));
		}

        public List<CandidateProfile> GetCandidateProfiles()
        {
			return dbcontext.CandidateProfiles.Include(c => c.Posting).ToList();
		}

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
			CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);
			try
            {
                if (candidate == null)
                {
                    dbcontext.CandidateProfiles.Add(candidateProfile);
                    dbcontext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // Show the detailed error message including any inner exceptions

                //MessageBox.Show($"An error occurred while adding the candidate profile: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}");
                // Use 'throw;' to keep the original exception details, if you need to propagate it further
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }



        public bool DeleteCandidateProfile(String profileId)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(profileId);
            try
            {
                if (candidateProfile != null)
                {
                    //context.CandidateProfiles.Add(candidateProfile);
                    dbcontext.CandidateProfiles.Remove(candidateProfile);
                    dbcontext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }


        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(candidate.CandidateId);
            try
            {
                if (candidateProfile != null)
                {
					candidateProfile.Fullname = candidate.Fullname;
					candidateProfile.Birthday = candidate.Birthday;
					candidateProfile.ProfileShortDescription = candidate.ProfileShortDescription;
					candidateProfile.ProfileUrl = candidate.ProfileUrl;
					candidateProfile.PostingId = candidate.PostingId;

					dbcontext.Entry<CandidateProfile>(candidateProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbcontext.Update<CandidateProfile>(candidateProfile);
					dbcontext.SaveChanges();
					isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

    }
}
