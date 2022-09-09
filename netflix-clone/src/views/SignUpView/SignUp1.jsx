import React, { useEffect } from 'react';
import './SignUp1.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
  Link
} from 'react-router-dom';

const SignUp1 = () => {
  useEffect(() => {
    document.title = "Sign Up - Step 1"
  }, [])
  return (
    <div className="card configuration">
      <img src="./img/SignUP_Page1_Screens.jpg" className="card-img-top" alt="..." />
      <div className="card-body">
        <h5 className="card-title">ETAPE 1 SUR 4</h5>
        <h2 className="card-title"> Complétez la configuration de votre compte </h2>
        <p className="card-text">Netflix est personnalisé selon vos goûts. <br /> Créez un mot de passe pour regarder Netflix quand vous voulez, où vous voulez.</p><br />
        <Link className='btn btn-danger form-control' to="/SignUp2">Suivant</Link>
      </div>
    </div>
  );
};

export default SignUp1;

