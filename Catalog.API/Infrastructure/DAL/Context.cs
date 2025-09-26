using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure.DAL;

public class Context : DbContext
{
    public Context(){}
    public Context(DbContextOptions<Context> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}