import React, {useEffect} from 'react';
import './Signin.css';

const Signin = () => {
    useEffect(() => {
        document.title = "Sign In"
      }, [])
    return (
        <body className='Corps'>
            <div>
                <div className='place'>
                    <h2 className='Identification'>S'identifier</h2>
                    <input className='Texte' placeholder='E-mail ou numéro de téléphone' type="text" /><br />
                    <input className='Texte' placeholder='Mot de passe' type="password" /><br />
                    <button className='Bouton'>S'identifier</button><br />
                    <h3 className='nvx'>Nouveau sur Netflix ? <a className='Inscription' href="/SignUp1">Inscrivez-vous ! </a></h3>
                    <h3 className='nvx'>Cette page est protégée par Google reCAPTCHA. </h3>
                </div>
            </div>
        </body>
    );
};

export default Signin;