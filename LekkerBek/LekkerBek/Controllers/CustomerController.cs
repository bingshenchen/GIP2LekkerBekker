using LekkerBek.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LekkerBek.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            // VoorbeeldLijst: mag weg;

            return View(CustomerData.GetCustomers());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(CustomerData.GetCustomerById(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Customer customer = new Customer(int.Parse(collection["Id"]), collection["Name"], collection["Email"], collection["Phone"], collection["Adres"], DateTime.Parse(collection["Birthday"]), double.Parse(collection["LoyaltyScore"]), collection["PreferredDishes"]);
                CustomerData.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(CustomerData.GetCustomerById(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                CustomerData.UpCustomer(int.Parse(collection["Id"]), collection["Name"], collection["Email"], collection["Phone"], collection["Adres"], DateTime.Parse(collection["Birthday"]), double.Parse(collection["LoyaltyScore"]), collection["PreferredDishes"]);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CustomerData.GetCustomerById(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                CustomerData.GetCustomers().Remove(CustomerData.GetCustomerById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
