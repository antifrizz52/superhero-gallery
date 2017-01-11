using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebSockets;
using AutoMapper;
using SuperheroGallery.DataAccess.Contracts;
using SuperheroGallery.DataAccess.Entities;
using SuperheroGallery.Web.Desktop.Models;

namespace SuperheroGallery.Web.Desktop.Controllers
{
    [RoutePrefix("heroes")]
    public class HeroesController : ApiController
    {
        private readonly IHeroStorage _heroes;

        public HeroesController(IHeroStorage heroes)
        {
            this._heroes = heroes;
        }

        [Route]
        public IHttpActionResult Get()
        {
            return Ok(_heroes.GetAll());
        }

        // GET: api/Heroes/5
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(_heroes.GetById(id));
        }

        // POST: api/Heroes
        [Route]
        public IHttpActionResult Post([FromBody]HeroModel hero)
        {
            var result = _heroes.UpdateHero(Mapper.Map<HeroModel, Hero>(hero));

            return Ok(result);
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
