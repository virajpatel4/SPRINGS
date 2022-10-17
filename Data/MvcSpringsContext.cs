using Microsoft.EntityFrameworkCore;
using MvcSprings.Models;

namespace MvcSprings.Data
{
    public class MvcSpringsContext : DbContext
    {
        public MvcSpringsContext(DbContextOptions<MvcSpringsContext> options)
            : base(options)
        {
        }

        public DbSet<Spring> Spring { get; set; }
    }
}
