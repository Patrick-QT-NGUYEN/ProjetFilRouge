using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netflix_Clone_API_Back.Tools;
using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Classes;
using System.Diagnostics.SymbolStore;
using System.Data.SqlClient;

namespace Netflix_Clone_API_Back.Classes
{
    public class Episodes
    {
        //parametre Episode
        //private int id;
        private int id;
        private string nameEpisodes;
        private int nbEpisodes;
        //private string descriptionEpisode;
        private string lien;

        //Parametre Saisons
        private int saisonId;
        private string saisonImg;
        private string saisonLien;
        private DateTime saisonAnnees;

        public Episodes()
        {

        }

        public Episodes(int id, string nameEpisodes, string lien, int nbEpisodes, int saisonId, string saisonsImg, string saisonLien, DateTime saisonAnnees)
        {
            // this.Id = id;
            this.id = id;
            this.nameEpisodes = nameEpisodes;
            //this.DescriptionEpisode = descriptionEpisode;
            this.lien = lien;
            this.nbEpisodes = nbEpisodes;
            this.saisonId = saisonId;
            this.saisonImg = saisonLien;
            this.saisonLien = saisonLien;
            this.saisonAnnees = saisonAnnees;

        }

        //episode
        public int Id { get => id; set => id = value; }
       //public int EpisodesId { get => episodesId; set => episodesId = value; }
        public string NameEpisodes { get => nameEpisodes; set => nameEpisodes = value; }
        // public string DescriptionEpisode { get => descriptionEpisode; set => descriptionEpisode = value; }
        public string Lien { get => Lien; set => Lien = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        //saison
        public int SaisonId { get => saisonId; set => saisonId = value; }
        public string SaisonImg { get => saisonImg; set => saisonImg = value; }
        public string SaisonLien { get => saisonLien; set => saisonLien = value; }
        public DateTime SaisonAnnees { get => saisonAnnees; set => saisonAnnees = value; }

        
        

        public override string ToString()
        {
            return $"ID : {Id}\tNameEpisode :{NameEpisodes}\tNbEpisodes : {nbEpisodes}\tLien : {Lien}SaisonId : {SaisonId}\tSaisonImg : {SaisonImg}\tSaisonLien : {SaisonLien}\tSaisonAnnees : {SaisonAnnees}";
        }



















    }
}
