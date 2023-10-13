using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPageFootball.Data
{
    public class RazorPageFootballContext : DbContext
    {
        public RazorPageFootballContext (DbContextOptions<RazorPageFootballContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.CollegeFootball> CollegeFootball { get; set; } = default!;
    }
}
