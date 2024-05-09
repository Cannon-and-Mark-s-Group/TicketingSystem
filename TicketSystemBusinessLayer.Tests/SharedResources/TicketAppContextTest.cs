using Microsoft.EntityFrameworkCore;
using TicketSystemEntities.Database;

namespace TicketSystemBusinessLayer.Tests.SharedResources
{
    public class TicketAppContextTest : DbContext
    {
        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}
