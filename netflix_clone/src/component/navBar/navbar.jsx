//Faire une route pour visiter plusieurs pages dans la barre de recherche

//importer les nom appelées
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
} from 'react-router-dom';

//import du nom des pages 
import Deroulant from '../../component/deroulant/deroulant';
import Pageconnexion1 from '../../view/pageconnexion1/pageconnexion1'; 

//Toujours faire une constante qui retourne 
const NavBar = () => {
    return (
        //toujours mettre une div
        <div>
            {/* toujours appel browserRouter  */}
            <BrowserRouter>
                <Routes>

                    <Route path='/pageconnexion1' element={<Pageconnexion1 />} />
                    <Route path='/deroulant' element={<Deroulant />} />

                </Routes>
            </BrowserRouter>

            <div className="container">
                <Outlet />
            </div>
        </div>
    )
}

export default NavBar;