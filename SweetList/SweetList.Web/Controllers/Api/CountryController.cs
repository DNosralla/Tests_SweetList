using SweetList.Domain;
using SweetList.Repository;
using SweetList.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SweetList.Web.Controllers.Api
{
    public class CountryController : ApiController
    {
        private CountryListCache _countryListCache { get; set; }

        public CountryController(CountryListCache countryListCache)
        {
            this._countryListCache = countryListCache;
        }

        // GET: api/Country
        public IEnumerable<Country> Get()
        {
            return this._countryListCache.GetAll();
        }
    }
}
