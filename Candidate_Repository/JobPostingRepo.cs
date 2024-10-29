using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public JobPosting GetJobPostingByID(string jobID) => JobPostingDAO.Instance.GetJobPostingByID(jobID);


        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();

    }
}
