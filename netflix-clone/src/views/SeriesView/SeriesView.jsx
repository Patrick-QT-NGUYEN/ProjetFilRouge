import 'bootstrap/dist/css/bootstrap.min.css';
import React, { useEffect } from 'react';
import '../../views/HomeConnecterView/HomeConnecterView.scss'
import NavBarComponent from '../../components/NavBarComponent/NavBarComponent';
import BannerHomeConnecter from '../../components/HomeConnecterComponent/BannerHomeConnecterComponent/BannerHomeConnecter';
import FooterHomeConnecterComponent from '../../components/HomeConnecterComponent/FooterHomeConnecterComponent/FooterHomeConnecter';
import NavHomeConnecterComponent from '../../components/HomeConnecterComponent/NavHomeConnecterComponent/NavHomeConnecter';
import Row from '../../components/HomeConnecterComponent/RowHomeConnecterComponent/Row';
import VideoHomeConnecterComponent from '../../components/HomeConnecterComponent/VideoHomeConnecterComponent/VideoHomeConnecter';
import requests from '../../config/Requests';
import {
    BrowserRouter as Router,
    Switch,
    Routes,
    Route,
    Link,
    Redirect,
} from "react-router-dom"


const SeriesView= () => {
    useEffect(() => {
    }, [])
    return (
        <div className="series">

            <NavHomeConnecterComponent />
            <BannerHomeConnecter />

            {/* <VideoHomeConnecterComponent /> */}
            <Row title="Series Originaux Netflix" fetchUrl={requests.on_the_air} isPoster={true} />
            <Row title="Tendances actuelles" fetchUrl={requests.tvpopular} />
            <Row title="Les mieux notés" fetchUrl={requests.airing_today} isPoster={true} />
            
            <Row title="A venir" fetchUrl={requests.upcoming} />
            <Row title="Series popular" fetchUrl={requests.tvpopular} isPoster={true} />
            <Row title="les mieux notés" fetchUrl={requests.top_rated} />
            <FooterHomeConnecterComponent />
            {/* <Router>

            </Router> */}

        </div>
    );
}
export default SeriesView;