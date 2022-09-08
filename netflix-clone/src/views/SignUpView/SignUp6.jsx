import React, { useEffect } from 'react';
import './SignUp6.css';
import 'bootstrap/dist/css/bootstrap.min.css';

const SignUp6 = () => {
    useEffect(() => {
        document.title = "Sign Up - Step 4"
    }, [])
    return (
        <div className="card configuration">
            <div className="card-body">
                <h5 className="card-title">ETAPE 4 SUR 4</h5>
                <h2 className="card-title"> Configurez votre paiement via Paypal.</h2>
                <p className="card-text">Pour terminer l'inscription, cliquez sur le bouton Continuer vers Paypal et identifiez-vous sur PayPal avec votre adresse e-mail et votre mot de passe. </p>
                <div class="input-group mb-3">
                    <a href="https://www.paypal.com/fr/webapps/mpp/home"><img src="./img/SignUP_Page6_LOGOPayPal.jpg" className="card-img-top" alt="" />Continuer vers PayPal </a>
                </div>
            </div>
        </div>
    );
};
export default SignUp6;





