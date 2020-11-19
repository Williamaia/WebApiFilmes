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
    public class DirectorsController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public DirectorsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [ResponseCache(Duration = 20, Location = ResponseCacheLocation.None)]
        public IActionResult Get()
        {
            List<DirectorsDto> directorsDto = new List<DirectorsDto>();

            var directors = _dataContext.Directors.ToList();

            foreach(var director in directors)
            {
                directorsDto.Add(new DirectorsDto()
                {
                    codigo_director = director.Id,
                    name = director.Nome,
                    qnt_filme = director.Quantidade_Filmes
                });
            }

            return Ok(directorsDto);
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string name, [FromQuery] string sort)
        {
            List<Directors> directors = new List<Directors>();

            switch (sort)
            {
                case "asc":
                    directors = _dataContext.Directors.Where(d => d.Nome.ToLower().Contains(name.ToLower())).OrderBy(d => d.Nome).ToList();
                    break;

                case "desc":
                    directors = _dataContext.Directors.Where(d => d.Nome.ToLower().Contains(name.ToLower())).OrderByDescending(d => d.Nome).ToList();
                    break;

                default:
                    directors = _dataContext.Directors.Where(d => d.Nome.ToLower().Contains(name.ToLower())).OrderBy(d => d.Nome).ToList();
                    break;
            }

            if (directors.Count() == 0)
                return NotFound();

            return Ok(directors);
        }

        [HttpGet("{id}")]
        public ActionResult Find(int id)
        {
            var _dir = _dataContext.Directors.Where(m => m.Id == id).FirstOrDefault();

            if (_dir != null)
            {
                return Ok(_dir);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Create(DirectorsDto directors)
        {
            var _dir = new Directors();

            _dir.Nome = directors.name;
            _dir.Quantidade_Filmes = directors.qnt_filme;

            _dataContext.Directors.Add(_dir);
            _dataContext.SaveChanges();
            return Ok(directors);
        }

        [HttpPut]
        public ActionResult Edit(DirectorsDto directors)
        {
            var _dir = _dataContext.Directors.Where(d => d.Id == directors.codigo_director).FirstOrDefault();

            if (directors != null)
            {
                Console.WriteLine(directors.ToString());
                _dir.Nome = directors.name;
                _dir.Quantidade_Filmes = directors.qnt_filme;
                _dataContext.SaveChanges();
            }

            return Ok(directors);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var directors = _dataContext.Movies.Where(_dir => _dir.Id == id).FirstOrDefault();

            if (directors != null)
            {
                _dataContext.Movies.Remove(directors);
                _dataContext.SaveChanges();
            }

            return Ok(directors);
        }
    }
}
