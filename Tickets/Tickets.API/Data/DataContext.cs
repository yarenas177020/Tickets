﻿using Microsoft.EntityFrameworkCore;
using Ticktets.Shared.Entities;

namespace Tickets.API.Data
{
    public class DataContext :DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.TicketID).IsUnique();
        }

    }
}
