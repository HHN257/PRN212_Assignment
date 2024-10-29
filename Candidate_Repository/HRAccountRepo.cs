using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class HRAccountRepo : IHRAccountRepo
    {
        public Hraccount getHRAccountByEmail(string email) => HRAccountDAO.Instance.getHRAccountByEmail(email);

        public List<Hraccount> GetHraccounts() => HRAccountDAO.Instance.GetHraccounts();

        public List<Hraccount> GetHraccountsByEmail() => HRAccountDAO.Instance.GetHraccounts();
    }
}
