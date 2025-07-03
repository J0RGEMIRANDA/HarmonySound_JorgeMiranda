using HarmonySound.API.Consumer;
using HarmonySound.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HarmonySound.MVC.Controllers
{
    public class ContentsAlbumsController : Controller
    {
        // GET: ContentsAlbumsController
        public ActionResult Index()
        {
            var data = Crud<Album>.GetAll();
            return View(data);
        }

        // GET: ContentsAlbumsController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Album>.GetById(id);
            return View(data);
        }

        // GET: ContentsAlbumsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContentsAlbumsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContentAlbum data)
        {
            try
            {
                Crud<ContentAlbum>.Create(data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            { 
                ModelState.AddModelError("", "An error occurred while creating the content album: " + ex.Message);
                return View(data);
            }
        }

        // GET: ContentsAlbumsController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<ContentAlbum>.GetById(id);
            return View(data);
        }

        // POST: ContentsAlbumsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContentAlbum data)
        {
            try
            {
                Crud<ContentAlbum>.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while editing the content album: " + ex.Message);
                return View(data);
            }
        }

        // GET: ContentsAlbumsController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<ContentAlbum>.GetById(id);
            return View(data);
        }

        // POST: ContentsAlbumsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ContentAlbum data)
        {
            try
            {
                Crud<ContentAlbum>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while deleting the content album: " + ex.Message);
                return View(data);
            }
        }
    }
}
