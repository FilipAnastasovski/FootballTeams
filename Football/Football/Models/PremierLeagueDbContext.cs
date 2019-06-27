using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class PremierLeagueDbContext : DbContext
    {
        public PremierLeagueDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Team> Teams { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasKey(x => new {x.HomeTeamId,x.GuestTeamId });

            modelBuilder.Entity<Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(x => x.HomeMatches)
                .HasForeignKey(x=>x.HomeTeamId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Match>()
               .HasOne(x => x.GuestTeam)
               .WithMany(x => x.AwayMatches)
               .HasForeignKey(x=>x.GuestTeamId).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Team>()
                .HasMany(x => x.Players)
                .WithOne(x => x.Team)
                .HasForeignKey(x => x.TeamId);

            modelBuilder.Entity<Team>()
                .HasOne(x => x.Trainer)
                .WithOne(x => x.Team)
                .HasForeignKey<Trainer>(x => x.TeamId);


        
        }

    }
}
