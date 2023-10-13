using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class CollegeFootball
{
    public int Id { get; set; }
    public string? Team { get; set; }
    public string? Conference { get; set; } 
    [Display(Name = "Total Offensive Yards")]
    public decimal TotalOffense { get; set; } 
    [Display (Name = "Total Yards Allowed")]
    public decimal TotalDefense { get; set; } 
    [Display (Name = "Massey Rating")]
    public decimal MasseyRating { get; set; }
}