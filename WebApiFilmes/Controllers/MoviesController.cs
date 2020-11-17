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


        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var movie = _dataContext.Movies.Find(id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
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
    }
}
