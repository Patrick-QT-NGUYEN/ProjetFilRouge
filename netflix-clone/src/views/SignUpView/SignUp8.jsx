import React, { useEffect } from 'react';
import './SignUp8.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
    Link
} from 'react-router-dom';


const SignUp8 = () => {
    useEffect(() => {
        document.title = "Sign Up - Merci"
    }, [])
    return (
        <div className='configuration'>
            <img src="./img/SignUP_Page1_LOGO.jpg" alt="" />
            <h5 className="card-title"> Merci de vous être abonné à Netflix !</h5> <br />
            <p className="care-text"> Bonjour <strong>User !</strong><br />
                Vous pouvez commencer à regarder des films et des séries TV dès maitenant.
            </p> <br />
            <Link className='btn btn-danger form-control' to="/VideoPresentation">Commencer à regarder</Link>
        </div>
    );
};

export default SignUp8;

