using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IJobPostingRepo
    {
        public JobPosting GetJobPostingByID(String jobID);

        public List<JobPosting> GetJobPostings();
    }
}
