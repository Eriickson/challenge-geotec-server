using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using challenge_geotec_server.Interface;
using challenge_geotec_server.Models;
using challenge_geotec_server.Repository;

namespace challenge_geotec_server.Interface
{
    public class ItemController : Controller
    {
        private IItem items = new ItemRepository();

        // GET: ItemController
        public ActionResult<IEnumerable<Item>> Index()
        {
            return items.getItems();
        }

        // GET: ItemController/Details/5
        public ActionResult<Item> Details(string search)
        {
            return items.getItem(search);
        }

        // GET: ItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
