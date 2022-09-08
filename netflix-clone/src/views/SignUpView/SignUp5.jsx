import React,{useEffect} from 'react';
import './SignUp5.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
    Link
} from 'react-router-dom';

const SignUp5 = () => {
    useEffect(() => {
        document.title = "Sign Up - Step 4"
      }, [])
    return (
        <div className="card configuration">
        <div className="card-body">
            <h5 className="card-title">ETAPE 4 SUR 4</h5>
            <h2 className="card-title"> Configurez votre code cadeau</h2>
            <div class="input-group mb-3">
                <input type="text" class="form-control" placeholder="Code ou PIN de la carte cadeau" aria-label="Recipient's username" aria-describedby="button-addon2" />
                <Link className='btn btn-danger' to ="/SignUp8">Valider</Link>
            </div>
        </div>
    </div>
    );
};

export default SignUp5;

