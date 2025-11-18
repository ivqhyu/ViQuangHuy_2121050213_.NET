using Microsoft.EntityFrameworkCore;
using DemoMvc_213.Models;

namespace DemoMvc_213.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
    }
}
