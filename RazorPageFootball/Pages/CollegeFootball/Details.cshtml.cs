using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageFootball.Data;
using RazorPagesMovie.Models;

namespace RazorPageFootball.Pages_CollegeFootball
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageFootball.Data.RazorPageFootballContext _context;

        public DetailsModel(RazorPageFootball.Data.RazorPageFootballContext context)
        {
            _context = context;
        }

      public CollegeFootball CollegeFootball { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CollegeFootball == null)
            {
                return NotFound();
            }

            var collegefootball = await _context.CollegeFootball.FirstOrDefaultAsync(m => m.Id == id);
            if (collegefootball == null)
            {
                return NotFound();
            }
            else 
            {
                CollegeFootball = collegefootball;
            }
            return Page();
        }
    }
}
