using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<MovieData> tb_movie { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {
            
        }
}
}