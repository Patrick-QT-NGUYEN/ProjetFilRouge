using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Netflix_Clone_API_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        // GET: api/<EpisodesController>
        [HttpGet]
        public IEnumerable<Episodes> Get()
        {
            List<Episodes> episodes = new List<Episodes>();
            EpisodesDAO episodesDAO = new EpisodesDAO();
            episodes = episodesDAO.FindAll();
            return episodes;
        }

        // GET api/<EpisodesController>/5
        [HttpGet("{id}")]
        public Episodes Get(int id)
        {
            EpisodesDAO episodesDAO = new();

            return episodesDAO.Find(id).Item2;
        }

        // POST api/<EpisodesController>
        [HttpPost]
        public string Post([FromBody] Episodes episodes)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Create(episodes) > 0 ? "Episode Ajouté" : "Erreur lors de l'ajout";
        }

        // PUT api/<EpisodesController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Episodes episodes)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Update(episodes) ? $"Episodes n°{episodes.Id} mis à jour" : "Erreur lors de la mise à jour";
        }

        // DELETE api/<EpisodesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Delete(id) ? $"Episode n°{id} supprimé" : "Erreur lors de la suppression";
        }
    }
}
