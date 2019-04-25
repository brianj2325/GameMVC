using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCgame.Models;
using System.Web.Mvc;

namespace MVCgame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            TempData tempData = new TempData();
            var genres = tempData.GetGenres();

            return View(genres);
        }
        //
        //GET: /Game/Browse?genre=FPS
        public ActionResult Browse(string genre)
        {
            TempData data = new TempData();
            var genreModel = data.GetGenres().Where(x => x.Name == genre).FirstOrDefault();
            genreModel.Games = data.GetGames().Where(g => g.Genre.Name == genre).ToList();
            return View(genreModel);
        }
        //
        //GET: /Store/Details
        public ActionResult Details(int id)
        {
            TempData tempData = new TempData();
            var game = tempData.GetGames().Where(x => x.GameID == id).FirstOrDefault();
            return View(game);
        }
    }
}