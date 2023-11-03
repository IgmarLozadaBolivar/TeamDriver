using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.ToTable("driver");
        
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.Property(e => e.Name).HasMaxLength(60);

        builder.Property(e => e.Age).HasMaxLength(3);
    }
}