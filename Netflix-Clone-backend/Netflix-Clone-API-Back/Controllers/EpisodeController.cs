using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Netflix_Clone_API_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        // GET: api/<EpisodeController>
        [HttpGet]
        public IEnumerable<Episode> Get()
        {
            List<Episode> episodes = new List<Episode>();
            EpisodeDAO episodeDAO = new();
            episodes = episodeDAO.FindAll();
            return episodes;
        }

        // GET api/<EpisodeController>/5
        [HttpGet("{id}")]
        public Episode Get(int id)
        {
            EpisodeDAO episodeDAO = new();
            return episodeDAO.Find(id).Item2;
        }

        // POST api/<EpisodeController>
        [HttpPost]
        public string Post([FromBody] Episode episode)
        {
            EpisodeDAO episodeDAO = new();
            return episodeDAO.Create(episode) > 0 ? "Episode Ajouté" : "Erreur lors de l'ajout de l'épisode";

        }

        // PUT api/<EpisodeController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Episode episode)
        {
            EpisodeDAO episodeDAO=new();

            return episodeDAO.Update(episode) ? $"Episode n°{episode.Id} mis à jour !" : "Erreur lors de la mise à jour";
        }

        // DELETE api/<EpisodeController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            EpisodeDAO episodeDAO = new();
            return episodeDAO.Delete(id) ? $"Episode n°{id} supprimé !" : "Errreur lors de la suppression";
        }
    }
}
