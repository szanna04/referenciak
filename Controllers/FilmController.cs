using cherry_P20QE5.JokeModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cherry_P20QE5.Controllers
{
    [Route("api/film")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        // GET: api/<FilmController>
        // összes megejelnítése
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Films.ToList());
        }

        // GET api/<FilmController>/5
        // id alapján
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var film = (from x in context.Films
                        where x.FilmId == id
                        select x).FirstOrDefault();
            if (film == null)
            { return NotFound("nincs ilyen azonosítójú könyv"); }
            return Ok(film);
        }

        // cím alapján
        [HttpGet("getbytitle/{title}")]
        public IActionResult GetM(string title)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var film = (from x in context.Films
                        where x.Title == title
                        select x).FirstOrDefault();
            if (film == null)
            { return NotFound("nincs ilyen azonosítójú könyv"); }
            return Ok(film);
        }

        // POST api/<FilmController>
        //hozzáadás
        [HttpPost]
        public void Post([FromBody] Film film)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Films.Add(film);
            context.SaveChanges();
        }

        // elérhetőség módosítása
        [HttpPost("{id}")]
        public IActionResult PostM(int id, [FromBody] bool value)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var filmmodify = (from x in context.Films
                        where x.FilmId == id
                        select x).FirstOrDefault();
            if (filmmodify == null)
            { return NotFound("nincs ilyen azonosítójú könyv"); }
            filmmodify.IsAvailable = value;
            context.SaveChanges();
            return Ok("siker");
        }

        // megjelenés módosítása
        [HttpPost("megejelenes/{id}")]
        public IActionResult PostK(int id, [FromBody] int value)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var filmmodify = (from x in context.Films
                              where x.FilmId == id
                              select x).FirstOrDefault();
            if (filmmodify == null)
            { return NotFound("nincs ilyen azonosítójú könyv"); }
            filmmodify.ReleaseYear = value;
            context.SaveChanges();
            return Ok("siker");
        }

        // DELETE api/<FilmController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var filmtorles = (from x in context.Films
                              where x.FilmId == id
                              select x).FirstOrDefault();
            if (filmtorles == null)
            { return NotFound("nincs ilyen azonosítójú könyv"); }
            context.Films.Remove(filmtorles);
            context.SaveChanges();
            return Ok("siker");
        }
    }
}
