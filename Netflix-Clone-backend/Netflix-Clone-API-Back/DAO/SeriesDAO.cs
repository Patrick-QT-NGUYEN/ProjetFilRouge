using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.Tools;

namespace Netflix_Clone_API_Back.DAO
{
    public class SeriesDAO : BaseDAO<Series>
    {
        public override int Create(Series element)
        {
            _connection = Connection.New;

            _request = "INSERT INTO Series (Name, Genres, Saisons, Episodes, Description, Status, ReleaseDate) OUTPUT INSERTED.ID VALUES (@Name, @Genres, @Saisons, @Episodes, @Description, @Status, @ReleaseDate)";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Name", element.Name));
            _command.Parameters.Add(new SqlParameter("@Genres", element.Genres));
            _command.Parameters.Add(new SqlParameter("@Saisons", element.Saisons));
            _command.Parameters.Add(new SqlParameter("@Episodes", element.Episodes));
            _command.Parameters.Add(new SqlParameter("@Description", element.Description));
            _command.Parameters.Add(new SqlParameter("@Status", element.Status));
            _command.Parameters.Add(new SqlParameter("@ReleaseDate", element.ReleaseDate));

            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            _command.Dispose();
            _connection.Close();

            return Id;
        }

        public override bool Delete(int id)
        {
            _connection = Connection.New;

            _request = "DELETE Series WHERE id=@ID";

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

        public override bool Delete(Series element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Series) Find(int index)
        {
            Series serie = null;
            bool found = false;

            _connection = Connection.New;

            _request = "SELECT se.id, se.Name, se.Genres, se.Saisons, se.Episodes, se.Description, se.Status, se.ReleaseDate " +
                "FROM Series AS se " +
                "WHERE se.id = @Id";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Id", index));

            _connection.Open();

            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                serie = new Series()
                {

                    Id = _reader.GetInt32(0),
                    Name = _reader.GetString(1),
                    Genres = _reader.GetString(2),
                    Saisons = _reader.GetInt32(3),
                    Episodes = _reader.GetInt32(4),
                    Description = _reader.GetString(5),
                    Status = _reader.GetString(6),
                    ReleaseDate = (DateTime)_reader[7]
                };
                found = true;
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();

            return (found, serie);
        }

        public override List<Series> Find(Func<Series, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Series> FindAll()
        {
            List<Series> series = new List<Series>();

            SqlConnection connection = Connection.New;

            string request = "SELECT se.id, se.Name, se.Genres, se.Saisons, se.Episodes, se.Description, se.Status, se.ReleaseDate " +
                "FROM Series AS se";

            SqlCommand command = new SqlCommand(request, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Series serie = new Series()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Genres = reader.GetString(2),
                    Saisons = reader.GetInt32(3),
                    Episodes = reader.GetInt32(4),
                    Description = reader.GetString(5),
                    Status = reader.GetString(6),
                    ReleaseDate = reader.GetDateTime(7)
                };
                series.Add(serie);
            }

            reader.Close();
            command.Dispose();
            connection.Close();

            return series;
        }

        public override bool Update(Series element)
        {
            _connection = Connection.New;

            _request = "UPDATE Series SET Name = @Name, Genres = @Genres, Saisons = @Saisons, Episodes = @Episodes, Description = @Description, Status = @Status, ReleaseDate = @ReleaseDate WHERE id=@Id ";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Name", element.Name));
            _command.Parameters.Add(new SqlParameter("@Genres", element.Genres));
            _command.Parameters.Add(new SqlParameter("@Saisons", element.Saisons));
            _command.Parameters.Add(new SqlParameter("@Episodes", element.Episodes));
            _command.Parameters.Add(new SqlParameter("@Description", element.Description));
            _command.Parameters.Add(new SqlParameter("@Status", element.Status));
            _command.Parameters.Add(new SqlParameter("@ReleaseDate", element.ReleaseDate));
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));

            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }
    }
}
