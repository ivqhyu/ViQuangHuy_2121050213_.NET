using Microsoft.EntityFrameworkCore;
using DemoMvc_213.Models;
using DemoMvc_213.Models.Entities;

namespace DemoMvc_213.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
