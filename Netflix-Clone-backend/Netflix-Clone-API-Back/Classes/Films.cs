using Netflix_Clone_API_Back.Tools;
using Netflix_Clone_API_Back.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Clone_API_Back.Classes
{
    public class Films
    {
        private int id;
        private string title;
        private string description;
        private string poster;
        private string director;
        private DateTime releaseDate;
        private string trailer;
        private string genre;
        
        

        public Films()
        {

        }

        public Films(int id, string title, string description, string poster, string director, DateTime releaseDate, string trailer, string genre)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.poster = poster;
            this.director = director;
            this.releaseDate = releaseDate;
            this.trailer = trailer;
            this.genre = genre;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Poster { get => poster; set => poster = value; }
        public string Director { get => director; set => director = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Trailer { get => trailer; set => trailer = value; }
        public string Genre { get => genre; set => genre = value; }

       

        //public static List<Films> SearchContact(string search)
        //{
        //    return Find(f => f.Title.Contains(search) || f.Description.Contains(search) || f.Director.Contains(search));
        //}

       

        public override string ToString()
        {
            return $"ID : {Id}\tTitle : {Title} \nDescription : {Description}\nPoster:{Poster}\nDirector:{Director}\nReleaseDate:{ReleaseDate}\ntrailer:{trailer}\nGenre:{genre}";
        }


    }
}
