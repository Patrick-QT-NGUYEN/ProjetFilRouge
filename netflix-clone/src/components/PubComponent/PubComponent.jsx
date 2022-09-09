import React from 'react';
import './PubComponent.css';
import 'bootstrap/dist/css/bootstrap.min.css';

const PubComponent = () => {
    return (
        <div className='PubComponent jumbotron'>
            
            <div class="jumbotron__content">
                <div class="jumbobotron__text">
                    <h1><b>Regardez Netflix sur votre TV.</b></h1>
                    <p>Regardez Netflix sur votre Smart TV, PlayStation, Xbox, Chromecast, Apple TV, lecteurs Blu-ray et bien plus.
                    </p>
                </div>
                    <img src="./img/Netflix_tv.png"
                        alt='Netflix TV' className='imagePub' />

            </div>
            
            <div class="jumbotron__content">
                <div>
                    <img src="./img/Netflix_mobile.jpg"
                        alt='Netflix mobile' className='imagePub' />
                </div>
                <div class="jumbobotron__text">
                    <h1><b>Téléchargez vos séries préférées pour les regarder hors connexion.</b></h1>
                    <p>Enregistrez vos programmes préférés et ayez toujours quelque chose à regarder.</p>
                </div>
            </div>
            
            <div class="jumbotron__content">
                <div class="jumbobotron__text">
                    <h1><b>Où que vous soyez.</b></h1>
                    <p>Regardez des films et séries TV en accès illimité sur votre TV, smartphone, tablette et ordinateur, tout compris.</p>
                </div>
                <div>
                    <img src="./img/Netflix_device-pile.png"
                        alt='Netflix TV' className='imagePub' />
                </div>
            </div>
            
            <div class="jumbotron__content">
                <div>
                    <img src="./img/Netflix_Jeunesse.png"
                        alt='Netflix TV' className='imagePub' />
                </div>
                <div class="jumbobotron__text">
                    <h1><b>Créez des profils pour les enfants.</b></h1>
                    <p>Les enfants découvrent de nouvelles aventures et retrouvent leurs personnages préférés dans un espace bien à eux, déjà inclus dans votre abonnement.
                    </p>
                </div>
            </div>
            
            <br />
        </div>
    );
};

export default PubComponent;