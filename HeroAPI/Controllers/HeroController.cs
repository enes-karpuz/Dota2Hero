using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HeroAPI.Models;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroDbContext _heroDbContext;

        public HeroController(HeroDbContext heroDbContext)
        {
            _heroDbContext = heroDbContext;
        }

        [HttpGet]
        public IActionResult GetHeroes()
        {
            return Ok(_heroDbContext.Heroes.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetHeroById(int id)
        {
            var hero = Ok(_heroDbContext.Heroes.Find(id));
            if (hero == null)
            {
                return NotFound();
            }
            return Ok(hero);
        }

        [HttpPost]
        public IActionResult CreateHero(Hero hero)
        {
            _heroDbContext.Heroes.Add(hero);
            _heroDbContext.SaveChanges();
            return Ok(hero);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHero(int id, Hero hero)
        {
            _heroDbContext.Heroes.Update(hero);
            _heroDbContext.SaveChanges();
            return Ok(hero);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHero(int id)
        {
            var hero = _heroDbContext.Heroes.Find(id);
            _heroDbContext.Heroes.Remove(hero);
            _heroDbContext.SaveChanges();
            return Ok();
        }
    }
}
