using DatingApp.API.Entites;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AppUser> Users { get; set; }
    }
}
