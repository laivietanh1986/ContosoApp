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
            modelBuilder.Entity<Person>()
                 .HasMany(x => x.PersonPhones)
                 .WithOne(x => x.Person)
                 .HasForeignKey(x => x.BusinessEntityID);
            modelBuilder.Entity<Person>()
                 .HasMany(x => x.EmailAddresses)
                 .WithOne(x => x.Person)
                 .HasForeignKey(x => x.BusinessEntityID);


        }
       public DbSet<Person> Persons { get; set; }
       public DbSet<EmailAddresses> EmailAddresses { get; set; }
       public DbSet<PersonPhone> PersonPhones { get; set; }


    }
}
