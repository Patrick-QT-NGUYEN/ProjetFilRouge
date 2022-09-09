const __BASE_URL = 'http://localhost:5089';

const bodyParser = require('body-parser');

app
    .use(favicon(__dirname + '/favicon.ico'))
    .use(morgan('dev'))
    .use(bodyParser.json());



app.put('/api/Series/:id', (req, res) => {
    const id = parseInt(req, params.id);
    const seriesUpdated = { ...req.body, id: id }
    SeriesList = SeriesList.map(series => {
        return series.id == id ? seriesUpdated : series
    })
    const message = 'La série ${seriesUpdated} a été modifiée.';
    res.json(success(message, seriesUpdated))
    console.log(seriesUpdated);
})

app.post('/api/Series/:id', (req, res) => {
    const id = SeriesList.lenght + 1;
    const seriesCreated = { ...req.body, ...{ id: id, created: new Date() } };
    SeriesList.push(seriesCreated);
    const message = 'La série ${seriesCreated.name} a bien été ajoutée';
    res.json(success(message, seriesCreated));
})

//Get
export const FindSeriesApi = async () => {
    const response = await fetch(__BASE_URL + '/Series.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetSeriesApi = async () => {
    const response = await fetch(__BASE_URL + '/Series.cs' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

export default ApiServicesSeries;
