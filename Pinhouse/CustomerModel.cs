using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pinhouse
{
    class CustomerContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=customers.sqlite");
        }
    }

    [Table("pinhouse_customers")]
    public class Customer
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Date")]
        public string Date { get; set; }
        [Column("Time")]
        public DateTime Time { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
