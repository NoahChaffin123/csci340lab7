using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageFootball.Data;
using RazorPagesMovie.Models;

namespace RazorPageFootball.Pages_CollegeFootball
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageFootball.Data.RazorPageFootballContext _context;

        public CreateModel(RazorPageFootball.Data.RazorPageFootballContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CollegeFootball CollegeFootball { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CollegeFootball == null || CollegeFootball == null)
            {
                return Page();
            }

            _context.CollegeFootball.Add(CollegeFootball);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
