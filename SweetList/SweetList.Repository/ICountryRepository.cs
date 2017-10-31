using System.Collections.Generic;
using SweetList.Domain;

namespace SweetList.Repository
{
    public interface ICountryRepository
    {
        Country Get(int id);
        List<Country> GetAll();
    }
}