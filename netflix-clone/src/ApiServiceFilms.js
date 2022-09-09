const __BASE_URL = 'http://localhost:5089/api/';

//Get
export const FindFilmsApi = async () => {
    const response = await fetch(__BASE_URL + 'Films.cs')
        .then((res) =>
            res.json()
        );

    return response.data;
}

// Get/id
export const GetFilmsApi = async (id) => {
    const response = await fetch(__BASE_URL + 'Films.cs/' + id)
        .then((res) =>
            res.json()
        );
        console.log(response);
        return response.data;
}

