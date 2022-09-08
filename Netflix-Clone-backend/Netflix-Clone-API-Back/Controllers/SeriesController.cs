using Microsoft.AspNetCore.Mvc;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.DAO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Netflix_Clone_API_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        // GET: api/<SeriesController>
        [HttpGet]
        public IEnumerable<Series> Get()
        {
            List<Series> series = new();
            SeriesDAO seriesDAO = new();
            series = seriesDAO.FindAll();
            return series;
        }

        // GET api/<SeriesController>/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
            SeriesDAO seriesDAO = new SeriesDAO();

            return seriesDAO.Find(id).Item2;
        }

        // POST api/<SeriesController>
        [HttpPost]
        public string Post([FromBody] Series serie)
        {
            SeriesDAO serieDAO = new SeriesDAO();

            return serieDAO.Create(serie)>0 ? "Série ajoutée":"Erreur lors de l'ajout";
        }

        // PUT api/<SeriesController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Series serie)
        {
            SeriesDAO serieDAO = new ();
            return serieDAO.Update(serie) ? $"Série n°{serie.Id} mis à jour" : "Erreur lors de la mise à jour";
        }

        // DELETE api/<SeriesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            SeriesDAO serieDAO = new SeriesDAO();
            return serieDAO.Delete(id) ? $"Série n°{id} supprimée" : "Erreur lors de la suppression";
        }
    }
}
