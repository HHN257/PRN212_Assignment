using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostingDAO
    {
        private CandidateManagementContext dbcontext;
        private static JobPostingDAO instance;

        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }

        }
        public JobPostingDAO()
        {
            dbcontext = new CandidateManagementContext();
        }

        public JobPosting GetJobPostingByID(String jobID)
        {
            return dbcontext.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobID));
        }

        public List<JobPosting> GetJobPostings()
        {
            return dbcontext.JobPostings.ToList();
        }
    }
}
