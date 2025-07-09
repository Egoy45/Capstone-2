using LeRayBookingSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace LeRayBookingSystem.Data
{
   
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

            public DbSet<Appointment> Appointments { get; set; }
            public DbSet<Service> Services { get; set; }
           public DbSet<Feedback> Feedbacks { get; set; }
           public DbSet<Promos> Promos { get; set; }
            public DbSet<Payments> Payments { get; set; }
            public DbSet<AuditLog> AuditLogs { get; set; }
        }
    }

