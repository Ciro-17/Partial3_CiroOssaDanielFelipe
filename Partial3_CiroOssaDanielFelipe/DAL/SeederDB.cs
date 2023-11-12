using Microsoft.EntityFrameworkCore;

namespace Partial3_CiroOssaDanielFelipe.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            SellTickets();

            await _context.SaveChangesAsync();

            
        }
            

        private void SellTickets()
        {
            if (!_context.Tickets.Any()) 
            {
                for (int i = 1; i <= 1000; i++)
                {
                    _context.Tickets.Add(new Entities.Ticket
                    {
                        IDticket = i,
                        UseDate = DateTime.Now,
                        IsUsed = false,
                        EntranceGate = null,
                        CreatedDate= DateTime.Now,

                    }
                    );
                }
            }
        }

        
    }
}
