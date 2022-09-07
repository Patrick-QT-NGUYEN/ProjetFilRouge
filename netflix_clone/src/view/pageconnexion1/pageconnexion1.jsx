import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './pageconnexion1.css';




const Pageconnexion1 = () => {
    return (
        <div>
            <img src="./images/logo2.png" alt="" />
            <h1> Etape 1 sur 3</h1>
            <h2>Complétez la configuration de votre compte.</h2>
            <h3>Netflix est personnalisé selon vos goûts. Créez un mot de passe pour regarder Netflix quand vous voulez, où vous voulez.</h3>
            
            
            {/* Bouton suivant */}
            <div class="d-grid gap-2 col-6 mx-auto">
                <button class="btn btn-danger" type="button">Suivant</button>
            </div>
        </div>
    );
};

export default Pageconnexion1;