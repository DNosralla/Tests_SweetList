using SweetList.Domain;
using SweetList.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetList.Repository.EF
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SweetListDbContext _dbContext;

        public CustomerRepository(SweetListDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Customer Add(string name, Country country)
        {
            var c = new Customer() {
                Name = name,
                CountryId = country.Id
            };

            _dbContext.Customers.Add(c);
            _dbContext.SaveChanges();
            return c;
        }

        public Customer Get(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _dbContext.Customers.OrderBy(c => c.Name).ToList();
        }
    }
}
