using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetList.Web.Models
{
    public class PostCustomer
    {
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}