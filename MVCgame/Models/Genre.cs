using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCgame.Models
{
    public class Genre
    {
        public int GenreID { get; set;}
        public string Name { get; set; }
        public List<Game> Games { get; set; }

    }
}