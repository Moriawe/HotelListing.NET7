using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HotelListings.API.Data
{
    public class HotelListingDbContext : DbContext
    {
       public HotelListingDbContext(DbContextOptions options) : base(options) {
            
        }

        // Add the database classes
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Sweden",
                    ShortName= "SWE"
                },
                new Country
                {
                    Id = 2,
                    Name = "Norge",
                    ShortName = "NO"
                },
                new Country
                {
                    Id = 3,
                    Name = "Danmark",
                    ShortName = "DK"
                },
                 new Country
                 {
                    Id = 4,
                    Name = "Finland",
                    ShortName = "FIN"
                },
                 new Country
                 {
                    Id = 5,
                    Name = "Island",
                    ShortName = "ICE"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Scandic",
                    Adress = "Göteborg",
                    CountryId = 1,
                    Rating = 3.2
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Olsens",
                     Adress = "Oslo",
                     CountryId = 2,
                     Rating = 4
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Lilla Djävulen",
                      Adress = "Åbo",
                      CountryId = 4,
                      Rating = 4.5
                  },
                   new Hotel
                   {
                       Id = 4,
                       Name = "Polse",
                       Adress = "Köpenhamn",
                       CountryId = 1,
                       Rating = 2.2
                   }
                );
        }

    }
}
