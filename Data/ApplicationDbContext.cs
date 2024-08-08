using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using ClienteBanco.Entities;
using Microsoft.EntityFrameworkCore;
using ClienteBanco.Entities.Interfaces;

namespace ClienteBanco.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{

    public DbSet<Customer> Customers { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    //Constructor de nuestra estructura de datos
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
