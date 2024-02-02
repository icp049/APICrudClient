using Microsoft.AspNetCore.Mvc;
using APICrudClient.Models;

namespace APICrudClient.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers  = new List<Customer>();
            //api get here

            return View(customers);
        }



        [HttpGet]

        public IActionResult Create()
        {

            Customer customer = new Customer();
            return View(customer);
        }


        [HttpPost]

        public IActionResult Create(Customer customer)
        {
            return RedirectToAction("Index");
        }




        public IActionResult Details(int id)
        {
            Customer customer = new Customer();

            return View(customer);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            Customer customer = new Customer();
            return View(customer);
        }


        [HttpPost]

        public IActionResult Edit(Customer customer)
        {
            return RedirectToAction("index");
        }


        [HttpGet]

        public IActionResult Delete(int id)
        {
            Customer customer = new Customer();
            return View(customer);
        }


        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            return RedirectToAction("index");
        }



    }
}
