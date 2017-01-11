using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SuperheroGallery.DataAccess.Entities;
using SuperheroGallery.Web.Desktop.Models;

namespace SuperheroGallery.Web.Desktop.App_Start
{
    public class MapConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<HeroModel, Hero>());
        }
    }
}