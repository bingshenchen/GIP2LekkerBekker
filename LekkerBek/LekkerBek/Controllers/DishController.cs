using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LekkerBek.Models;
using Microsoft.CodeAnalysis.Scripting;

namespace LekkerBek.Controllers
{
    public class DishController : Controller
    {
        // GET: DishController
        public ActionResult Index()
        {
            // Het voorbeeld mag verwijderd worden.
            return View(Menu.GetDishes());
        }

        // GET: DishController/Details/5
        public ActionResult Details(int id)
        {
            return View(Menu.GetDishById(id));
        }

        // GET: DishController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DishController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Recipe recipe = new Recipe(int.Parse(collection["Id"]),collection["Name"], double.Parse(collection["Price"]), collection["RecipeText"], (Recipe.DishType)Enum.Parse(typeof(Recipe.DishType), collection["RecipeType"]));
                Menu.AddDish(recipe);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DishController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Menu.GetDishById(id));
        }

        // POST: DishController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Menu.UpDish(id, collection["Name"], double.Parse(collection["Price"]), collection["RecipeText"], (Recipe.DishType)Enum.Parse(typeof(Recipe.DishType), collection["RecipeType"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DishController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Menu.GetDishById(id));
        }

        // POST: DishController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Menu.GetDishes().Remove(Menu.GetDishById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateDish(int orderId)
        {
            var order = OrderList.GetOrderById(orderId);
            return View(OrderList.GetOrderById(orderId));
        }
    }
}
