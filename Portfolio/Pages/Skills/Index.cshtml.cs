using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Pages.Skills
{
    public class IndexModel : PageModel
    {
		public List<Skill> Skills = new List<Skill>();
		private readonly Data.ApplicationDbContext _context;

		public IndexModel(Data.ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task OnGetAsync()
		{
			Skills = await _context.Skill.ToListAsync();
		}

	}
}