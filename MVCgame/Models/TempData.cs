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
            new Genre {GenreID = 1, Name = "Strategy"},
            new Genre {GenreID = 2, Name = "Adventure"},
            new Genre {GenreID = 3, Name = "Action"},
            new Genre {GenreID = 4, Name = "Role-Playing"},
            new Genre {GenreID = 5, Name = "Simulation"},
            new Genre {GenreID = 6, Name = "Sports"},
            new Genre {GenreID = 7, Name = "Racing"},
            new Genre {GenreID = 8, Name = "First-person shooter"},
           
            };
            return genres;
        }

        public List<Platform> GetPlatforms()
        {
            var platform = new List<Platform>()
            {
                new Platform {PlatformID = 1, System = "Nintendo Switch"},
                new Platform {PlatformID = 2, System = "Windows"},
                new Platform {PlatformID = 3, System = "Mac"},
                new Platform {PlatformID = 4, System = "Xbox"},
                new Platform {PlatformID = 5, System = "Playstation 4"},
                new Platform {PlatformID = 6, System = "Linux"},
            };
            return platform;

        }

        public List<Game> GetGames()
        {
            var genres = GetGenres();
            var platform = GetPlatforms();

            List<Game> games = new List<Game>
            {

                new Game{GameID = 1, Title = "The Escapists 2", ReleaseDate = 11, ReleaseMonth = "January",
                    Genre = genres.Single(g => g.Name == "Role-Playing"), Platforms = platform.Single(p => p.System == "Nintendo Switch")},
                new Game{GameID = 2, Title = "Shadow of the Colossus", ReleaseDate = 6, ReleaseMonth = "February",
                    Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.System == "Playstation 4")},
                new Game{GameID = 3, Title = "Rust", ReleaseDate = 6, ReleaseMonth = "February",
                    Genre = genres.Single(g => g.Name == "Adventure"), Platforms = platform.Single(p => p.System == "Windows")},
                new Game{GameID = 4, Title = "God of War", ReleaseDate = 20, ReleaseMonth = "April",
                    Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.System == "Playstation 4")},
                new Game{GameID = 5, Title = "Conan Exiles", ReleaseDate = 8, ReleaseMonth = "May",
                    Genre = genres.Single(g => g.Name =="Action"), Platforms = platform.Single(p => p.System == "Windows")},
                new Game{GameID = 6, Title = "The Crew 2", ReleaseDate = 29, ReleaseMonth = "June",
                    Genre = genres.Single(g => g.Name == "Racing"), Platforms = platform.Single(p => p.System == "Windows")},
                new Game{GameID = 7, Title = "No Man's Sky", ReleaseDate = 24, ReleaseMonth = "July",
                    Genre = genres.Single(g => g.Name == "Action"), Platforms = platform.Single(p => p.System == "Xbox")},
                new Game{GameID = 8, Title = "Divinity: Original Sin II", ReleaseDate = 31, ReleaseMonth = "August",
                    Genre = genres.Single(g => g.Name == "Role-Playing"), Platforms = platform.Single(p => p.System == "Playstation 4")},
                new Game{GameID = 9, Title = "Surving Mars", ReleaseDate = 15, ReleaseMonth = "March",
                    Genre = genres.Single(g => g.Name == "Simulation"), Platforms = platform.Single(p => p.System == "Nintendo Switch")},
                new Game{GameID = 10, Title = "Detective Pikachu", ReleaseDate = 23, ReleaseMonth = "March",
                    Genre = genres.Single(g => g.Name == "Adventure"), Platforms = platform.Single(p => p.System == "Nintendo Switch")},
                new Game{GameID = 11, Title = "South Park: The Fractured but Whole", ReleaseDate = 24, ReleaseMonth = "April",
                    Genre = genres.Single(g => g.Name == "Role-Playing"), Platforms = platform.Single(p => p.System == "Nintendo Switch")},
                new Game{GameID = 12, Title = "Total War Saga: Thrones of Britannia ", ReleaseDate = 3, ReleaseMonth = "May",
                    Genre = genres.Single(g => g.Name == "Strategy"), Platforms = platform.Single(p => p.System == "Windows")},
                new Game{GameID = 13, Title = "Insurgency: Sandstorm", ReleaseDate = 12, ReleaseMonth = "December",
                    Genre = genres.Single(g => g.Name == "First-person shooter"), Platforms = platform.Single(p => p.System == "Windows")},
                new Game{GameID = 14, Title = "Mutant Football League: Dynasty Edition", ReleaseDate = 30, ReleaseMonth = "October",
                    Genre = genres.Single(g => g.Name == "Sports"), Platforms = platform.Single(p => p.System == "Windows")},
            };
            return games;
        }

      
    }
}