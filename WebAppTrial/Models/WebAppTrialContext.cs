using Microsoft.EntityFrameworkCore;

namespace WebAppTrial.Models
{
    public class WebAppTrialContext : DbContext
    {
        public WebAppTrialContext(DbContextOptions<WebAppTrialContext> options) : base(options)
        {

        }

        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}
