using Microsoft.EntityFrameworkCore;
using TMS.Models;

namespace TMS.DataAccesLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ContactInfo> Contacts { get; set; }

    }
}
