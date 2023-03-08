using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Persistence
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions<VidlyDbContext> options) : base(options)
        {} 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
