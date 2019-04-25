using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace MVCgame.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public string ReleaseMonth { get; set; }
        public int ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Platform Platforms { get; set;}
    }
}