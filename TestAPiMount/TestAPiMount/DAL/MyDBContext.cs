using Microsoft.EntityFrameworkCore;
namespace TestAPiMount.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public DbSet<Models.Mount> Mount { get; set; }
    }
}
