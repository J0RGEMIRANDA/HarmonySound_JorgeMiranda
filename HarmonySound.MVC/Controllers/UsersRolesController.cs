using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HarmonySound.MVC.Controllers
{
    public class UsersRolesController : Controller
    {
        // GET: UsersRolesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsersRolesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersRolesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersRolesController/Create
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

        // GET: UsersRolesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersRolesController/Edit/5
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

        // GET: UsersRolesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersRolesController/Delete/5
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
