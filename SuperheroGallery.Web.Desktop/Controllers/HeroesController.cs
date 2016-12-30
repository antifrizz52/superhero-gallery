using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebSockets;
using SuperheroGallery.Web.Desktop.Models;

namespace SuperheroGallery.Web.Desktop.Controllers
{
    [RoutePrefix("heroes")]
    public class HeroesController : ApiController
    {
        public List<Hero> heroes = new List<Hero>
            {
                new Hero {Id = 0, Name = "Superman", Rating = 4, Description = "Superman bla bla bla", LogoUrl = "app/heroes/superman-logo.png"},
                new Hero {Id = 1, Name = "Batman", Rating = 4, Description = "Batman bla bla bla", LogoUrl = "app/heroes/batman-logo.png"},
                new Hero {Id = 2, Name = "Spiderman", Rating = 3, Description = "Spiderman", LogoUrl = "app/heroes/spiderman-logo.png"},
                new Hero {Id = 3, Name = "Hulk", Rating = 5, Description = "Hulk bla bla bla", LogoUrl = "app/heroes/hulk-logo.png"},
                new Hero {Id = 4, Name = "Ironman", Rating = 5, Description = "Ironman bla bla bla", LogoUrl = "app/heroes/ironman-logo.png"}
            };

        // GET: api/Heroes
        //        [Route]
        //        public HttpResponseMessage Get()
        //        {
        //            var response = Request.CreateResponse(HttpStatusCode.OK, heroes);
        //
        //            return response;
        //        }
        [Route]
        public IHttpActionResult Get()
        {
            return Ok(heroes);
        }

        // GET: api/Heroes/5
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            Hero hero = heroes.Find(x => x.Id == id);

            var response = Request.CreateResponse(HttpStatusCode.OK, hero);

            return response;
        }

        // POST: api/Heroes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Heroes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Heroes/5
        public void Delete(int id)
        {
        }
    }
}
