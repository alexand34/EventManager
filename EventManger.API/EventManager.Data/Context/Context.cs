using EventManager.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
