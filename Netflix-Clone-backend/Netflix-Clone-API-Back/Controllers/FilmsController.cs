using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.DAO;
using Netflix_Clone_API_Back.Classes;
using System.Collections.ObjectModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Netflix_Clone_API_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        // GET: api/<FilmsController>
        [HttpGet]
        public IEnumerable<Films> Get()
        {
            List<Films> films = new List<Films>();
            FilmsDAO filmDAO = new FilmsDAO();
            films = filmDAO.FindAll();
            return films;
        }

        // GET api/<FilmsController>/5
        [HttpGet("{id}")]
        public Films Get(int id)
        {
            FilmsDAO filmDAO = new();

            return filmDAO.Find(id).Item2;
        }

        // POST api/<FilmsController>
        [HttpPost]
        public string Post([FromBody] Films film)
        {
            FilmsDAO filmDAO = new();
            return filmDAO.Create(film) > 0 ? "Film Ajouté" : "Erreur lors de l'ajout";
        }

        // PUT api/<FilmsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Films film)
        {
            FilmsDAO filmDAO = new();
            return filmDAO.Update(film) ? $"Film n°{film.Id} mis à jour" : "Erreur lors de la mise à jour";
        }

        // DELETE api/<FilmsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            FilmsDAO filmDAO = new();
            return filmDAO.Delete(id) ? $"Film n°{id} supprimé" : "Erreur lors de la suppression";
        }
    }
}
