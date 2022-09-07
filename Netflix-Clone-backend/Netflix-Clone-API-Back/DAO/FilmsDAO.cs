using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Tools;
using Netflix_Clone_API_Back.Classes;
using System.IO;

namespace Netflix_Clone_API_Back.DAO
{
    public class FilmsDAO : BaseDAO<Films>
    {
        public override int Create(Films element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Films (Title, Description, Poster, Director, ReleaseDate, trailer, Genre) OUTPUT INSERTED.ID VALUES (@Title, @Description, @Poster, @Director, @ReleaseDate, @trailer, @Genre)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Title", element.Title));
            _command.Parameters.Add(new SqlParameter("@Description", element.Description));
            _command.Parameters.Add(new SqlParameter("@Poster", element.Poster));
            _command.Parameters.Add(new SqlParameter("@Director", element.Director));
            _command.Parameters.Add(new SqlParameter("@ReleaseDate", element.ReleaseDate));
            _command.Parameters.Add(new SqlParameter("@trailer", element.Trailer));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));

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
            _request = "DELETE Films WHERE id=@ID";


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

        public override bool Delete(Films element)
        {
            throw new NotImplementedException();
        }

        public override (bool,Films) Find(int index)
        {
            Films film = null;
            bool found = false;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT f.id, f.Title, f.Description, f.Poster, f.Director, f.ReleaseDate, f.trailer, f.genre " +
                 "FROM Films AS f " +
                 "WHERE f.id = @Id";

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
                film = new Films()
                {
                    Id = _reader.GetInt32(0),
                    Title = _reader.GetString(1),
                    Description = _reader.GetString(2),
                    Poster = _reader.GetString(3),
                    Director = _reader.GetString(4),
                    ReleaseDate = (DateTime)_reader[5],
                    Trailer = _reader.GetString(6),
                    Genre = _reader.GetString(7),
                };
                found = true;
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection à la BDD
            _connection.Close();

            // Retour de la liste de contact
            return (found, film);
        }

        public override List<Films> Find(Func<Films, bool> criteria)
        {
            List<Films> films = new List<Films>();
            FindAll().ForEach(f =>
            {
                if (criteria(f))
                {
                    films.Add(f);
                }
            });
            return films;
        }

        public override List<Films> FindAll()
        {
            //ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();  // Avec WPF
            List<Films> films = new List<Films>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT Films.id, Films.Title, Films.Description, Films.Poster, Films.Director, Films.ReleaseDate, Films.trailer, Films.genre " +
                 "FROM Films";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Films film = new Films()
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.GetString(2),
                    Poster = reader.GetString(3),
                    Director = reader.GetString(4),
                    ReleaseDate = (DateTime)reader[5],
                    Trailer = reader.GetString(6),
                    Genre = reader.GetString(7),
                };
                films.Add(film);
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return films;
        }

        public override bool Update(Films element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE Films SET Title = @Title, Description = @Description, Poster = @Poster, Director = @Director, ReleaseDate = @ReleaseDate, trailer = @trailer, Genre = @Genre WHERE id=@Id";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Title", element.Title));
            _command.Parameters.Add(new SqlParameter("@Description", element.Description));
            _command.Parameters.Add(new SqlParameter("@Poster", element.Poster));
            _command.Parameters.Add(new SqlParameter("@Director", element.Director));
            _command.Parameters.Add(new SqlParameter("@ReleaseDate", element.ReleaseDate));
            _command.Parameters.Add(new SqlParameter("@trailer", element.Trailer));
            _command.Parameters.Add(new SqlParameter("@Genre", element.Genre));
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
