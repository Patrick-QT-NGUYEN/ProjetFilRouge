// import 'bootstrap/dist/css/bootstrap.min.css';
// import React, { useEffect } from 'react';

// //import NavBarComponent from './components/NavBarComponent/NavBarComponent';
// import BannerHomeConnecter from './components/HomeConnecterComponent/BannerHomeConnecterComponent';
// import FooterHomeConnecterComponent from './components/HomeConnecterComponent/FooterHomeConnecterComponent';
// import NavHomeConnecterComponent from './components/HomeConnecterComponent/NavHomeConnecterComponent';
// //import RowHomeConnecterComponent from './components/HomeConnecterComponent/RowHomeConnecterComponent';
// import VideoHomeConnecterComponent from './components/HomeConnecterComponent/VideoHomeConnecterComponent';
// import requests from '.config/Requests';




// const HomeConnecterComponent = () => {
//     useEffect(() => {
//         document.title = "Netflix super clone"
//     }, [])
//     return (
//         <div className="App">
// <Router>
// {/* <Switch> */}
// {/* <Route exact path="/"> */}

//       <NavHomeConnecterComponent />{/* Navbar */}

      
//       <BannerHomeConnecter />{/* Banner */}

//       {/* Row s*/}
//       <Row title="Programmes Originaux Netflix" fetchUrl={requests.fetchNetflixOriginals} isPoster={true}/>
//       <Row title="Tendances actuelles" fetchUrl={requests.fetchTrending}  />
//       <Row title="Les mieux notés" fetchUrl={requests.fetchTopRated } isPoster={true} />
//       <Row title="Films Comédies" fetchUrl={requests.fetchComedyMovies} />
//       <Row title="Films d'action" fetchUrl={requests.fetchHorrorMovies} />
//       {/* <Row title="Comédies" fetchUrl={requests.fetchComedyMovies} />
//       <Row title="Films d'horreur" fetchUrl={requests.fetchHorrorMovies} />
//       <Row title="Films romantique" fetchUrl={requests.fetchRomanceMovies} /> */}

//       {/* Vidéo*/}


//       {/* Quick view */}


      
//       <FooterHomeConnecterComponent />{/* Footer */}
//       {/*</Route>
//       <Route path="/video/:id" component={Video} />
//           {/*<Route path="*">
//             <Redirect to="/" />
//           </Route>*/}
//           {/* </Switch> */}
//       </Router>
//     </div>
//   );
// }
// export default HomeConnecterComponent;
