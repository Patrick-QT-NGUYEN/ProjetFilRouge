import React, { useState, useEffect } from 'react'; //pour utiliser axios
import axios from 'axios';
import "./BannerHomeConnecter.scss";
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import HelpOutlineIcon from '@mui/icons-material/HelpOutline';
import requests from '../../../config/Requests';
import QuickViewHomeConnecter from '../QuickViewHomeConnecterComponent/QuickViewHomeConnecter';
import { Link } from "react-router-dom";

function BannerHomeConnecter(bannerStyles) {
    const [movie, setMovie] = useState([]); //recherche des film et met dzns un tableau (aleatoire)
    const [popup, setPopup] = useState(false);

    function handlePopup() {
        popup ? setPopup(false) : setPopup(true);
        
    }

    useEffect(() => {
        async function fetchData() {
            const request = await axios.get(requests.fetchTrending);

            setMovie(
                request.data.results[
                Math.floor(Math.random() * request.data.results.length - 1) //c'est le chemin utiliser par movieDb
                ]
            );
        }
        fetchData();
    }, []);

    function truncate(string, n) {
        return string?.length > n ? string.substr(0, n - 1) + "..." : string;
    }


    const backgroundStyle = {
        backgroundImage: `url("https://image.tmdb.org/t/p/original/${movie.backdrop_path}")`,
        backgroundSize: "cover",
        bakcgroundPosition: "center center",
    };


    return (
        <header className='banner' style={backgroundStyle}>
            <div className='banner__content'>
                <h1 className='banner__title'>
                    {movie?.title || movie?.name || movie?.original_title}
                </h1>
                <p className='banner__description'>
                    {truncate(movie?.overview, 150)}
                </p>
                <div className='banner__buttons'>
                    <Link to={`/video/${movie.id}`}>
                        <button className='banner__button banner__button--play'>
                            <PlayArrowIcon /> Lecture
                        </button>
                    </Link>

                    <button className='banner__button' onClick={handlePopup}>
                        <HelpOutlineIcon /> Plus d'infos</button>
                </div>

            </div>
            <QuickViewHomeConnecter
                bannerStyles={bannerStyles}
                movie={movie}
                popupStatus={popup}
                popup={handlePopup}
            />
        </header>
    )
}

export default BannerHomeConnecter






