using Microsoft.EntityFrameworkCore;
using NETMVC.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Định nghĩa các DbSet cho các thực thể của bạn

    public DbSet<CatalogModel> Catalog { get; set; }
    public DbSet<ProductModel> Product { get; set; }
}   