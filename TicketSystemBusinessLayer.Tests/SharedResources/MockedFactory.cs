using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using TicketSystemEntities.ApplicationDbContext;
using TicketSystemEntities.Database;

namespace TicketSystemBusinessLayer.Tests.SharedResources
{
    public static class MockedFactory
    {
        #region TicketAppContext

        public static Mock<ITicketAppContext> MockTicketAppContext()
        {
            var tickets = new List<Ticket>
            {
                new Ticket {
                    TicketId = 1,
                    TechId = "1",
                    Description = "test",
                    CreatedDate = DateTime.UtcNow,
                    Priority = 1,
                    Notes = "This is a test"
                }
            };


            var mockContext = new Mock<ITicketAppContext>();
            mockContext.Setup<DbSet<Ticket>>(t => t.Tickets)
                .ReturnsDbSet(tickets);

            return mockContext;
        }

        #endregion
    }
}
