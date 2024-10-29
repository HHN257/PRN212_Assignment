using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObject;
using Candidate_DAO;

namespace CandidateManagement_RazorPages.Pages.HRAccount
{
    public class IndexModel : PageModel
    {
        private readonly Candidate_DAO.CandidateManagementContext _context;

        public IndexModel(Candidate_DAO.CandidateManagementContext context)
        {
            _context = context;
        }

        public IList<Hraccount> Hraccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Hraccounts != null)
            {
                Hraccount = await _context.Hraccounts.ToListAsync();
            }
        }
    }
}
