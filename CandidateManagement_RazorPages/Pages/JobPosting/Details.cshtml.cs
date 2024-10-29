﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObject;
using Candidate_DAO;

namespace CandidateManagement_RazorPages.Pages.JobPosting
{
    public class DetailsModel : PageModel
    {
        private readonly Candidate_DAO.CandidateManagementContext _context;

        public DetailsModel(Candidate_DAO.CandidateManagementContext context)
        {
            _context = context;
        }

      public Candidate_BusinessObject.JobPosting JobPosting { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.JobPostings == null)
            {
                return NotFound();
            }

            var jobposting = await _context.JobPostings.FirstOrDefaultAsync(m => m.PostingId == id);
            if (jobposting == null)
            {
                return NotFound();
            }
            else 
            {
                JobPosting = jobposting;
            }
            return Page();
        }
    }
}