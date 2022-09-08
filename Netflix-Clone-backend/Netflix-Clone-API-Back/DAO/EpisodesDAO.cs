using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Tools;
using Netflix_Clone_API_Back.Classes;
using System.IO;
using System.ComponentModel;

namespace Netflix_Clone_API_Back.DAO
{
    public class EpisodesDAO : BaseDAO<Episodes>
    {
        private EpisodesDAO episodesDAO { get => new EpisodesDAO(); }

        public override int Create(Episodes element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Episodes (NameEpisode, NbEpisodes, Lien, SaisonId, SaisonImg, SaisonLien, SaisonAnnees) OUTPUT INSERTED.ID VALUES (@EpisodeID, @NameEpisode, @NbEpisodes, @Lien, @SaisonId, @SaisonImg, @SaisonLien, @SaisonAnnees)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

      
            _command.Parameters.Add(new SqlParameter("@NameEpisode", element.NameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            _command.Parameters.Add(new SqlParameter("@SaisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", element.SaisonAnnees));

            // Execution de la commande
            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return Id;
        }

        public override bool Delete(int id)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE Episodes WHERE id=@ID";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@ID", id));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public override bool Delete(Episodes element)
        {
            throw new NotImplementedException();
        }


        public override (bool, Episodes) Find(int index)
        {
           Episodes episodes = null;
            bool found = false;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT e.Id, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees " +
                 "FROM Episodes AS e " +
                 "WHERE e.id = @Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", index));

            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                episodes = new Episodes()
                {
                    EpisodesId = _reader.GetInt32(0),
                    NameEpisode = _reader.GetString(1),
                    NbEpisodes = _reader.GetInt32(2),
                    Lien = _reader.GetString(1),
                    SaisonId = _reader.GetInt32(4),
                    SaisonImg = _reader.GetString(5),
                    SaisonLien = _reader.GetString(6),
                    SaisonAnnees = (DateTime)_reader[5],
                   
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

        public override List<Episodes> Find(Func<Episodes, bool> criteria)
        {
            List<Episodes> episodes = new List<Episodes>();
            FindAll().ForEach(f =>
            {
                if (criteria(f))
                {
                    episodes.Add(f);
                }
            });
            return episodes;
        }

        public override List<Episodes> FindAll()
        {

            //ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();  // Avec WPF
            List<Films> films = new List<Films>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT Episodes.EpisodesId, Episodes.NameEpisode, Episodes.NbEpisodes, Episodes.Lien, Episodes.SaisonId, Episodes.SaisonImg, Episodes.SaisonLien, Episodes.SaisonAnnees " +
                 "FROM Episodes";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Episodes episodes = new Episodes()
                {
                    EpisodesId = _reader.GetInt32(0),
                    NameEpisode = _reader.GetString(1),
                    NbEpisodes = _reader.GetInt32(2),
                    Lien = _reader.GetString(1),
                    SaisonId = _reader.GetInt32(4),
                    SaisonImg = _reader.GetString(5),
                    SaisonLien = _reader.GetString(6),
                    SaisonAnnees = (DateTime)_reader[5],
                };
                episodes.Add(episodes);
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return episodes;
        }

        public override bool Update(Episodes element)
        {
             _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Episodes (NameEpisode, NbEpisodes, Lien, SaisonId, SaisonImg, SaisonLien, SaisonAnnees) OUTPUT INSERTED.ID VALUES (@EpisodeID, @NameEpisode, @NbEpisodes, @Lien, @SaisonId, @SaisonImg, @SaisonLien, @SaisonAnnees)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);


            _command.Parameters.Add(new SqlParameter("@NameEpisode", element.NameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            _command.Parameters.Add(new SqlParameter("@SaisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", element.SaisonAnnees));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }
    }
}
