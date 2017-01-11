using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SuperheroGallery.DataAccess.Entities;

namespace SuperheroGallery.DataAccess.Context
{
    public class DbContext
    {
        private static DbContext instance;

        public IEnumerable<Hero> Heroes { get; private set; }

        private DbContext(IEnumerable<Hero> heroes)
        {
            this.Heroes = heroes;
        }

        public static DbContext getHeroes()
        {
            if (instance == null)
            {
                var heroes = new List<Hero>
                {
                    new Hero
                    {
                        Id = 0,
                        Name = "Superman",
                        Rating = 4,
                        Description = "Superman bla bla bla",
                        LogoUrl = "app/heroes/superman-logo.png"
                    },
                    new Hero
                    {
                        Id = 1,
                        Name = "Batman",
                        Rating = 4,
                        Description = "Batman bla bla bla",
                        LogoUrl = "app/heroes/batman-logo.png"
                    },
                    new Hero
                    {
                        Id = 2,
                        Name = "Spiderman",
                        Rating = 3,
                        Description = "Spiderman",
                        LogoUrl = "app/heroes/spiderman-logo.png"
                    },
                    new Hero
                    {
                        Id = 3,
                        Name = "Hulk",
                        Rating = 5,
                        Description = "Hulk bla bla bla",
                        LogoUrl = "app/heroes/hulk-logo.png"
                    },
                    new Hero
                    {
                        Id = 4,
                        Name = "Ironman",
                        Rating = 5,
                        Description = "Ironman bla bla bla",
                        LogoUrl = "app/heroes/ironman-logo.png"
                    }
                };

                instance = new DbContext(heroes);
            }

            return instance;
        } 
    }
}
