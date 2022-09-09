import React from 'react';
import './FooterComponent.css'

const FooterComponent = () => {
    return (
        <div className="footer">
            <div className="footer__content">
                <h3>Des Questions? Appelez le (+33) 0805-543-063</h3>
                <div className="footer__links">
                    <ul>
                        <li>FAQ</li>
                        <li>Relations investisseurs</li>
                        <li>Modes de lecture</li>
                        <li>Mentions légales</li>
                        <li>Informations légales</li>
                    </ul>
                    <ul>
                        <li>Centre d'aide</li>
                        <li>Recrutement</li>
                        <li>Conditions d'utilisations</li>
                        <li>Nous Contacter</li>
                        <li>Seulement sur Netflix</li>
                    </ul>
                    <ul className="footer__link3">
                        <li>Compte</li>
                        <li>Utiliser des cartes cadeaux</li>
                        <li>Confidentialité</li>
                        <li>Test de vitesse</li>
                    </ul>
                    <ul className="footer__link4">
                        <li>Presse</li>
                        <li>Acheter des cartes cadeaux</li>
                        <li>Préférences de cookies</li>
                        <li>Garantie légale</li>
                    </ul>
                </div>
            </div>
        </div>
    );
};

export default FooterComponent;