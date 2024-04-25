﻿using Microsoft.EntityFrameworkCore;
using TicketSystemEntities.Database;

namespace TicketSystemEntities.ApplicationDbContext
{
    public class TicketAppContext : ITicketAppContext
    {
        #region Constructor

        public TicketAppContext(DbContextOptions<ITicketAppContext> options)
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

        public DbSet<Ticket> Tickets { get; set; } = default!;

        #endregion
    }
}
