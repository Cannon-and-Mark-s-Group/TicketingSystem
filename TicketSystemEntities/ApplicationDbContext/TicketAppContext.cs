using Microsoft.EntityFrameworkCore;
using TicketSystemEntities.Database;

namespace TicketSystemEntities.ApplicationDbContext
{
    public class TicketAppContext : DbContext
    {
        #region Constructor

        public TicketAppContext(DbContextOptions<TicketAppContext> options)
            : base(options)
        {
        }

        #endregion

        #region ModelBuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasKey(t => t.TicketId);
        }

        #endregion

        #region DnSet

        public DbSet<Ticket> Ticket { get; set; } = default!;

        #endregion
    }
}
