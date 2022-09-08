import React from "react";
import "./NavMainHomeConnecter.scss";

function NavMainHomeConnecter(){
    return (
        <div className='nav'>
            <img src='./img/logo.png' className='nav__logo' />

            <button className="loginButton">S'identifier</button>

        </div>
    );
};

export default NavMainHomeConnecter;