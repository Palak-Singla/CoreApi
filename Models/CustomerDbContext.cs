using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;


namespace AngularWebApi.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(

                new Customer { CId=1,CName="Palak",CDob=new DateTime(day: 15,month:04,year:2019),CPin=1001},
                new Customer { CId = 2, CName = "Kareena", CDob = new DateTime(day: 16, month: 04, year: 2019), CPin = 1002 },
                new Customer { CId = 3, CName = "Pushp", CDob = new DateTime(day: 17, month: 04, year: 2019), CPin = 1003 }
                );
        }
    }
}
