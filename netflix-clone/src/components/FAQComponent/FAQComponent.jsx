import React from 'react';
import { Link } from 'react-router-dom';
import './FAQComponent.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Accordion from 'react-bootstrap/Accordion';


const FAQComponent = () => {
  return (
    <div className='faqFullPage'>
      <div className='faqPage'>
        <div className='faqTitre'>
          <h1>Foire aux questions</h1>
        </div>
        <Accordion>
          <div className='itemAccordion'>
            <Accordion.Item eventKey="0">
              <div className='headerAccordion'>
                <Accordion.Header>Netflix, qu'est-ce que c'est ?</Accordion.Header>
              </div>
              <div className='bodyAccordion'>
                <Accordion.Body>
                  Netflix est un service de streaming qui propose une vaste sélection TV, films, animes, documentaires et autres programmes primés sur des milliers d'appareils connectés à Internet.<br />
                  Regardez tout ce que vous voulez, quand vous voulez, sans publicité et à un tarif mensuel très attractif. Découvrez de nouveau films et séries TV chaque semaine, il y en a pour tous les goûts !
                </Accordion.Body>
              </div>
            </Accordion.Item>
          </div>
          <div className='itemAccordion'>
            <Accordion.Item eventKey="1">
              <div className='headerAccordion'>
                <Accordion.Header>Combien coûte Netflix ?</Accordion.Header>
              </div>
              <div className='bodyAccordion'>
                <Accordion.Body>
                  Regardez Netflix sur votre smartphone, tablette, Smart TV, ordinateur ou appareil de streaming, le tout pour un tarif mensuel fixe. Les forfaits vont de 8,99€ à 17,99€ par mois. Pas de contrat ni de frais supplémentaires.
                </Accordion.Body>
              </div>
            </Accordion.Item>
          </div>
          <div className='itemAccordion'>

          <Accordion.Item eventKey="2">
            <div className='headerAccordion'>
              <Accordion.Header>Où puis-je regarder Netflix ?</Accordion.Header>
            </div>
            <div className='bodyAccordion'>
              <Accordion.Body>
                Netflix, c'est où vous voulez, quand vous voulez. Connectez-vous à votre compte pour regarder Netflix en ligne sur netflix.com depuis votre ordinateur ou tout appareil connecté à Internet avec l'application Netflix, comme les Smart TV, smartphones, tablettes, lecteurs de streaming et consoles de jeu.<br />
                Vous pouvez aussi télécharger vos séries préférées avec l'application iOS, Android ou Windows 10. Téléchargez des titres pour les regarder sur votre appareil mobile, même sans connexion Internet. Emportez Netflix partout avec vous.
              </Accordion.Body>
            </div>
          </Accordion.Item>
          </div>
          <div className='itemAccordion'>
          <Accordion.Item eventKey="3">
            <div className='headerAccordion'>
              <Accordion.Header>Comment puis-je annuler mon forfait ?</Accordion.Header>
            </div>
            <div className='bodyAccordion'>
              <Accordion.Body>
                Netflix offre une grande souplesse. Pas de contrat compliqué. Sans engagement. Deux clics suffisent pour annuler votre compte en ligne. Pas de frais d'annulation : ouvrez ou fermez votre compte à tout moment.
              </Accordion.Body>
            </div>
          </Accordion.Item>
          </div>
          <div className='itemAccordion'>
          <Accordion.Item eventKey="4">
            <div className='headerAccordion'>
              <Accordion.Header>Que puis-je regarder sur Netflix ?</Accordion.Header>
            </div>
            <div className='bodyAccordion'>
              <Accordion.Body>
                Netflix propose un vaste catalogue comprenant notamment des longs métrages, des documentaires, des séries TV, des animes et des programmes originaux Netflix primés. Regardez Netflix à volonté, quand vous le voulez.
              </Accordion.Body>
            </div>
          </Accordion.Item>
          </div>
          <div className='itemAccordion'>
          <Accordion.Item eventKey="5">
            <Accordion.Header>Est-ce que Netflix est adapté aux enfants ?</Accordion.Header>

              <div className='bodyAccordion'>
                <Accordion.Body>
                  Netflix Jeunesse est inclus dans votre abonnement et offre un meilleur contrôle aux parents, ainsi qu'un espace dédié aux enfants, avec des films et des séries destinés à toute la famille.<br />


                Les profils Enfants comportent des fonctionnalités de contrôle parental avec code PIN permettant de modifier la catégorie d'âge des contenus que vos enfants peuvent regarder et de bloquer des titres spécifiques.
              </Accordion.Body>
            </div>
          </Accordion.Item>

          </div>
        </Accordion>

        <br />
        <h4>Prêt à regarder Netflix . Saisissez votre adresse e-mail pour vous abonner ou réactiver votre abonnement.</h4>
        <div className="loginScreen_input">
          <form>
            <input type="email" placeholder="Adresse email" className="btn_input_login" />
            <Link to="/SignUp1">
              <button className="btn_button_login">
                Commencez
              </button>
            </Link>
          </form>
        </div>
      </div>
      <br />
    </div >
  );
};

export default FAQComponent;