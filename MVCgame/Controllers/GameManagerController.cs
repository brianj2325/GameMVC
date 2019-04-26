using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCgame.Models;

namespace MVCgame.Controllers
{
    public class GameManagerController : Controller
    {
        // GET: GameManager - Like Gamestop
        public ActionResult Index()
        {
            TempData tempData = new TempData();
            var model = tempData.GetGames();
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            TempData tempData = new TempData();
            var game = tempData.GetGames().Where(x => x.GameID == id).FirstOrDefault();
            return View(game);
        }

        public ActionResult Delete(int id)
        {
            
            TempData tempData = new TempData();
            var game = tempData.GetGames().Where(x => x.GameID == id).FirstOrDefault();
            ViewBag.GenreId = new SelectList(tempData.GetGenres(), "GenreId", "Name", game.GameID);
            ViewBag.Platform = new SelectList(tempData.GetPlatforms(), "PlatformID", "Name", game.GameID);
            return View(game);
            
        }

        //
        // GET: /StoreManager/Edit/39
        public ActionResult Edit(int id)
        {
            TempData tempData = new TempData();
            var game = tempData.GetGames().Where(x => x.GameID == id).FirstOrDefault();
            ViewBag.GenreId = new SelectList(tempData.GetGenres(), "GenreId", "Name", game.GameID);
            ViewBag.Platform = new SelectList(tempData.GetPlatforms(), "PlatformID", "Name", game.GameID);
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Game game)
        {
            return RedirectToAction("Index");
        }
        //
        // GET: /StoreManager/Create
        public ActionResult Create()
        {
            TempData tempData = new TempData();
            ViewBag.GenreId = new SelectList(tempData.GetGenres(), "Genre", "Name");
            ViewBag.PlatformID = new SelectList(tempData.GetPlatforms(), "Platform", "Name");
            return View();
        }
    }
}