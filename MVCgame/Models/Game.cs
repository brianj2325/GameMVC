using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.SqlServer.Server;

namespace MVCgame.Models
{
    [Bind(Exclude = "GameID")]
    public class Game
    {
        [ScaffoldColumn(false)]
        public int GameID { get; set; }
        [DisplayName("Genre")]
        public int GenreID { get; set; }
        [DisplayName ("Platform")]
        public int PlatformID { get; set; }
        [Required(ErrorMessage = "A Game title is required.")]
        public string Name { get; set; }
        public string ReleaseMonth { get; set; }
        public int ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Platform Platforms { get; set;}
    }
}