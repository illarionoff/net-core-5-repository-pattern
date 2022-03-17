
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Models
{
    public class MyMDBContext : DbContext
    {
        public MyMDBContext (DbContextOptions<MyMDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Actor> Actors { get; set; }

    }
}
