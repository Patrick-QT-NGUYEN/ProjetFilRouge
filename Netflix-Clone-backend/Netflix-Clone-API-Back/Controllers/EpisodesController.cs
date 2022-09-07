using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Netflix_Clone_API_Back.Controllers
{
    public class EpisodesController : Controller
    {
        // GET: EpisodesController
        public ActionResult Index()
        {
            return ;
        }

        // GET: EpisodesController/Details/5
        public ActionResult Details(int id)
        {
            return ();
        }

        // GET: EpisodesController/Create
        public ActionResult Create()
        {
            return ();
        }

        // POST: EpisodesController/Create
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

        // GET: EpisodesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EpisodesController/Edit/5
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

        // GET: EpisodesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EpisodesController/Delete/5
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
