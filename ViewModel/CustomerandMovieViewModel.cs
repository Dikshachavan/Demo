using Diksha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diksha.ViewModel
{
    public class CustomerandMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}