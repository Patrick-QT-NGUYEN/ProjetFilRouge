const __BASE_URL = 'http://localhost:5089';

const bodyParser = require('body-parser');

app
    .use(favicon(__dirname + '/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());



app.put('/api/Episodes/:id', (req, res) => {
    const id = parseInt(req, params.id);
    const episodesUpdated = { ...req.body, id: id }
    EpisodesList = EpisodesList.map(episodes => {
        return episodes.id == id ? episodesUpdated : episodes
    })
    const message = 'Un épisode ${episodesUpdated} a été modifié.';
    res.json(success(message, episodesUpdated))
    console.log(episodesUpdated);
})

app.post('/api/Episodes/:id', (req, res) => {
    const id = EpisodesList.lenght + 1;
    const episodesCreated = { ...req.body, ...{ id: id, created: new Date() } };
    EpisodesList.push(episodesCreated);
    const message = 'Un épisode ${episodesCreated.nameEpisode} a bien été ajouté.';
    res.json(success(message, episodesCreated));
})

//Get
export const FindEpisodesApi = async () => {
    const response = await fetch(__BASE_URL + '/Episodes.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetEpisodesApi = async () => {
    const response = await fetch(__BASE_URL + '/Episodes.cs' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

export default ApiServicesEpisodes;
