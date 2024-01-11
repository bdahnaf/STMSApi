using Microsoft.EntityFrameworkCore;
using STMSApi.Models;

namespace STMSApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Alif Mansion",
                    Details = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words.",
                    Sqft = 1420,
                    Amenity = "Parking, Security etc.",
                    Rate = 12000.00,
                    Occupancy = 10,
                    ImageUrl = "https://picsum.photos/300.jpg",
                    CreatedDateTime = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Alif Tower",
                    Details = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum",
                    Sqft = 5420,
                    Amenity = "Swimming Pool, Security etc.",
                    Rate = 15600.30,
                    Occupancy = 50,
                    ImageUrl = "https://picsum.photos/200/300.jpg",
                    CreatedDateTime = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Alif Bhaban",
                    Details = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here'.",
                    Sqft = 3200,
                    Amenity = "N/A",
                    Rate = 7450.50,
                    Occupancy = 20,
                    ImageUrl = "https://picsum.photos/100/300.jpg",
                    CreatedDateTime = DateTime.Now
                }
                );
        }
    }
}
