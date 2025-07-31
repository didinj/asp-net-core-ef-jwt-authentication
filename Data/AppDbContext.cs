using Microsoft.EntityFrameworkCore;
using SecureApiJwtAuth.Models;

namespace SecureApiJwtAuth.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}