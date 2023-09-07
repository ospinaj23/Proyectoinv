using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyectoinv.Controllers
{
    public class ProyectoinvController : Controller
    {
        // GET: ProyectoinvController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProyectoinvController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProyectoinvController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProyectoinvController/Create
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

        // GET: ProyectoinvController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProyectoinvController/Edit/5
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

        // GET: ProyectoinvController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProyectoinvController/Delete/5
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
