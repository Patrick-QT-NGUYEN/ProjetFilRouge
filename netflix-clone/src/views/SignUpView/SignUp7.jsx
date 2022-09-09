import React, { useEffect } from 'react';
import './SignUp7.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
    Link
} from 'react-router-dom';

const SignUp7 = () => {
    useEffect(() => {
        document.title = "Sign Up - Step 4"
    }, [])
    return (
        <div className="card configuration">
            <div className="card-body">
                <h5 className="card-title">ETAPE 4 SUR 4</h5>
                <h2 className="card-title"> Configurez votre carte bancaire.<img src="./img/SignUP_Page7_Payment.jpg" className="card-img-top" alt="..." /></h2>
                <input class="form-control" type="text" placeholder="Prénom" aria-label="default input example"></input>
                <input class="form-control" type="text" placeholder="Nom" aria-label="default input example"></input>
                <input class="form-control" type="text" placeholder="Numéro de carte" aria-label="default input example"></input>
                <input class="form-control" type="text" placeholder="Date d'expiration (MM/AA)" aria-label="default input example"></input>
                <input class="form-control" type="text" placeholder="Cryptogramme (CVV)" aria-label="default input example"></input>
                <Link className='btn btn-danger' to="/SignUp8">Valider</Link>

            </div>
        </div>
    );
};
export default SignUp7;





