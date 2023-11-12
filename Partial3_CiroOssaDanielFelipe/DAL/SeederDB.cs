﻿using Microsoft.EntityFrameworkCore;

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

            await SellTicketsAsync();

            
        }
            

        private async Task SellTicketsAsync()
        {
            if (!_context.Tickets.Any()) 
            {
                for (int i = 1; i <= 1000; i++)
                {
                    _context.Tickets.Add(new Entities.Ticket
                    {
                        IDticket = i,
                        UseDate = null,
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
