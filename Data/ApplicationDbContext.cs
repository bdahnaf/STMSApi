using Microsoft.EntityFrameworkCore;
using STMSApi.Models;

namespace STMSApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
