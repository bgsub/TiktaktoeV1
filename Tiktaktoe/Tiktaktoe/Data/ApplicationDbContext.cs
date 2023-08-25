using Microsoft.EntityFrameworkCore;
using Tiktaktoe.Models;

namespace Tiktaktoe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}
