using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPageFootball.Data;
using RazorPagesMovie.Models;

namespace RazorPageFootball.Pages_CollegeFootball
{
    public class EditModel : PageModel
    {
        private readonly RazorPageFootball.Data.RazorPageFootballContext _context;

        public EditModel(RazorPageFootball.Data.RazorPageFootballContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CollegeFootball CollegeFootball { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CollegeFootball == null)
            {
                return NotFound();
            }

            var collegefootball =  await _context.CollegeFootball.FirstOrDefaultAsync(m => m.Id == id);
            if (collegefootball == null)
            {
                return NotFound();
            }
            CollegeFootball = collegefootball;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CollegeFootball).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeFootballExists(CollegeFootball.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CollegeFootballExists(int id)
        {
          return (_context.CollegeFootball?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
