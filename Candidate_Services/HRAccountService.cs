using Candidate_BusinessObject;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo;

        public HRAccountService()
        {
            iAccountRepo = new HRAccountRepo();
        }
        public Hraccount getHRAccountByEmail(string email)
        {
            return iAccountRepo.getHRAccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return iAccountRepo.GetHraccounts();
        }
    }
}
