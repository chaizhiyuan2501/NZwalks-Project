using Microsoft.EntityFrameworkCore;
using NZwalk.API.Models.Domain;

namespace NZwalk.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Difficulty> Difficulty { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Walk> Walk { get; set; }
    }
}
