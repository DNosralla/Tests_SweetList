using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetList.Domain;

namespace SweetList.Entity
{
    public class SweetListDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
