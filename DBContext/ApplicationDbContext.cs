using Microsoft.EntityFrameworkCore;
using webAPI.Model;

namespace webAPI.DBContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public  DbSet<User> Users { get; set; }
    }
}