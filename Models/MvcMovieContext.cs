using Microsoft.EntityFrameworkCore;

namespace MvcMovie2.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie2.Models.Movie> Movie { get; set; }
    }
}