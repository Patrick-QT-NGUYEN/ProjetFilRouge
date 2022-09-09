const __BASE_URL = 'http://localhost:5089';
const _HEADERS = {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
}

export const GetFilmsApi = async () => {
    const response = await fetch(__BASE_URL + "/Films.cs")
        .then((res) =>
            res.json()
        )
    return response.data
}

//Get
export const FindFilmsApi = async (id) => {
    const response = await fetch(__BASE_URL + '/Films.cs')
        .then((res) =>
            res.json()
        );
    return response.data;
}

export const postFilmApi = (async (Films) => {
    alert('Title : ${Films.Title}- Description : ${Films.Description} - Poster : ${Films.Poster} - Director : ${Films.Director} - ReleaseDate : ${Films.Releasedate} - Trailer : ${Films.trailer} - Genre : ${Films.Genre} ');
    const rawResponse = await fetch(__BASE_URL + '/Films.cs/', {
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
    const rawResponse = await fetch(__BASE_URL + '/Films.cs/' + Films.id, {
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
    const rawResponse = await fetch(__BASE_URL + '/Films.cs/' + Id, {
        method: 'DELETE',
        headers: _HEADERS
    });
    const Content = await rawResponse.json();
    console.log("DELETE Response : " + Content);
    return Content;
});



