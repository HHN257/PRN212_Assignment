using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObject;
using Candidate_DAO;

namespace CandidateManagement_RazorPages.Pages.CandidateManage
{
    public class IndexModel : PageModel
    {
        private readonly Candidate_DAO.CandidateManagementContext _context;

        public IndexModel(Candidate_DAO.CandidateManagementContext context)
        {
            _context = context;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CandidateProfiles != null)
            {
                CandidateProfile = await _context.CandidateProfiles
                .Include(c => c.Posting).ToListAsync();
            }
        }
    }
}
