
using Microsoft.EntityFrameworkCore;
using ACTSOA_GROUP10.CoreLayer.Entities;
namespace ACTSOA_GROUP10.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieSeriesTag> MovieSeriesTags { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) :
       base(options)
        { }
        protected override void OnModelCreating(ModelBuilder
       modelBuilder)
        {
            modelBuilder.Entity < Movie>().ToTable("MoviesSeries");

            modelBuilder.Entity<Movie>()
.Property(e => e.Id).HasColumnName("movie_series_id");

             modelBuilder.Entity<MovieSeriesTag>()
            .HasKey(mst => new { mst.MovieSeriesId, mst.TagId });
            modelBuilder.Entity<MovieSeriesTag>()
            .HasOne(mst => mst.Movie)
            .WithMany(m => m.MovieSeriesTags)
            .HasForeignKey(mst => mst.MovieSeriesId);
            modelBuilder.Entity<MovieSeriesTag>()
            .HasOne(mst => mst.Tag)
            .WithMany(t => t.MovieSeriesTags)
            .HasForeignKey(mst => mst.TagId);
        }
    }
}
