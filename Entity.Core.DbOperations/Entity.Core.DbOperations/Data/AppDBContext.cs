using Entity.Core.DbOperations.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity.Core.DbOperations.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
