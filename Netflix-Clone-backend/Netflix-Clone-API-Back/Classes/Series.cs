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
    internal class Series
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
            this.status = status;
            this.releaseDate = releaseDate;

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Genres { get => genres; set => genres = value; }
        public int Saisons { get => saisons; set => saisons = value; }
        public int Episodes { get => episodes; set => episodes = value; }
        public string Description { get => description; set => description = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }

        #region GET GETALL ADD UPDATE DELETE 
        
        //public (bool, Series) Get(int id)
        //{
        //    Series serie = null;
        //    bool found = false;

        //    _connection = Connection.New;

        //    _request = "SELECT se.id, se.Name, se.Genres, se.Saisons, se.Episodes, se.Description, se.ReleaseDate " +
        //        "FROM Series AS se " +
        //        "WHERE se.id = @Id";

        //    _command = new SqlCommand(_request, _connection);

        //    _command.Parameters.Add(new SqlParameter("@Id", id));

        //    _connection.Open();

        //    _reader = _command.ExecuteReader();

        //    if (_reader.Read())
        //    {
        //        serie = new Series()
        //        {

        //            Id = _reader.GetInt32(0),
        //            Name = _reader.GetString(1),
        //            Genres = _reader.GetString(2),
        //            Saisons = _reader.GetInt32(3),
        //            Episodes = _reader.GetInt32(4),
        //            Description = _reader.GetString(5),
        //            ReleaseDate = _reader.GetDateTime(6)
        //        };
        //        found = true;
        //    }
        //    _reader.Close();
        //    _command.Dispose();
        //    _connection.Close();

        //    return (found, serie);
        //}

        //public static List<Series> GetAll()
        //{
        //    List<Series> series = new List<Series>();

        //    SqlConnection connection = Connection.New;

        //    string request = "SELECT se.id, se.Name, se.Genres, se.Saisons, se.Episodes, se.Description, se.ReleaseDate" +
        //        "FROM Series AS se";

        //    SqlCommand command = new SqlCommand(request, connection);

        //    connection.Open();

        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Series serie = new Series()
        //        {
        //            Id = reader.GetInt32(0),
        //            Name = reader.GetString(1),
        //            Genres = reader.GetString(2),
        //            Saisons = reader.GetInt32(3),
        //            Episodes = reader.GetInt32(4),
        //            Description = reader.GetString(5),
        //            ReleaseDate = reader.GetDateTime(6)
        //        };
        //        series.Add(serie);
        //    }

        //    reader.Close();
        //    command.Dispose();
        //    connection.Close();

        //    return series;
        //}

        //public virtual int Add()
        //{
        //    _connection = Connection.New;

        //    _request = "INSERT INTO Series (Name, Genres, Saisons, Episodes, Description, ReleaseDate) OUTPUT INSERTED.ID VALUES (@Name, @Genres, @Saisons, @Episodes, @Description, @ReleaseDate)";

        //    _command = new SqlCommand(_request, _connection);

        //    _command.Parameters.Add(new SqlParameter("@Name", Name));
        //    _command.Parameters.Add(new SqlParameter("@Genres", Genres));
        //    _command.Parameters.Add(new SqlParameter("@Saisons", Saisons));
        //    _command.Parameters.Add(new SqlParameter("@Episodes", Episodes));
        //    _command.Parameters.Add(new SqlParameter("@Description", Description));
        //    _command.Parameters.Add(new SqlParameter("@ReleaseDate", ReleaseDate));

        //    _connection.Open();
        //    int Id = (int)_command.ExecuteScalar();

        //    _command.Dispose();
        //    _connection.Close();

        //    return Id;
        //}

        //public virtual bool Update()
        //{
        //    _connection = Connection.New;

        //    _request = "UPDATE Series SET Name =@Name, Genres = @Genres, Saisons=@Saisons, Episodes=@Episodes, Description =@Description, ReleaseDate=@ReleaseDate WHERE id=SeriesId ";

        //    _command = new SqlCommand(_request, _connection);

        //    _command.Parameters.Add(new SqlParameter("@Name", Name));
        //    _command.Parameters.Add(new SqlParameter("@Genres", Genres));
        //    _command.Parameters.Add(new SqlParameter("@Saisons", Saisons));
        //    _command.Parameters.Add(new SqlParameter("@Episodes", Episodes));
        //    _command.Parameters.Add(new SqlParameter("@Description", Description));
        //    _command.Parameters.Add(new SqlParameter("@ReleaseDate", ReleaseDate));

        //    _connection.Open();
        //    int nbLignes = -_command.ExecuteNonQuery();

        //    _command.Dispose();
        //    _connection.Close();

        //    return nbLignes > 0;

        //}

        //public virtual bool Delete()
        //{
                       
        //    _connection = Connection.New;

        //           _request = "DELETE Series WHERE id=@ID";

        //    _command = new SqlCommand(_request, _connection);

        //    // Ajout des paramètres de la commande
        //    _command.Parameters.Add(new SqlParameter("@ID", Id));

        //    // Execution de la commande
        //    _connection.Open();
        //    int nbLignes = _command.ExecuteNonQuery();

        //    // Libération de l'objet command
        //    _command.Dispose();
        //    _connection.Close();

        //    return nbLignes > 0;
        //}
        #endregion

        public override string ToString()
        {
            return $"ID : {Id}\tNom : {Name} \nGenres : {Genres}\n Saisons : {Saisons}\nEpisodes : {Episodes} Description : {Description}\nReleaseDate:{ReleaseDate}";
        }

    }
}
