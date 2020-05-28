using Diksha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diksha.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer{ID=1, Name="Diksha"},
                new Customer{ID=2, Name="Ravina"}
            };
            return View(customer);
        }
        public ActionResult Details(int ID)
        {
            var getName=string.Empty;
            var CustomerList = new List<Customer>
            {
                new Customer{ID=1, Name="Diksha"},
                new Customer{ID=2, Name="Ravina"}
            };
            foreach (var item in CustomerList)
            {
                if (ID == item.ID)
                {
                     getName = item.Name;
                }                
            }
            ViewBag.SelectedName = getName;

            return View();
        }
    }
}