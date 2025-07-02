using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HarmonySound.MVC.Controllers
{
    public class ContentsAlbumsController : Controller
    {
        // GET: ContentsAlbumsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContentsAlbumsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContentsAlbumsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContentsAlbumsController/Create
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

        // GET: ContentsAlbumsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContentsAlbumsController/Edit/5
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

        // GET: ContentsAlbumsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContentsAlbumsController/Delete/5
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
