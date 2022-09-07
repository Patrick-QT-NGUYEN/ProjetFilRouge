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
    internal class Episodes
    {
        //parametre Episode
        //private int id;
        private int episodesId;
        private string nameEpisode;
        private int nbEpisodes;
        //private string descriptionEpisode;
        private string lien;

        //Parametre Saisons
        private int saisonId;
        private string saisonImg;
        private string saisonLien;
        private DateTime saisonAnnees;

        // parametre SQL
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Episodes()
        {

        }

        public Episodes(int episodesId, string nameEpisode, string lien, int nbEpisodes, int saisonId, string saisonsImg, string saisonLien, DateTime saisonAnnees)
        {
            // this.Id = id;
            this.EpisodesId = episodesId;
            this.NameEpisode = nameEpisode;
            //this.DescriptionEpisode = descriptionEpisode;
            Lien = lien;
            this.nbEpisodes = nbEpisodes;
            this.saisonId = saisonId;
            this.saisonImg = saisonLien;
            this.saisonLien = saisonLien;
            this.saisonAnnees = saisonAnnees;

        }

        //episode
        //public int Id { get => id; set => id = value; }
        public int EpisodesId { get => episodesId; set => episodesId = value; }
        public string NameEpisode { get => nameEpisode; set => nameEpisode = value; }
        // public string DescriptionEpisode { get => descriptionEpisode; set => descriptionEpisode = value; }
        public string Lien { get => Lien; set => Lien = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        //saison
        public int SaisonId { get => saisonId; set => saisonId = value; }
        public string SaisonImg { get => saisonImg; set => saisonImg = value; }
        public string SaisonLien { get => saisonLien; set => saisonLien = value; }
        public DateTime SaisonAnnees { get => saisonAnnees; set => saisonAnnees = value; }



        public (bool, Episodes) Get(int id)
        {
            //Episodes episodes = new Episodes();
            Episodes episodes = null;
            bool found = false;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT e.EpisodesId, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
                "FROM EPISODES AS e" +
                "WHERE e.id = @Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", id));

            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                episodes = new Episodes()
                {
                    episodesId = _reader.GetInt32(0),
                    nameEpisode = _reader.GetString(1),
                    nbEpisodes = _reader.GetInt32(2),
                    Lien = _reader.GetString(3),
                    saisonId = _reader.GetInt32(4),
                    saisonImg = _reader.GetString(5),
                    saisonLien = _reader.GetString(6),
                    saisonAnnees = (DateTime)_reader.GetDateTime(7),
                };
                found = true;
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection à la BDD
            _connection.Close();

            // Retour de la liste de contact
            return (found, episodes);


        }


        public static List<Episodes> GetAll()
        {
            List<Episodes> episodes = new List<Episodes>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT e.EpisodesId, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
                "FROM EPISODES AS e" +
                "WHERE e.id = @Id";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Episodes episode = new Episodes()
                {
                    episodesId = reader.GetInt32(0),
                    nameEpisode = reader.GetString(1),
                    nbEpisodes = reader.GetInt32(2),
                    Lien = reader.GetString(3),

                    saisonId = reader.GetInt32(4),
                    saisonImg = reader.GetString(5),
                    saisonLien = reader.GetString(6),
                    saisonAnnees = (DateTime)reader.GetDateTime(7),


                };
                episodes.Add(episode);
            }
            reader.Close();

            command.Dispose();

            connection.Close();

            return episodes;
        }



        public virtual int Add()
        {
            // Création d'un instance de connection
            _connection = Connection.New;
            // Prépartion de la commande
            _request = "INSERT INTO Episodes (EpisodesId, NameEpisodes, NbEpisodes, Lien, SaisonId, SaisonImg, SaisonLien, SaisonAnnees) OUTPUT INSERTED.ID VALUES (@EpisodesId, @NameEpisodes, @NbEpisodes, @Lien, @SaisonId, @SaisonImg, @SaisonLien, @SaisonAnnees)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            //Episode
            _command.Parameters.Add(new SqlParameter("@EpisodesId", episodesId));
            _command.Parameters.Add(new SqlParameter("@NameEpisode", nameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", Lien));
            //Saison
            _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", SaisonAnnees));
            


            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            _command.Dispose();
            _connection.Close();

            return Id;

        }
        public virtual bool Update()
        {
            _connection = Connection.New;

            _request = "UPDATE Episodes SET EpisodesId = @EpisodesId , NameEpisode = @NameEpisode, NbEpisodes = @NbEpisodes, Lien = @Lien, SaisonId = @SaisonId, SaisonImg = @SaisonImg, SaisonLien = @SaisonLien, SaisonAnnees = @SaisonAnnees WHERE id=EpisodesId";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            //Episode
            _command.Parameters.Add(new SqlParameter("@EpisodesId", episodesId));
            _command.Parameters.Add(new SqlParameter("@NameEpisode", nameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", Lien));
            //Saison
            _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", SaisonAnnees));

            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }
        public virtual bool Delete()
        {

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE PERSON WHERE id=@EpisodesId";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@EpisodesId", EpisodesId));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public override string ToString()
        {
            return $"{episodesId}\tNameEpisode :{NameEpisode}\tNbEpisodes : {nbEpisodes}\tLien : {Lien}SaisonId : {SaisonId}\tSaisonImg : {SaisonImg}\tSaisonLien : {SaisonLien}\tSaisonAnnees : {SaisonAnnees}";
        }



















    }
}
