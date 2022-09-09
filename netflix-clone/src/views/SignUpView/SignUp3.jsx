import React, { useEffect } from 'react';
import './SignUp3.css';
import 'bootstrap/dist/css/bootstrap.min.css';

const SignUp3 = () => {
    useEffect(() => {
        document.title = "Sign Up - Step 3"
    }, [])
    return (
        <div>
            <div className="card configuration">
                <div className="card-body">
                    <h5 className="card-title">ETAPE 3 SUR 4</h5>
                    <h2 className="card-title"> Créez un mot de passe pour démarrer votre abonnement</h2>
                    <p className="card-text">Plus que quelques étapes et c'est fini ! <br /> Plus rien à remplir.</p>
                    <input className='config' placeholder='E-mail' type="email"></input> <br />
                    <input className='config' placeholder='Ajouter un mot de passe' type="password"></input>
                    <br />
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="" id="flexCheckChecked" />
                        <label class="form-check-label" for="flexCheckChecked">
                            Oui, envoyez-moi les offres spéciales de Netflix par email. <br />
                        </label>

                    </div>
                    <a href="/SignUp4" className="btn btn-danger form-control">Suivant</a>
                </div>
            </div>
        </div>
    );
};
export default SignUp3;

