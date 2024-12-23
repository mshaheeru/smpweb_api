using Microsoft.EntityFrameworkCore;
using smp_api.Models;

namespace smp_api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Stock> Stocks {  get; set; }
        public DbSet<Comment> Comments { get; set; }


    }

}
