const __BASE_URL = 'http://localhost:5089/api/';

//Get
export const FindSeriesApi = async () => {
    const response = await fetch(__BASE_URL + 'Series.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetSeriesApi = async (id) => {
    const response = await fetch(__BASE_URL + 'Series.cs/' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

