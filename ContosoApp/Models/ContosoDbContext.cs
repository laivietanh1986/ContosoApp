using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoApp.Models
{
    public class ContosoDbContext:DbContext
    {
        public ContosoDbContext(DbContextOptions<ContosoDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Person");
        }
       public DbSet<Person> Persons { get; set; }

    }
}
