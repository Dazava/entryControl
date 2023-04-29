using EntryControl.Shared.Entities;
using System.Diagnostics.Metrics;

namespace EntryControl.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 1; i <= 50000; i++)
                {
                    _context.Tickets.Add(new Ticket {IsUsed = false});
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
