using EntryControl.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntryControl.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
