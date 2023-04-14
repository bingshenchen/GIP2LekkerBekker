using LekkerBek.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LekkerBek.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
            return View(OrderList.GetOrderList());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View(OrderList.GetOrderById(id));
        }

        // GET: OrderController/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                /*
                List<Dish> dishes = JsonConvert.DeserializeObject<List<Dish>>(collection["Dishes"]);
                Order order = new Order(int.Parse(collection["OrderId"]), int.Parse(collection["CustomerId"]), DateTime.Parse(collection["OrderDate"]), dishes);
                */
                Order order = new Order(int.Parse(collection["CookId"]), int.Parse(collection["CustomerId"]), DateTime.Parse(collection["OrderDate"]));
                OrderList.AddOrder(order);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(OrderList.GetOrderById(id));
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                OrderList.UpdateOrder(id, int.Parse(collection["CookId"]), int.Parse(collection["CustomerId"]), DateTime.Parse(collection["OrderDate"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(OrderList.GetOrderById(id));
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                OrderList.GetOrderList().Remove(OrderList.GetOrderById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: Order/AddDish/5



        /*
        // POST: Order/CreateDish
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDish(int id, IFormCollection collection)
        {
            try
            {
                Order order = OrderList.GetOrderById(id);
                if (order == null)
                {
                    return NotFound();
                }

                order.Dishes.Add(new Recipe(id, collection["Naam"], double.Parse(collection["Price"]), "", (Recipe.DishType)Enum.Parse(typeof(Recipe.DishType), collection["RecipeType"])));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Details", new { id = id });
            }
        }
        */

        public ActionResult AddDish(int id)
        {
            ViewBag.OrderId = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDish(int id, IFormCollection collection)
        {
            Order upLoadOrder = OrderList.GetOrderById(id);

            try
            {
                if (upLoadOrder == null)
                {
                    return NotFound();
                }

                upLoadOrder.Dishes.Add(new Recipe(id, collection["Naam"], double.Parse(collection["Price"]), "", (Recipe.DishType)Enum.Parse(typeof(Recipe.DishType), collection["RecipeType"])));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                if (upLoadOrder != null)
                {
                    return RedirectToAction("Details", new { id = upLoadOrder.OrderId });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
