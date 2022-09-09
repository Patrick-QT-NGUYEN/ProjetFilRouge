const __BASE_URL = 'http://localhost:3000/api/';

const bodyParser = require('body-parser');

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

//Get
export const Find = async () => {
    const response = await fetch(__BASE_URL + '/Films.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const Get = async () => {
    const response = await fetch(__BASE_URL + '/Films.cs' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

export default ApiServices;
