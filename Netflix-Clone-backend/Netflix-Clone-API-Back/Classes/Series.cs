using Netflix_Clone_API_Back.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Clone_API_Back.Classes
{
    public class Series
    {
        private int id;
        private string name;
        private string genres;
        private int saisons;
        private int episodes;
        private string description;
        private string status;
        private DateTime releaseDate;
        
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Series()
        {

        }

        public Series(int id, string name, string genres, int saisons, int episodes, string description, string status, DateTime releaseDate)
        {
            this.id = id;
            this.name = name;
            this.genres = genres;
            this.saisons = saisons;
            this.episodes = episodes;
            this.description = description;
            this.Status = status;
            this.releaseDate = releaseDate;

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Genres { get => genres; set => genres = value; }
        public int Saisons { get => saisons; set => saisons = value; }
        public int Episodes { get => episodes; set => episodes = value; }
        public string Description { get => description; set => description = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Status { get => status; set => status = value; }

        
        
                
        
        public override string ToString()
        {
            return $"ID : {Id}\tNom : {Name} \nGenres : {Genres}\n Saisons : {Saisons}\nEpisodes : {Episodes} Description : {Description}\nReleaseDate:{ReleaseDate}";
        }

    }
}
