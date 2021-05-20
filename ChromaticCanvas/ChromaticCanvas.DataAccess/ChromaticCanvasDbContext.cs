using ChromaticCanvas.ApplicationLogic.DataModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChromaticCanvas.DataAccess
{
    public class ChromaticCanvasDbContext : IdentityDbContext<IdentityUser>
    {
        public ChromaticCanvasDbContext() { }
        public ChromaticCanvasDbContext(DbContextOptions<ChromaticCanvasDbContext> options) : base(options)
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
