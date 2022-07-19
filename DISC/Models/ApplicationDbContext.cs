using DISC.Models.Parts;
using Microsoft.EntityFrameworkCore;

namespace DISC.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Users> Users { get; set; } = null!;

    public DbSet<FirstQuiz> FirstPartQuizzes { get; set; } = null!;

    public DbSet<SecondQuiz> SecondPartQuizzes { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
