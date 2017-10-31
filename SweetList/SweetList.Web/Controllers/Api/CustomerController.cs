using SweetList.Domain;
using SweetList.Repository;
using SweetList.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SweetList.Web.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ICustomerRepository _customerRepository { get; set; }
        private ICountryRepository _countryRepository { get; set; }

        public CustomerController(ICustomerRepository customerRepository, ICountryRepository countryRepository)
        {
            this._customerRepository = customerRepository;
            this._countryRepository = countryRepository;
        }

        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAll();
        }

        // GET: api/Customer/5
        public Customer Get(int id)
        {
            var customer = _customerRepository.Get(id);
            return customer;
        }

        // POST: api/Customer
        public IHttpActionResult Post([FromBody]PostCustomer form)
        {
            if (form == null)
            {
                return BadRequest();
            }

            var country = _countryRepository.Get(form.CountryId);

            if (country == null)
            {
                ModelState.AddModelError("Country", "Invalid Country");
            }

            if (ModelState.IsValid)
            {
                var customer = _customerRepository.Add(form.Name, country);
                return Ok(customer);
            } else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
