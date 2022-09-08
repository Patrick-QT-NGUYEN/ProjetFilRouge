using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.DAO;
using Netflix_Clone_API_Back.Classes;
using System.Collections.ObjectModel;

namespace Netflix_Clone_API_Back.Controllers
{
    public class EpisodesController : ControllerBase
    {
        // GET: EpisodesController
        [HttpGet]

        public IEnumerable<Episodes> Get()
        {
            List<Episodes> episodes = new List<Episodes>();
          EpisodesDAO episodesDAO = new EpisodesDAO();
            episodes = episodesDAO.FindAll();
            return episodes;
        }
        [HttpGet("{id}")]
        public Episodes Get(int id)
        {
           EpisodesDAO episodesDAO = new();

            return episodesDAO.Find(id).Item2;
        }

        // POST api/<FilmsController>
        [HttpPost]
        public string Post([FromBody] Episodes episodes)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Create(episodes) > 0 ? "Episode Ajouté" : "Erreur lors de l'ajout";
        }


        // PUT api/<FilmsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Episodes episodes)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Update(episodes) ? $"Episodes n°{episodes.EpisodesId} mis à jour" : "Erreur lors de la mise à jour";
        }

        // PUT api/<FilmsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Episodes episodes)
        {
            EpisodesDAO episodesDAO = new();
            return episodesDAO.Update(episodes) ? $"Episodes n°{episodes.EpisodesId} mis à jour" : "Erreur lors de la mise à jour";
        }
    }
}
