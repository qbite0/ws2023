using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data {
    public class DatabaseContext : DbContext {
        public DatabaseContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Ticket> Employees { get; set; }
    }
}
