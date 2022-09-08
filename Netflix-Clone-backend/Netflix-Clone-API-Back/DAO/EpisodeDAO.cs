using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.Tools;

namespace Netflix_Clone_API_Back.DAO
{
    public class EpisodeDAO : BaseDAO<Episode>
    {
        public override int Create(Episode element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Episodes (NameEpisodes, NbEpisodes, Lien, saisonId, saisonImg, saisonLien, saisonAnnees) OUTPUT INSERTED.ID VALUES (@NameEpisodes, @NbEpisodes, @Lien, @saisonId, @saisonImg, @saisonLien, @saisonAnnees)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@NameEpisodes", element.NameEpisodes));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            _command.Parameters.Add(new SqlParameter("@saisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@saisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@saisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@saisonAnnees", element.SaisonAnnees));

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

        public override bool Delete(Episode element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Episode) Find(int index)
        {
            Episode episode = null;
            bool found = false;

            _connection = Connection.New;

            _request = "SELECT * " +
                "FROM Episodes AS Ep " +
                "WHERE Ep.Id = @Id";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Id", index));

            _connection.Open();

            _reader = _command.ExecuteReader();

            if(_reader.Read())
            {
                episode = new Episode()
                {
                    Id = _reader.GetInt32(0),
                    NameEpisodes = _reader.GetString(1),
                    NbEpisodes = _reader.GetInt32(2),
                    Lien = _reader.GetString(3),
                    SaisonId = _reader.GetInt32(4),
                    SaisonImg = _reader.GetString(5),
                    SaisonLien = _reader.GetString(6),
                    SaisonAnnees = (DateTime)_reader[7]
                };
                found = true;
            }
            _reader.Close();

            _command.Dispose();

            _connection.Close();


            return (found, episode);
        }

        public override List<Episode> Find(Func<Episode, bool> criteria)
        {
            List<Episode> episodes = new List<Episode>();
            FindAll().ForEach(e =>
            {
                if (criteria(e))
                {
                    episodes.Add(e);
                }
            });
            return episodes;
        }

        public override List<Episode> FindAll()
        {
            List<Episode> episodes = new ();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT Ep.id, Ep.NameEpisodes, Ep.NbEpisodes, Ep.Lien, Ep.saisonId, Ep.saisonImg, Ep.saisonLien, Ep.saisonAnnees " +
                 "FROM Episodes AS Ep";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Episode ep = new Episode()
                {
                    Id = reader.GetInt32(0),
                    NameEpisodes = reader.GetString(1),
                    NbEpisodes = reader.GetInt32(2),
                    Lien = reader.GetString(3),
                    SaisonId = reader.GetInt32(4),
                    SaisonImg = reader.GetString(5),
                    SaisonLien = reader.GetString(6),
                    SaisonAnnees = (DateTime)reader[7],
                };
                episodes.Add(ep);
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return episodes;
        }

        public override bool Update(Episode element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE Episodes SET NameEpisodes = @NameEpisodes, NbEpisodes = @NbEpisodes, Lien = @Lien, saisonId = @saisonId, saisonImg = @saisonImg, saisonLien = @saisonLien, saisonAnnees = @saisonAnnees WHERE id=@Id";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@NameEpisodes", element.NameEpisodes));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            _command.Parameters.Add(new SqlParameter("@saisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@saisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@saisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@saisonAnnees", element.SaisonAnnees));
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));

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
