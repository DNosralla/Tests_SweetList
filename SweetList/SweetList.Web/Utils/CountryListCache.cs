using SweetList.Domain;
using SweetList.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetList.Web.Utils
{
    public class CountryListCache
    {
        private readonly List<Country> CountryList;

        public CountryListCache(ICountryRepository countryRepository)
        {
            CountryList = countryRepository.GetAll();
        }

        public IEnumerable<Country> GetAll()
        {
            return this.CountryList;
        }
    }
}