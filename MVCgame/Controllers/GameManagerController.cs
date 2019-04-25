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
        // GET: StoreManager
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

        //
        // GET: /StoreManager/Edit/5
        public ActionResult Edit(int id)
        {
            TempData tempData = new TempData();
            var game = tempData.GetGames().Where(x => x.GameID == id).FirstOrDefault();
            ViewBag.GenreId = new SelectList(tempData.GetGenres(), "GenreId", "Name", game.GenreId);
            ViewBag.Platform = new SelectList(tempData.GetPlatforms(), "ArtistId", "Name", game.GameID);
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            return RedirectToAction("Index");
        }

        //
        // GET: /StoreManager/Create
        public ActionResult Create()
        {
            TempData tempData = new TempData();
            ViewBag.GenreId = new SelectList(TempData.GetGenres(), "GenreId", "Name");
            ViewBag.ArtistId = new SelectList(tem.GetArtists(), "ArtistId", "Name");
            return View();
        }
    }
}