using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pinhouse
{
    class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=employees.sqlite");
        }
    }

    [Table("pinhouse_employees")]
    public class Employee
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Dob")]
        public string Dob { get; set; }
        [Column("PhoneNumber")]
        public string Phone { get; set; }
        [Column("Street")]
        public string Street { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("State")]
        public string State { get; set; }
        [Column("ZipCode")]
        public string ZipCode { get; set; }
        [Column("Monday")]
        public string Monday { get; set; }
        [Column("Tuesday")]
        public string Tuesday { get; set; }
        [Column("Wednesday")]
        public string Wednesday { get; set; }
        [Column("Thursday")]
        public string Thursday { get; set; }
        [Column("Friday")]
        public string Friday { get; set; }
        [Column("Saturday")]
        public string Saturday { get; set; }
        [Column("Sunday")]
        public string Sunday { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
