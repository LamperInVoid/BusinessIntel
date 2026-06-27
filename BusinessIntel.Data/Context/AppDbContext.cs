using Microsoft.EntityFrameworkCore;
using BusinessIntel.Data.Entities;

namespace BusinessIntel.Data.Context;

public sealed class AppDbContext : DbContext
{
    public DbSet<BusinessEntity> Businesses => Set<BusinessEntity>();

    public DbSet<EmailEntity> Emails => Set<EmailEntity>();

    public DbSet<PhoneEntity> Phones => Set<PhoneEntity>();

    public DbSet<SocialProfileEntity> SocialProfiles => Set<SocialProfileEntity>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<BusinessEntity>()
            .HasMany(x => x.Emails)
            .WithOne(x => x.Business)
            .HasForeignKey(x => x.BusinessEntityId);

        modelBuilder.Entity<BusinessEntity>()
            .HasMany(x => x.Phones)
            .WithOne(x => x.Business)
            .HasForeignKey(x => x.BusinessEntityId);

        modelBuilder.Entity<BusinessEntity>()
            .HasMany(x => x.SocialProfiles)
            .WithOne(x => x.Business)
            .HasForeignKey(x => x.BusinessEntityId);
    }
}
