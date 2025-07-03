using HarmonySound.API.Consumer;
using HarmonySound.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HarmonySound.MVC.Controllers
{
    public class UsersRolesController : Controller
    {
        // GET: UsersRolesController
        public ActionResult Index()
        {
            var data = Crud<UserRole>.GetAll();
            return View(data);
        }

        // GET: UsersRolesController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<UserRole>.GetById(id);
            return View(data);
        }

        // GET: UsersRolesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersRolesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserRole data)
        {
            try
            {
                Crud<UserRole>.Create(data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while creating the user role: " + ex.Message);
                return View(data);
            }
        }

        // GET: UsersRolesController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<UserRole>.GetById(id);
            return View(data);
        }

        // POST: UsersRolesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserRole data)
        {
            try
            {
                Crud<UserRole>.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while editing the user role: " + ex.Message);
                return View(data);
            }
        }

        // GET: UsersRolesController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<UserRole>.GetById(id);
            return View(data);
        }

        // POST: UsersRolesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserRole data)
        {
            try
            {
                Crud<UserRole>.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while deleting the user role: " + ex.Message);
                return View(data);
            }
        }
    }
}
