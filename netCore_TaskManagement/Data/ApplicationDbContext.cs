using Microsoft.EntityFrameworkCore;
using netCore_TaskManagement.Data.Entity;

namespace netCore_TaskManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }

    }
}
