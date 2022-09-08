using Azure.Core;
using Microsoft.Data.SqlClient;
using Netflix_Clone_API_Back.Classes;
using Netflix_Clone_API_Back.Tools;
using System.Reflection.PortableExecutable;

namespace Netflix_Clone_API_Back.DAO
{
    public class EpisodesDAO : BaseDAO<Episodes>
    {
        public override int Create(Episodes element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;
            // Prépartion de la commande
            _request = "INSERT INTO Episodes (Id, NameEpisodes, NbEpisodes, Lien, SaisonId, SaisonImg, SaisonLien, SaisonAnnees) OUTPUT INSERTED.ID VALUES (@EpisodesId, @NameEpisodes, @NbEpisodes, @Lien, @SaisonId, @SaisonImg, @SaisonLien, @SaisonAnnees)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            //Episode
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));
            _command.Parameters.Add(new SqlParameter("@NameEpisode", element.NameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            //Saison
            _command.Parameters.Add(new SqlParameter("@SaisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", element.SaisonAnnees));



            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

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

        public override bool Delete(Episodes element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Episodes) Find(int index)
        {
            Episodes episodes = null;
            bool found = false;

            _connection = Connection.New;
            _request = "SELECT e.Id, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
                "FROM EPISODES AS e" +
                "WHERE e.id = @Id";

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
                    Id = _reader.GetInt32(0),
                    NameEpisode = _reader.GetString(1),
                    NbEpisodes = _reader.GetInt32(2),
                    Lien = _reader.GetString(3),
                    SaisonId = _reader.GetInt32(4),
                    SaisonImg = _reader.GetString(5),
                    SaisonLien = _reader.GetString(6),
                    SaisonAnnees = (DateTime)_reader.GetDateTime(7),
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
            List<Episodes> episodes = new List<Episodes>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT e.Id, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
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
                Episodes film = new Episodes()
                {
                    Id = reader.GetInt32(0),
                    NameEpisode = reader.GetString(1),
                    NbEpisodes = reader.GetInt32(2),
                    Lien = reader.GetString(3),

                    SaisonId = reader.GetInt32(4),
                    SaisonImg = reader.GetString(5),
                    SaisonLien = reader.GetString(6),
                    SaisonAnnees = (DateTime)reader.GetDateTime(7),
                };
                episodes.Add(film);
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

            _request = "UPDATE Episodes SET Id = @Id , NameEpisode = @NameEpisode, NbEpisodes = @NbEpisodes, Lien = @Lien, SaisonId = @SaisonId, SaisonImg = @SaisonImg, SaisonLien = @SaisonLien, SaisonAnnees = @SaisonAnnees WHERE id = Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            //Episode
            _command.Parameters.Add(new SqlParameter("@EpisodesId", element.Id));
            _command.Parameters.Add(new SqlParameter("@NameEpisode", element.NameEpisode));
            _command.Parameters.Add(new SqlParameter("@NbEpisodes", element.NbEpisodes));
            _command.Parameters.Add(new SqlParameter("@Lien", element.Lien));
            //Saison
            _command.Parameters.Add(new SqlParameter("@SaisonId", element.SaisonId));
            _command.Parameters.Add(new SqlParameter("@SaisonImg", element.SaisonImg));
            _command.Parameters.Add(new SqlParameter("@SaisonLien", element.SaisonLien));
            _command.Parameters.Add(new SqlParameter("@SaisonAnnees", element.SaisonAnnees));

            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

    }
}

#region personnes get add update delete
//public (bool, Episodes) Get(int id)
//{
//    //Episodes episodes = new Episodes();
//    Episodes episodes = null;
//    bool found = false;

//    // Création d'un instance de connection
//    _connection = Connection.New;

//    // Prépartion de la commande
//    _request = "SELECT e.EpisodesId, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
//        "FROM EPISODES AS e" +
//        "WHERE e.id = @Id";

//    // Préparation de la commande
//    _command = new SqlCommand(_request, _connection);

//    // Ajout des paramètres de la commande
//    _command.Parameters.Add(new SqlParameter("@Id", id));

//    // Ouverture de la connexion
//    _connection.Open();

//    // Execution de la commande
//    _reader = _command.ExecuteReader();

//    if (_reader.Read())
//    {
//        episodes = new Episodes()
//        {
//            episodesId = _reader.GetInt32(0),
//            nameEpisode = _reader.GetString(1),
//            nbEpisodes = _reader.GetInt32(2),
//            Lien = _reader.GetString(3),
//            saisonId = _reader.GetInt32(4),
//            saisonImg = _reader.GetString(5),
//            saisonLien = _reader.GetString(6),
//            saisonAnnees = (DateTime)_reader.GetDateTime(7),
//        };
//        found = true;
//    }
//    _reader.Close();

//    // Libération de l'objet command
//    _command.Dispose();

//    // Fermeture de la connection à la BDD
//    _connection.Close();

//    // Retour de la liste de contact
//    return (found, episodes);


//}


//public static List<Episodes> GetAll()
//{
//    List<Episodes> episodes = new List<Episodes>();

//    // Création d'un instance de connection
//    SqlConnection connection = Connection.New;

//    // Prépartion de la commande
//    string request = "SELECT e.EpisodesId, e.NameEpisode, e.NbEpisodes, e.Lien, e.SaisonId, e.SaisonImg, e.SaisonLien, e.SaisonAnnees" +
//        "FROM EPISODES AS e" +
//        "WHERE e.id = @Id";

//    // Préparation de la commande
//    SqlCommand command = new SqlCommand(request, connection);

//    // Ouverture de la connexion
//    connection.Open();

//    // Execution de la commande
//    SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        Episodes episode = new Episodes()
//        {
//            episodesId = reader.GetInt32(0),
//            nameEpisode = reader.GetString(1),
//            nbEpisodes = reader.GetInt32(2),
//            Lien = reader.GetString(3),

//            saisonId = reader.GetInt32(4),
//            saisonImg = reader.GetString(5),
//            saisonLien = reader.GetString(6),
//            saisonAnnees = (DateTime)reader.GetDateTime(7),


//        };
//        episodes.Add(episode);
//    }
//    reader.Close();

//    command.Dispose();

//    connection.Close();

//    return episodes;
//}



////public virtual int Add()
////{
////    // Création d'un instance de connection
////    _connection = Connection.New;
////    // Prépartion de la commande
////    _request = "INSERT INTO Episodes (EpisodesId, NameEpisodes, NbEpisodes, Lien, SaisonId, SaisonImg, SaisonLien, SaisonAnnees) OUTPUT INSERTED.ID VALUES (@EpisodesId, @NameEpisodes, @NbEpisodes, @Lien, @SaisonId, @SaisonImg, @SaisonLien, @SaisonAnnees)";

////    // Préparation de la commande
////    _command = new SqlCommand(_request, _connection);

////    // Ajout des paramètres de la commande
////    //Episode
////    _command.Parameters.Add(new SqlParameter("@EpisodesId", episodesId));
////    _command.Parameters.Add(new SqlParameter("@NameEpisode", nameEpisode));
////    _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
////    _command.Parameters.Add(new SqlParameter("@Lien", Lien));
////    //Saison
////    _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
////    _command.Parameters.Add(new SqlParameter("@SaisonImg", SaisonImg));
////    _command.Parameters.Add(new SqlParameter("@SaisonLien", SaisonLien));
////    _command.Parameters.Add(new SqlParameter("@SaisonAnnees", SaisonAnnees));



////    _connection.Open();
////    int Id = (int)_command.ExecuteScalar();

////    _command.Dispose();
////    _connection.Close();
////    return Id;
////}

//public virtual bool Update()
//{
//    _connection = Connection.New;

//    _request = "UPDATE Episodes SET EpisodesId = @EpisodesId , NameEpisode = @NameEpisode, NbEpisodes = @NbEpisodes, Lien = @Lien, SaisonId = @SaisonId, SaisonImg = @SaisonImg, SaisonLien = @SaisonLien, SaisonAnnees = @SaisonAnnees WHERE id=EpisodesId";

//    // Préparation de la commande
//    _command = new SqlCommand(_request, _connection);

//    // Ajout des paramètres de la commande
//    //Episode
//    _command.Parameters.Add(new SqlParameter("@EpisodesId", episodesId));
//    _command.Parameters.Add(new SqlParameter("@NameEpisode", nameEpisode));
//    _command.Parameters.Add(new SqlParameter("@NbEpisodes", NbEpisodes));
//    _command.Parameters.Add(new SqlParameter("@Lien", Lien));
//    //Saison
//    _command.Parameters.Add(new SqlParameter("@SaisonId", SaisonId));
//    _command.Parameters.Add(new SqlParameter("@SaisonImg", SaisonImg));
//    _command.Parameters.Add(new SqlParameter("@SaisonLien", SaisonLien));
//    _command.Parameters.Add(new SqlParameter("@SaisonAnnees", SaisonAnnees));

//    _connection.Open();
//    int nbLignes = _command.ExecuteNonQuery();

//    // Libération de l'objet command
//    _command.Dispose();
//    _connection.Close();

//    return nbLignes > 0;
//}
//public virtual bool Delete()
//{

//    // Création d'un instance de connection
//    _connection = Connection.New;

//    // Prépartion de la commande
//    _request = "DELETE PERSON WHERE id=@EpisodesId";


//    // Préparation de la commande
//    _command = new SqlCommand(_request, _connection);

//    // Ajout des paramètres de la commande
//    _command.Parameters.Add(new SqlParameter("@EpisodesId", EpisodesId));

//    // Execution de la commande
//    _connection.Open();
//    int nbLignes = _command.ExecuteNonQuery();

//    // Libération de l'objet command
//    _command.Dispose();
//    _connection.Close();

//    return nbLignes > 0;
//}
#endregion


