using System;
using System.Collections.Generic;
using System.Linq;
using SuperheroGallery.DataAccess.Context;
using SuperheroGallery.DataAccess.Contracts;
using SuperheroGallery.DataAccess.Entities;

namespace SuperheroGallery.DataAccess.Infrastructure
{
    public class HeroStorage : IHeroStorage
    {
        private readonly DbContext _db;

        public HeroStorage()
        {
            this._db = DbContext.getHeroes();
        }

        public IEnumerable<Hero> GetAll()
        {
            return _db.Heroes;
        }

        public Hero GetById(int id)
        {
            return _db.Heroes.FirstOrDefault(x => x.Id == id);
        }

        public Hero UpdateHero(Hero hero)
        {
            return hero;
        }
    }
}
