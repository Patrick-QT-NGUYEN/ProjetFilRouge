import React, { useEffect } from 'react';
import './SignUp2.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
  Link
} from 'react-router-dom';

const SignUp2 = () => {
  useEffect(() => {
    document.title = "Sign Up - Step 2"
  }, [])
  return (
    <div>
      <div className="card configuration">
        <div className="card-body">
          <h5 className="card-title"> ETAPE 2 SUR 4 </h5>
          <h2 className="card-title"> Sélectionnez le forfait qui vous convient. Vous pouvez changer de forfait à tout moment</h2> <br />
          <div class="d-grid gap-2 col-6 mx-auto">
            <button class="btn btn-danger form-control" type="button">Essentiel 7,99€/mois </button>
            <button class="btn btn-danger form-control" type="button">Standard 11,99€/mois </button>
            <button class="btn btn-danger form-control" type="button">Premium 15,99€/mois </button>

          </div>
        </div>
        <Link className="btn btn-danger form-control" to="/SignUp3">Suivant</Link>
      </div>
    </div>

  );
};

export default SignUp2;



