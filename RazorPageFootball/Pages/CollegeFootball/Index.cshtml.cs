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
    public class IndexModel : PageModel
    {
        private readonly RazorPageFootball.Data.RazorPageFootballContext _context;

        public IndexModel(RazorPageFootball.Data.RazorPageFootballContext context)
        {
            _context = context;
        }

        public IList<CollegeFootball> CollegeFootball { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CollegeFootball != null)
            {
                CollegeFootball = await _context.CollegeFootball.ToListAsync();
            }
        }
    }
}
