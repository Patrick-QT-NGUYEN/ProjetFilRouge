const __BASE_URL = 'http://localhost:5089/api/';

//Get
export const FindEpisodesApi = async () => {
    const response = await fetch(__BASE_URL + 'Episodes.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetEpisodesApi = async (id) => {
    const response = await fetch(__BASE_URL + 'Episodes.cs/' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

