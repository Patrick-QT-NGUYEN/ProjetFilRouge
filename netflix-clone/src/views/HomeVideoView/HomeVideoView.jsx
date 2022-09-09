import React, { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './HomeVideoView.css';



import { 
    GetFilmsApi,
    FindFilmsApi
 } from '../../ApiServicesFilms';

const HomeVideoView = () => {
    
const [filmsList, setHomeVideoView] = useState(() => FetchData ());

function FetchData() {
    GetFilmsApi().then((data) => {

        console.log(data);
        setHomeVideoView(data)
    })
}


function AddFilms(Title, Description, Poster, Director, ReleaseDate, trailer, Genre) {
    alert('Title : ${Title} - Description : ${Description} - Poster : ${Poster} - Director : ${Director} - ReleaseDate : ${Releasedate} - Trailer : ${trailer} - Genre : ${Genre} ')
    postFilmApi({Title, Description, Poster, Director, ReleaseDate, trailer, Genre});

}

function UpdateFilms(Id, Title, Description, Poster, Director, ReleaseDate, trailer, Genre) {
    let response = confirm('Voulez-vous vraiment modifier les informations du film n°${id} ?')
    if (response)
    updateFilmsApi({Id, Title, Description, Poster, Director, ReleaseDate, trailer, Genre});
}

function DelecteFilm(id) {
    let response = confirm('Voulez-vous vraiment supprimer le film n°${id} ?')
    if (response)
    deleteFilmApi(id).then(() => FetchData());
}

return (
    <div>
        <h1>Hello World</h1>
        <div>Welcome to Home component Films viewer...!</div>
    </div>
);
  
    
};

export default HomeVideoView;