using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tihair.Core.Models;
using Tihair.Core.Models.Enums;

namespace Tihair.Core.Data
{
    public class DataContext : DbContext
    {
        private readonly Guid _adminUserId = Guid.NewGuid();
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedUserWithRoles(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedUserWithRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(new User()
                {
                    Id = _adminUserId,
                    Name = "admin",
                    PasswordHash = "admin",
                    AuthorizeRole = AuthorizeRoles.Admin,
                    PhoneNumber = "123456789"
                });
        }
    }
}
