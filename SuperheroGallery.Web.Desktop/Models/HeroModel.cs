using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperheroGallery.Web.Desktop.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
    }
}