using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using MVCgame.Models;

namespace MVCgame.Models
{
    public class TempData
    {
        
        public List<Genre> GetGenres()
        {
            var genres  = new List<Genre> { 
            new Genre() {GenreID = 1, Name = "Strategy"},
            new Genre() {GenreID = 2, Name = "Fighting"},
            new Genre() {GenreID = 3, Name = "Action"},
            new Genre() {GenreID = 4, Name = "Role-Playing"},
            new Genre() {GenreID = 5, Name = "Simulation"},
            new Genre() {GenreID = 6, Name = "Sports"},
            new Genre() {GenreID = 7, Name = "Racing"},
            new Genre() {GenreID = 8, Name = "First-person shooter"},
           
            };
            return genres;
        }

        public List<Platform> GetPlatforms()
        {
            var platform = new List<Platform>()
            {
                new Platform {PlatformID = 1, Name = "Nintendo Switch"},
                new Platform {PlatformID = 2, Name = "Windows"},
                new Platform {PlatformID = 3, Name = "Mac"},
                new Platform {PlatformID = 4, Name = "Xbox"},
                new Platform {PlatformID = 5, Name = "Playstation 4"},
                new Platform {PlatformID = 6, Name = "Linux"},
            };
            return platform;

        }

        public List<Game> GetGames()
        {
            var genres = GetGenres();
            var platform = GetPlatforms();

            List<Game> games = new List<Game>()
            {
                new Game{GameID = 1, Name = "The Escapists 2", ReleaseDate = 11, ReleaseMonth = "January", Genre = genres.Single(g => g.Name == "Roleplaying"),Platforms = platform.Single(p => p.Name== "Nintendo Switch")},
                new Game{GameID = 2, Name = "Shadow of the Colossus", ReleaseDate = 6, ReleaseMonth = "February", Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.Name== "Playstion 4")},
                new Game{GameID = 3, Name = "Rust", ReleaseDate = 6, ReleaseMonth = "February", Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.Name== "Windows")},
                new Game{GameID = 4, Name = "God of War", ReleaseDate = 20, ReleaseMonth = "April", Genre = genres.Single(g => g.Name=="Action"), Platforms = platform.Single(p => p.Name == "Playstation 4")},
                new Game{GameID = 5, Name = "Conan Exiles", ReleaseDate = 8, ReleaseMonth = "May",Genre = genres.Single(g => g.Name =="Action"), Platforms = platform.Single(p => p.Name == "Windows")},
                new Game{GameID = 6, Name = "The Crew 2", ReleaseDate = 29, ReleaseMonth = "June", Genre = genres.Single(g => g.Name == "Racing"), Platforms = platform.Single(p => p.Name== "Windows")},
                new Game{GameID = 7, Name = "No Man's Sky", ReleaseDate = 24, ReleaseMonth = "July", Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.Name == "Xbox")},
                new Game{GameID = 8, Name = "Divinity: Original Sin II", ReleaseDate = 31, ReleaseMonth = "August", Genre = genres.Single(g => g.Name == "Role-Playing"), Platforms = platform.Single(p => p.Name == "Playstation 4")},
                new Game{GameID = 0, Name = "Undertale", ReleaseDate = 18, ReleaseMonth = "September", Genre = genres.Single(g => g.Name == "Role-Playing"), Platforms = platform.Single(p => p.Name == "Nintendo Switch")},
            };
            return games;
        }

      
    }
}