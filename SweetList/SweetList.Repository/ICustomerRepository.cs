using SweetList.Domain;
using System.Collections.Generic;

namespace SweetList.Repository
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        Customer Add(string name, Country country);
    }
}