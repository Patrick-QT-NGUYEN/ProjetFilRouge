import React from 'react';
import "./Nav.scss"
import MenuIcon from "@material-ui/icons/Menu"
import SearchIcon from "@material-ui/icons/Search"
import GiftIcon from "@material-ui/icons/CardGiftcard"

import NotificationsIcon from "@material-ui/icons/Notifications"
import 'bootstrap/dist/css/bootstrap.min.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTrash, faPenToSquare, faCheck } from "@fortawesome/free-solid-svg-icons";

import { useState } from 'react';

function Nav() {
     /* debus du menu scroll */
    // menu de transition de nav
    const [navBlack, setNavBlack] = useState(false); //'navBlack' //is assigned a value but never used//navBlack = la bare noir dans Nav

    const [toggleMenu, setToggleMenu] = useState(false);

    const transitionNav = () => {
        window.scrollY > 100 ? setNavBlack(true) : setNavBlack(false);
    };

    useState(() => {
        document.addEventListener("scroll", transitionNav)
      })
    
      const handleClick = () => {
        console.log(toggleMenu)
        toggleMenu ? setToggleMenu(false) : setToggleMenu(true)
      }
    
   

    /* fin du menu scroll */

// console.log(navBlack)

    return (
        // <div className="nav show nav--black"> // creation du transition si vrai alors la bar sera transparente pour faire apparaitre le menu
        <div className={`nav ${navBlack || toggleMenu ? "nav--black" : "nav--transparent"} ${toggleMenu && "show"}`} > {/* // si la navblaack et vrais alors on lui donne la classe "nav--black" sinon je lui donne la class "nav--transparent" */}

            <button className="nav_burger" onClick={handleClick}>
                {/* <i class="bi bi-list"></i> */}
                <MenuIcon />
            </button>

            <img src="./images/netflix-logo-png-2584.png" className="nav_logo" alt="Netflix" width="20%" />
            <nav className="nav_links">

                <a href="/" className="nav__link">
                    Accueil
                </a>

                <a href="/" className="nav__link">
                    Series
                </a>

                <a href="/" className="nav__link">
                    Films
                </a>

            </nav>

            <div className="nav__actions">

                <a href="/" className="nav__action">
                    {/* <button > */}
                    <SearchIcon />
                    {/* </button> */}
                </a>

                <a href="/" className="nav__action">
                    {/* <button > */}
                    Direct
                    {/* </button> */}
                </a>
                <a href="/" className="nav__action">
                    {/* <button > */}
                    <GiftIcon />
                    {/* </button> */}
                </a>
                <a href="/" className="nav__action">
                    {/* <button> */}
                    <NotificationsIcon />
                    {/* </button> */}
                </a>
                <a href="/" className="nav__action">
                    <img src="./images/avatar03.png" alt="" width="20%" />
                </a>
            </div>
        </div>
    );
}

export default Nav;

