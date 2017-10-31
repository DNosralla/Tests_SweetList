using SweetList.Domain;
using SweetList.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetList.Repository.EF
{
    public class CountryRepository : ICountryRepository
    {
        private readonly SweetListDbContext _dbContext;

        public CountryRepository(SweetListDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        
        public List<Country> GetAll()
        {
            return _dbContext.Countries.OrderByDescending(c=>c.Name).ToList();
        }

        public Country Get(int id)
        {
            return _dbContext.Countries.Find(id);
        }

    }
}
