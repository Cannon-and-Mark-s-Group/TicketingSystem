using TicketSystemEntities.Database;

namespace TicketSystemBusinessLayer.BusinessLogic.RequestTicket
{
    public interface IRequestTicketLogic
    {
        /// <summary>
        /// Creates a new ticket.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        Task CreateTicketAsync(Ticket ticket);

        /// <summary>
        /// Delete a single ticket by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteTicketAsync(int? id);

        /// <summary>
        /// Gets a single ticket by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Ticket?> GetTicketAsync(int? id);

        /// <summary>
        /// Gets all tickets.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ticket> GetTickets();

        /// <summary>
        /// Updates a single ticket by id.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        Task UpdateTicketAsync(Ticket ticket);

    }
}
