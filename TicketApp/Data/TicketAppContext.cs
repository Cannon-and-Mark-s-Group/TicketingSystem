using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketApp.Models;

namespace TicketApp.Data
{
    public class TicketAppContext : DbContext
    {
        public TicketAppContext (DbContextOptions<TicketAppContext> options)
            : base(options)
        {
        }

        public DbSet<TicketApp.Models.Ticket> Ticket { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { 
                    CreatedDate = DateTime.Now,
                    Location= "UP303",
                    EndDate = DateTime.Now,
                    Description="Laptop",
                    Notes="None",
                    Priority=Priority.Low,
                    TicketId=2

                
                
                
                }
                
                
                
                
                );


          }

    }
}
