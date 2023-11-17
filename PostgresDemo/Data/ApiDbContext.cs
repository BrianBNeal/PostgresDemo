using Microsoft.EntityFrameworkCore;
using PostgresDemo.Models;

#nullable disable

namespace PostgresDemo.Data;

public class ApiDbContext : DbContext
{
    public virtual DbSet<Player> Players { get; set; }
    public virtual DbSet<PlayerMedia> PlayerMedia { get; set; }
    public virtual DbSet<Team> Teams { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    { 
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Player_Team");

            entity.HasOne(p => p.Media)
                .WithOne(pm => pm.Player)
                .HasForeignKey<PlayerMedia>(pm => pm.PlayerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Player_PlayerMedia");
        });
    }
}