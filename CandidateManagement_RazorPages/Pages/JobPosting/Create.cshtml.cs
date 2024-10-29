using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BusinessObject;
using Candidate_DAO;

namespace CandidateManagement_RazorPages.Pages.JobPosting
{
    public class CreateModel : PageModel
    {
        private readonly Candidate_DAO.CandidateManagementContext _context;

        public CreateModel(Candidate_DAO.CandidateManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Candidate_BusinessObject.JobPosting JobPosting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.JobPostings == null || JobPosting == null)
            {
                return Page();
            }

            _context.JobPostings.Add(JobPosting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
