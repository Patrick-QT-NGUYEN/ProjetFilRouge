using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.DAO;
using Netflix_Clone_API_Back.Classes;
using System.Collections.ObjectModel;

namespace Netflix_Clone_API_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        [HttpGet]
        // GET: api/<SeriesController>
        public IEnumerable<Series> Get()
        {
            List<Series> series = new List<Series>();
            SeriesDAO seriesDAO = new SeriesDAO();
            series = seriesDAO.FindAll();
            return series;
        }

        // GET: SeriesController/Details/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
            SeriesDAO seriesDAO = new();
            return seriesDAO.Find(id).Item2;
        }


        // POST: api/SeriesController/Create
        [HttpPost]
        public string Post([FromBody] Series series)
        {
            SeriesDAO seriesDAO = new();
            return seriesDAO.Create(series) > 0 ? "Serie Ajouté" : "Erreur lors de l'ajout";
        }

        // put: SeriesController/Edit/5
        [HttpPut("{id}")]
        public string Put(int Id, [FromBody] Series series)
        {
            SeriesDAO seriesDAO = new();
            return seriesDAO.Update(series) ? $"Film n°{series.Id} mis à jour" : "Erreur lors de la mise à jour";
        }

        // DELETE: SeriesController/Edit/5
        [HttpPut("{id}")]
        public string Delete(int id)
        {
            SeriesDAO seriesDAO = new();
            return seriesDAO.Delete(id) ? $"Film n°{id} supprimé !" : "Erreur lors de la suppression";
        }

    }
}
