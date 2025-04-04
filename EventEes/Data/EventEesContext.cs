using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEes.Models;

namespace EventEes.Data
{
    public class EventEesContext : DbContext
    {
        public EventEesContext (DbContextOptions<EventEesContext> options)
            : base(options)
        {
        }

        public DbSet<EventEes.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEes.Models.Booking> Booking { get; set; } = default!;
        public DbSet<EventEes.Models.Venue> Venue { get; set; } = default!;
    }
}
