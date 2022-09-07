using Netflix_Clone_API_Back.Tools;
using Netflix_Clone_API_Back.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Clone_API_Back.Classes
{
    internal class Saisons 
    {
        private int id;
        private int saisonId;
        private string img;
        private string lien;
        //private Episodes saisionEpisodes;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Saisons()
        {

        }

        public Saisons(int id, int saisonId, string img, string lien)
        {
            this.id = id;
            this.saisonId = saisonId;
            this.img = img;
            this.lien = lien;

        }

        public int Id { get => id; set => id = value; }

        public int SaisonId { get => saisonId; set => saisonId = value; }


        public string Img { get => img; set => img = value; }

        public string Lien { get => lien; set => lien = value; }

        public (bool, Saisons) Get(int id)
        {
            Saisons saison = null;
            bool found = false;

            _connection = Connection.New;

            _request = "SELECT s.id, s.SaisonId, s.SaisonName, s.Description, s.ReleaseDate, s.Img, s.Lien" +
                "FROM Saisons AS s " +
                "WHERE s.id = @Id";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Id", id));

            _connection.Open();

            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                saison = new Saisons()
                {
                    Id = _reader.GetInt32(0),
                    SaisonId = _reader.GetInt32(1),
                    Img = _reader.GetString(2),
                    Lien = _reader.GetString(3),
                };
                found = true;
            }

            _reader.Close();

            _command.Dispose();

            _connection.Close();

            return (found, saison);
        }



        public static List<Saisons> GetAll()
        {
            List<Saisons> saisons = new List<Saisons>();

            SqlConnection connection = Connection.New;

            string request = "SELECT s.id, s.SaisonId, s.SaisonName, s.Description, s.ReleaseDate, s.Img, s.Lien" +
                "FROM Saisons AS s " +
                "WHERE s.id = @Id";

            SqlCommand command = new SqlCommand(request, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Saisons saison = new Saisons()
                {
                    Id = reader.GetInt32(0),
                    SaisonId = reader.GetInt32(1),
                    Img = reader.GetString(2),
                    Lien = reader.GetString(3),
                };
                saisons.Add(saison);
            }
            reader.Close();
            command.Dispose();
            connection.Close();

            return saisons;
        }


        public virtual int Add()
        {

            _connection = Connection.New;

            _request = "INSERT INTO Saisons (SaisonId, Img, Lien) OUTPUT INSERTED.ID VALUES (@SaisonId, @Img, @Lien)";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
            _command.Parameters.Add(new SqlParameter("@Img", Img));
            _command.Parameters.Add(new SqlParameter("@Lien", Lien));

            _connection.Open();
            int id = (int)_command.ExecuteScalar();

            _command.Dispose();
            _connection.Close();

            return id;

        }


        public virtual bool Update()
        {
            _connection = Connection.New;

            _request = "UPDATE Saisons SET SaisonId = @SaisonId, Img = @Img, Lien = @Lien WHERE id=@SaisonsId";

            _command = new SqlCommand(_request, _connection);


            _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
            _command.Parameters.Add(new SqlParameter("@Img", Img));
            _command.Parameters.Add(new SqlParameter("@Lien", Lien));

            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;

        }


        public virtual bool Delete()
        {

            _connection = Connection.New;

            _request = "DELETE Saisons WHERE id =@ID";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@ID", Id));

            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            _command.Dispose();
            _connection.Close ();

            return nbLignes > 0;
        }

        public override string ToString()
        {
            return $"ID : {Id}\tSaisonId : {SaisonId}\n Img : {Img}\n Lien : {Lien} ";
        }

    }
}
