using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("team");

        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.HasIndex(e => e.Name, "team_name_IDX").IsUnique();

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.HasMany(p => p.Drivers)
        .WithMany(p => p.Teams)
        .UsingEntity<TeamDriver>(

            j => j
                .HasOne(pt => pt.Driver)
                .WithMany(t => t.TeamDrivers)
                .HasForeignKey(pt => pt.IdTeam),

            j => j
            .HasOne(pt => pt.Team)
            .WithMany(t => t.TeamDrivers)
            .HasForeignKey(pt => pt.IdDriver),

            j =>
            {
                j.ToTable("teamDriver");
                j.HasKey(t => new { t.IdTeam, t.IdDriver });
            });
    }
}