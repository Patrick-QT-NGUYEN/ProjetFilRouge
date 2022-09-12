const __BASE_URL = 'http://localhost:5089';

const bodyParser = require('body-parser');

const Apifilm = '/api/Films/';
const Apiepisode = '/api/episode/';

app
    .use(favicon(__dirname + '/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());



app.put('/api/Films/:id', (req, res) => {
    const id = parseInt(req, params.id);
    const filmsUpdated = { ...req.body, id: id }
    filmsList = filmsList.map(films => {
        return films.id == id ? filmsUpdated : films
    })
    const message = 'Le film ${filmsUpdated} a été modifié.';
    res.json(success(message, filmsUpdated))
    console.log(filmsUpdated);
})

app.post('/api/Films/:id', (req, res) => {
    const id = filmsList.lenght + 1;
    const filmsCreated = { ...req.body, ...{ id: id, created: new Date() } };
    filmsList.push(filmsCreated);
    const message = 'Le film ${filmsCreated.title} a bien été ajouté';
    res.json(success(message, filmsCreated));
})

//GetAll
export const Find = async () => {
    const response = await fetch(__BASE_URL + Apifilm)
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const Get = async (id) => {
    const response = await fetch(__BASE_URL + Apifilm + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}


export const postFilmApi = (async (Films) => {
    alert('Title : ${Films.Title}- Description : ${Films.Description} - Poster : ${Films.Poster} - Director : ${Films.Director} - ReleaseDate : ${Films.Releasedate} - Trailer : ${Films.trailer} - Genre : ${Films.Genre} ');
    const rawResponse = await fetch(__BASE_URL + Apifilm, {
        method: 'POST',
        headers: _HEADERS,
        body: JSON.stringify({
            Title: Films.Title,
            Descrition: Films.Descrition,
            Poster: Films.Poster,
            Director: Films.Director,
            ReleaseDate: Films.ReleaseDate,
            trailer: Films.trailer,
            Genre: Films.Genre
        })
    })
    const Content = await rawResponse.json();
    console.log("POST Response : " + Content);
    return Content;
});

export const updateFilmsApi = (async (Films) => {
    const rawResponse = await fetch(__BASE_URL + '/Films/' + Films.id, {
        method: 'PUT',
        headers: _HEADERS,
        body: JSON.stringify({
            Title: Films.Title,
            Descrition: Films.Descrition,
            Poster: Films.Poster,
            Director: Films.Director,
            ReleaseDate: new Date(Films.ReleaseDate),
            trailer: Films.trailer,
            Genre: Films.Genre
        })
    })
    const Content = await rawResponse.json();
    console.log("UPDATE Response : " + Content);
    return Content;

});

export const deleteFilmApi = (async (Id) => {
    const rawResponse = await fetch(__BASE_URL + '/Films/' + Id, {
        method: 'DELETE',
        headers: _HEADERS
    });
    const Content = await rawResponse.json();
    console.log("DELETE Response : " + Content);
    return Content;
});










////////
// episode api 
//'http://localhost:5089/api/Episode' \

app.put('/api/episode/:id', (req, res) => {
    const id = parseInt(req, params.id);
    const episodesUpdated = { ...req.body, id: id }
    EpisodesList = EpisodesList.map(episodes => {
        return episodes.id == id ? episodesUpdated : episodes
    })
    const message = 'Un épisode ${episodesUpdated} a été modifié.';
    res.json(success(message, episodesUpdated))
    console.log(episodesUpdated);
})

app.post('/api/episode/:id', (req, res) => {
    const id = EpisodesList.lenght + 1;
    const episodesCreated = { ...req.body, ...{ id: id, created: new Date() } };
    EpisodesList.push(episodesCreated);
    const message = 'Un épisode ${episodesCreated.nameEpisode} a bien été ajouté.';
    res.json(success(message, episodesCreated));
})

//GetAll
export const FindEpisodesApi = async () => {
    const response = await fetch(__BASE_URL + Apiepisode)
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetEpisodesApi = async (id) => {
    const response = await fetch(__BASE_URL + Apiepisode + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}



export const postepisodeApi = (async (Episodes) => {
    alert('NameEpisodes : ${Episodes.NameEpisodes}- NbEpisodes : ${Episodes.NbEpisodes} - Lien : ${Episodes.Lien} - saisonId : ${Episodes.saisonId} - saisonImg : ${Episodes.saisonImg} - saisonLien : ${Episodes.saisonLien} - saisonAnnees : ${Episodes.saisonAnnees} ');
    const rawResponse = await fetch(__BASE_URL + Apiepisode, {
        method: 'POST',
        headers: _HEADERS,
        body: JSON.stringify({
            NameEpisodes: Episodes.NameEpisodes,
            NbEpisodes: Episodes.NbEpisodes,
            Lien: Episodes.Lien,
            saisonId: Episodes.saisonId,
            saisonImg : Episodes.saisonImg,
            saisonLien : Episodes.saisonLien,
            saisonAnnees : Episodes.saisonAnnees
        })
    })
    const Content = await rawResponse.json();
    console.log("POST Response : " + Content);
    return Content;
});








export default ApiServices;
