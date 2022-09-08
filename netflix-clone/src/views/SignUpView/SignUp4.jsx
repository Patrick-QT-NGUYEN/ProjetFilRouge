import React, { useEffect } from 'react';
import './SignUp4.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
    Link
} from 'react-router-dom';

const SignUp4 = () => {
    useEffect(() => {
        document.title = "Sign Up - Step 4"
    }, [])
    return (
        <div className="card configuration">
            <div className="card-body">
                <h5 className="card-title">ETAPE 4 SUR 4</h5>
                <h2 className="card-title"> Définissez votre mode de paiement.</h2>
                <p className="card-text"> Votre abonnement commence immédiatement après la configuration de votre paiement.</p>
                <p className='stylepolice'>Sans engagement. <br />Abonnement annulable en ligne à tout moment</p>
                <div class="d-grid gap-2 col-6 mx-auto butpackage">
                    <Link className='btn btn-danger' to="/SignUp7">Carte de crédit</Link>
                    <Link className='btn btn-danger' to="/SignUp6">Paypal</Link>
                    <Link className='btn btn-danger' to="/SignUp5">Code cadeau</Link>
                </div>
            </div>
        </div>
    );
};

export default SignUp4;
