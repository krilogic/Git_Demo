using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Git_Demo.Controllers
{
    public class TeamAController : Controller
    {
        // GET: TeamAController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamAController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamAController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamAController/Create
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

        // GET: TeamAController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamAController/Edit/5
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

        // GET: TeamAController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamAController/Delete/5
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
