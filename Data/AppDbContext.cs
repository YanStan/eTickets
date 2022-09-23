using Microsoft.EntityFrameworkCore;
using WebCommercial.Models;

namespace WebCommercial.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasKey(a => a.ActorId);
            modelBuilder.Entity<Cinema>().HasKey(c => c.CinemaId);
            modelBuilder.Entity<Producer>().HasKey(p => p.ProducerId);


            modelBuilder.Entity<Movie>().HasKey(m => m.MovieId);
            modelBuilder.Entity<Movie>().HasOne(m => m.Producer).WithMany(p => p.Movies)
                .HasForeignKey(m => m.ProducerId);
            modelBuilder.Entity<Movie>().HasOne(m => m.Cinema).WithMany(c => c.Movies)
                .HasForeignKey(m => m.CinemaId);


            modelBuilder.Entity<Actor_Movie>().HasKey(am => new 
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(m => m.Actors_Movies).
                HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(m => m.Actors_Movies).
                HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
