using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperheroGallery.DataAccess.Entities;

namespace SuperheroGallery.DataAccess.Contracts
{
    public interface IHeroStorage
    {
        IEnumerable<Hero> GetAll();
        Hero GetById(int id);
        Hero UpdateHero(Hero hero);
    }
}
