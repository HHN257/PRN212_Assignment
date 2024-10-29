﻿using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface IHRAccountService
    {
        public Hraccount getHRAccountByEmail(String email);

        public List<Hraccount> GetHraccounts();
    }
}
