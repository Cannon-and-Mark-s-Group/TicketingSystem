using Microsoft.EntityFrameworkCore;
using TicketSystemEntities.ApplicationDbContext;
using TicketSystemEntities.Database;

namespace TicketSystemBusinessLayer.BusinessLogic.RequestTicket
{
    public class RequestTicketLogic : IRequestTicketLogic
    {
        #region Fields 

        private readonly TicketAppContext _context;

        #endregion

        #region Constructor

        public RequestTicketLogic(TicketAppContext context) 
        {
            _context = context;
        }

        #endregion

        #region IRequestTicketLogic Methods

        /// <inheritdoc/>
        public async Task CreateTicketAsync(Ticket ticket)
        {
            _context.Add(ticket);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteTicketAsync(int? id)
        {
            if (!id.HasValue || id == 0) 
                throw new Exception("Not a valide Ticket Id.");

            var ticket = await _context.Tickets
                .FindAsync(id);

            if (ticket is null)
                throw new Exception("Ticket was not found.");
            
            _context.Remove(ticket);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<Ticket?> GetTicketAsync(int? id)
        {
            if (!id.HasValue || id == 0) return null;

            return await _context.Tickets
                .FirstOrDefaultAsync(m => m.TicketId == id);
        }

        /// <inheritdoc/>
        public IEnumerable<Ticket> GetTickets()
        {
            return _context.Tickets.AsNoTracking();
        }

        /// <inheritdoc/>
        public async Task UpdateTicketAsync(Ticket ticket)
        {
            if (ticket.TicketId == 0)
                throw new Exception("Not a valide Ticket Id.");

            var originalTicket = await _context.Tickets
                .FindAsync(ticket.TicketId);

            if(!string.IsNullOrEmpty(ticket.Description))
                originalTicket.Description = ticket.Description;

            if (!string.IsNullOrEmpty(ticket.Notes))
                originalTicket.Notes = ticket.Notes;

            if (ticket is null)
                throw new Exception("Ticket was not found.");

            _context.Update(originalTicket);
            await _context.SaveChangesAsync();
        }

        #endregion  
    }
}
