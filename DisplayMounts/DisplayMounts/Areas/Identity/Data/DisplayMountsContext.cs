using DisplayMounts.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisplayMounts.Data;

public class DisplayMountsContext : IdentityDbContext<DisplayMountsUser>
{
    public DisplayMountsContext(DbContextOptions<DisplayMountsContext> options)
        : base(options)
    {
    }
    public DbSet<Models.MountCollected> Collected { get; set; }
    public DbSet<Models.Comments> Comment { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
