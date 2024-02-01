using Microsoft.EntityFrameworkCore;
using SignalRQRReservation.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DataAccessLayer.Concrete
{
    public class SignalRQRReservationContext :DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SAKEGUU\\MSSQLSERVER03;initial Catalog=SignalRQRReservationDb;integrated Security=true");
        }
        public DbSet <About> Abouts { get; set; }
        public DbSet <Booking> Bookings { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet <Change> Changes { get; set; }
        public DbSet <HomePage> HomePages { get; set; }
        public DbSet <SocialMedia> SocialMedias { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
    }
}
