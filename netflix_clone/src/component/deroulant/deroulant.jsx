import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import Accordion from 'react-bootstrap/Accordion';
import './deroulant.css';



const Deroulant = () => {
  return (
    <div class='menuderoulant'>
      <Accordion>
        <div className='Titre'>Foire aux questions</div>
        <Accordion.Item eventKey="0">
         <Accordion.Header>Netflix, qu'est-ce que c'est ?</Accordion.Header>
         <div class='Body'>
          <Accordion.Body>
            Netflix est un service de streaming qui propose une vaste sélection TV, films, animes, documentaires et autres programmes primés sur des milliers d'appareils connectés à Internet.<br />
            <br /> Regardez tout ce que vous voulez, quand vous voulez, sans publicité et à un tarif mensuel très attractif. Découvrez de nouveau films et séries TV chaque semaine, il y en a pour tous les goûts !
          </Accordion.Body>
          </div>
        </Accordion.Item>

        <Accordion.Item>
          <Accordion.Header>Combien coûte Netflix ?</Accordion.Header>
          <div class='Body'>
          <Accordion.Body>
            Regardez Netflix sur votre smartphone, tablette, Smart TV, ordinateur ou appareil de streaming, le tout pour un tarif mensuel fixe. Les forfaits vont de 8,99€ à 17,99€ par mois. Pas de contrat ni de frais supplémentaires.
          </Accordion.Body>
          </div>
        </Accordion.Item>

        <Accordion.Item eventKey="2">
          <Accordion.Header>Où puis-je regarder Netflix ?</Accordion.Header>
          <div class='Body'>
          <Accordion.Body>
            Netflix, c'est où vous voulez, quand vous voulez. Connectez-vous à votre compte pour regarder Netflix en ligne sur netflix.com depuis votre ordinateur ou tout appareil connecté à Internet avec l'application Netflix, comme les Smart TV, smartphones, tablettes, lecteurs de streaming et consoles de jeu.<br />
            Vous pouvez aussi télécharger vos séries préférées avec l'application iOS, Android ou Windows 10. Téléchargez des titres pour les regarder sur votre appareil mobile, même sans connexion Internet. Emportez Netflix partout avec vous.
          </Accordion.Body>
          </div>
        </Accordion.Item>

        <Accordion.Item eventKey="3">
          <Accordion.Header>Comment puis-je annuler mon forfait ?</Accordion.Header>
          <div class='Body'>
          <Accordion.Body>
            Netflix offre une grande souplesse. Pas de contrat compliqué. Sans engagement. Deux clics suffisent pour annuler votre compte en ligne. Pas de frais d'annulation : ouvrez ou fermez votre compte à tout moment.
          </Accordion.Body>
          </div>
        </Accordion.Item>

        <Accordion.Item eventKey="4">
          <Accordion.Header>Que puis-je regarder sur Netflix ?</Accordion.Header>
          <div class='Body'>
          <Accordion.Body>
            Netflix propose un vaste catalogue comprenant notamment des longs métrages, des documentaires, des séries TV, des animes et des programmes originaux Netflix primés. Regardez Netflix à volonté, quand vous le voulez.
          </Accordion.Body>
          </div>
        </Accordion.Item>
        
        <Accordion.Item eventKey="5">
          <Accordion.Header>Est-ce que Netflix est adpaté aux enfants ?</Accordion.Header>
          <div class='Body'>
          <Accordion.Body>
            Netflix Jeunesse est inclus dans votre abonnement et offre un meilleur contrôle aux parents, ainsi qu'un espace dédié aux enfants, avec des films et des séries destinés à toute la famille.

            Les profils Enfants comportent des fonctionnalités de contrôle parental avec code PIN permettant de modifier la catégorie d'âge des contenus que vos enfants peuvent regarder et de bloquer des titres spécifiques.
          </Accordion.Body>
          </div>
        </Accordion.Item>
      </Accordion>
    </div>
  );
}

export default Deroulant;