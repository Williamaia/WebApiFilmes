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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var director = _dataContext.Directors.Find(id);

            if (director == null)
                return NotFound();

            return Ok(director);
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

        [HttpPost]
        [Route("directors/novodirector")]
        public ActionResult Create(Directors directors)
        {
            _dataContext.Directors.Add(directors);
            _dataContext.SaveChanges();
            return Ok(directors);
        }
    }
}
