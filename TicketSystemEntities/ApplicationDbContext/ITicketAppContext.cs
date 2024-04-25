using Microsoft.EntityFrameworkCore;
using TicketSystemEntities.Database;

namespace TicketSystemEntities.ApplicationDbContext
{
    public abstract class ITicketAppContext : DbContext
    {
        #region Constructor

        public ITicketAppContext()
        {

        }

        public ITicketAppContext(DbContextOptions<ITicketAppContext> options)
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

        public virtual DbSet<Ticket> Tickets { get; set; } = default!;

        #endregion
    }
}
