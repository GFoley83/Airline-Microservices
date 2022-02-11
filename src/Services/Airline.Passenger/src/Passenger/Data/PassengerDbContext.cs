using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Passenger.Data;

public sealed class PassengerDbContext: DbContext
{
    public PassengerDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Models.Passenger> Passengers => Set<Models.Passenger>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}