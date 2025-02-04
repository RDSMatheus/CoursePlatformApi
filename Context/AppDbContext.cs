using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
    }
}
