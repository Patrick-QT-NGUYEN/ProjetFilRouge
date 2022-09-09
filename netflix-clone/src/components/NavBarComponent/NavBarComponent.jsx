import React from 'react';
import './NavBarComponent.css';
import HomeConnecterComponent from '../../views/HomeConnecterView/HomeConnecterView';
 
import 'bootstrap/dist/css/bootstrap.min.css';
import {
    BrowserRouter,
    Routes,
    Route,
    Link
} from 'react-router-dom';
import HomeView from '../../views/HomeView/HomeView';
import HomeVideoView from '../../views/HomeVideoView/HomeVideoView';
import Signin from '../../views/SigninView/Signin';
import SignUp1 from '../../views/SignUpView/SignUp1';
import SignUp2 from '../../views/SignUpView/SignUp2';
import SignUp3 from '../../views/SignUpView/SignUp3';
import SignUp4 from '../../views/SignUpView/SignUp4';
import SignUp5 from '../../views/SignUpView/SignUp5';
import SignUp6 from '../../views/SignUpView/SignUp6';
import SignUp7 from '../../views/SignUpView/SignUp7';
import SignUp8 from '../../views/SignUpView/SignUp8';
import HomeConnecterView from '../../views/HomeConnecterView/HomeConnecterView'
import VideoPresentation from '../../views/VideoPresentation/VideoPresentation';


const NavBarComponent = () => {
    return (
        <div>
            <BrowserRouter>
                <div id="navbar">
                    <div className="loginScreen_logo">
                        <Link to="/">
                            <img src="./img/netflix_logo.png" alt="Logo Netflix" className="loginScreen_logo" />
                        </Link>
                    </div>
                    <div>
                        <Link to="/SignIn">

                            <button className='btn_button_login loginScreen_button'>

                                S'identifier
                            </button>
                        </Link>
                    </div>
                </div>
                <Routes>
                    <Route path="/" element={<HomeView />} />
                    <Route path="/HomeVideo" element={<HomeVideoView />} />
                    <Route path="/SignIn" element={<Signin />} />
                    <Route path="/SignUp1" element={<SignUp1 />} />
                    <Route path="/SignUp2" element={<SignUp2 />} />
                    <Route path="/SignUp3" element={<SignUp3 />} />
                    <Route path="/SignUp4" element={<SignUp4 />} />
                    <Route path="/SignUp5" element={<SignUp5 />} />
                    <Route path="/SignUp6" element={<SignUp6 />} />
                    <Route path="/SignUp7" element={<SignUp7 />} />
                    <Route path="/SignUp8" element={<SignUp8 />} />
                    {/* <Route path='../../views/HomeConnecterView/HomeConnecterView' element={<HomeConnecterView/>}/> */}
                    <Route path='../../views/VideoPresentation/VideoPresentation' element={<VideoPresentation/>}/>
                </Routes>
            </BrowserRouter>
        </div>
    );
};

export default NavBarComponent;


