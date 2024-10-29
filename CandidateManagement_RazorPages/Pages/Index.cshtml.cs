using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Candidate_Repository;
using Candidate_BusinessObject;

namespace CandidateManagement_RazorPages.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly IHRAccountRepo _hraccountRepo;
		public IndexModel(ILogger<IndexModel> logger, IHRAccountRepo hraccountRepo)
		{
			_logger = logger;
			_hraccountRepo = hraccountRepo;
		}

		[BindProperty]
		public string Email { get; set; }
		[BindProperty]
		public string Password { get; set; }

		public string ErrorMessage { get; set; }

		public void OnGet()
		{

		}

		public IActionResult OnPost()
		{
			Hraccount hraccount = _hraccountRepo.getHRAccountByEmail(Email);
			if (hraccount != null && hraccount.Password == Password)
			{
				return RedirectToPage("/CandidateManage/Index");
			}
			else
			{
				ErrorMessage = "Login Failed !";
				return Page();
			}
		}
	}
}
