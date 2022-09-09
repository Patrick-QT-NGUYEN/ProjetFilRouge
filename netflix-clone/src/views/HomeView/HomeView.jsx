import React, { useEffect } from 'react';

import FAQComponent from '../../components/FAQComponent/FAQComponent';
import PubComponent from '../../components/PubComponent/PubComponent';
import FooterComponent from '../../components/FooterComponent/FooterComponent';
import {Link} from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';

import './HomeView.css';

const HomeView = () => {
    useEffect(() => {
        document.title = "Netflix clone"
    }, [])
    return (
        <div>
            
            <div className="loginScreen">
                <div className="loginScreen_body">
                    <div>
                        <h1>Films, séries TV et bien plus en illimité.</h1>
                        <h2>Où que vous soyez. Annulez à tout moment</h2>
                        <h3>Prêt à regarder Netflix ? Saisissez votre adresse e-mail pour vous abonner ou réactiver votre abonnement.</h3>
                        <div className="loginScreen_input">
                            <form>
                                <input type="email" placeholder="Adresse email" className="btn_input_login" />
                                <Link to="/SignUp1">
                                    <button className="btn_button_login">
                                        Commencez
                                    </button>
                                </Link>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <PubComponent />
            <FAQComponent />
            <FooterComponent />

        </div>
    );
};

export default HomeView;