using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFilmes.Dtos;
using WebApiFilmes.Models;

namespace WebApiFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        /*
         * 200 ok
         * 500 internal server error
         * 400 bad request
         * 404 not found
         */

        private readonly DataContext _dataContext;



        public MoviesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [ResponseCache(Duration = 20, Location = ResponseCacheLocation.None)]
        public IActionResult Get()
        {
            List<MoviesDto> moviesDtos = new List<MoviesDto>();

            var movies = _dataContext.Movies.ToList();

            foreach (var movie in movies)
            {
                moviesDtos.Add(new MoviesDto() {
                    codigo_filme = movie.Id,
                    nota = movie.Rank,
                    nome_filme = movie.Title
                });
            }

            return Ok(moviesDtos);
        }


        [HttpGet("search")]
        public IActionResult Search([FromQuery]string name, [FromQuery]string sort)
        {
            List<Movies> movies = new List<Movies>();

            switch (sort)
            {
                case "asc":
                    movies = _dataContext.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).OrderBy(m => m.Title).ToList();
                    break;

                case "desc":
                    movies = _dataContext.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).OrderByDescending(m => m.Title).ToList();
                    break;

                default:
                    movies = _dataContext.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).OrderBy(m => m.Title).ToList();
                    break;
            }

            if (movies.Count() == 0)
                return NotFound();

            return Ok(movies);
        }

        [HttpGet("{id}")] 
        public ActionResult Find(int id)
        {
            var _movie = _dataContext.Movies.Where(m => m.Id == id).FirstOrDefault();

            if (_movie != null)
            {
                return Ok(_movie);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Create(MoviesDto movies)
        {
            var _movie = new Movies();

            _movie.Rank = movies.nota;
            _movie.Title = movies.nome_filme;

            _dataContext.Movies.Add(_movie);
            _dataContext.SaveChanges();
            return Ok(movies);
        }

        [HttpPut]
        public ActionResult Edit(MoviesDto movie)
        {
            var _movie = _dataContext.Movies.Where(m => m.Id == movie.codigo_filme).FirstOrDefault();

            if (movie != null)
            {
                Console.WriteLine(movie.ToString());
                _movie.Rank = movie.nota;
                _movie.Title = movie.nome_filme;
                _dataContext.SaveChanges();
            }

            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var movie = _dataContext.Movies.Where(_movie => _movie.Id == id).FirstOrDefault();

            if(movie != null)
            {
                _dataContext.Movies.Remove(movie);
                _dataContext.SaveChanges();
            }

            return Ok(movie);
        }

    }
}
