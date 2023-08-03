using JetBrains.Annotations;
using JsonApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JsonApi.DbContexts;

[UsedImplicitly(ImplicitUseTargetFlags.Members)]
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
}