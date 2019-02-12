using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly Portfolio.Data.ApplicationDbContext _context;

		[BindProperty]
		public string Title { get; set; }
		[BindProperty]
		public DateTime ReleaseDate { get; set; }
		[BindProperty]
		public string Content { get; set; }

		public CreateModel(Portfolio.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Post.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}