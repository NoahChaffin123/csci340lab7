using Microsoft.EntityFrameworkCore;
using RazorPageFootball.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPageFootballContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageFootballContext>>()))
        {
            if (context == null || context.CollegeFootball == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.CollegeFootball.Any())
            {
                return;   // DB has been seeded
            }

            context.CollegeFootball.AddRange(
                new CollegeFootball
                {
                    Team = "Arkansas",
                    Conference = "SEC",
                    TotalOffense = 1997.0M,
                    TotalDefense = 2044.0M, 
                    MasseyRating = -23.571M
                },

                new CollegeFootball
                {
                    Team = "Alabama",
                    Conference = "SEC",
                    TotalOffense = 2160.0M,
                    TotalDefense = 1797.0M, 
                    MasseyRating = 35.0M
                },

                new CollegeFootball
                {
                    Team = "Ole Miss",
                    Conference = "SEC",
                    TotalOffense = 2936.0M,
                    TotalDefense = 2330.0M, 
                    MasseyRating = 69.7142M
                },

                new CollegeFootball
                {
                    Team = "LSU",
                    Conference = "SEC",
                    TotalOffense = 3230.0M,
                    TotalDefense = 2674.0M, 
                    MasseyRating = 71.143M
                }
            );
            context.SaveChanges();
        }
    }
}