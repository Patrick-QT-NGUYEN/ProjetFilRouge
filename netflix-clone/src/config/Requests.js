// https://api.themoviedb.org/3
// cle API ==> d266759b1962e1ff4bdd13ccb23c0303

//const API_KEY = "d266759b1962e1ff4bdd13ccb23c0303"; key autre
const API_KEY = "029df0ffb4e5d73a9377a6dca8bd2060";

const baseURL = "https://api.themoviedb.org/3";

const query ="&query=";
const search = " ";

const requests = {
  fetchTrending: `${baseURL}/trending/all/week?api_key=${API_KEY}&language=en-FR`,
  fetchNetflixOriginals: `${baseURL}/discover/tv?api_key=${API_KEY}&with_networks=213`,
  fetchTopRated: `${baseURL}/movie/top_rated?api_key=${API_KEY}&language=en-FR`,
  fetchActionMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_genres=28`,
  fetchComedyMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=35`,
  fetchHorrorMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=27`,
  fetchRomanceMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=10749`,
  fetchDocumentaries: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=99`,
  upcoming: `${baseURL}/movie/upcoming?api_key=${API_KEY}&with_generes=99`,
  MltiRecherche: `${baseURL}/search/multi?api_key=${API_KEY}&language=fr-FR&${query}${search}`,
  tvpopular: `${baseURL}/tv/popular?api_key=${API_KEY}&language=en-FR`,
  top_rated: `${baseURL}/tv/top_rated?api_key=${API_KEY}&language=en-FR`,
  //series: `${baseURL}/discover/tv?api_key=${API_KEY}&with_generes=99`,
  
}
//https://api.themoviedb.org/3/tv/popular?api_key=d266759b1962e1ff4bdd13ccb23c0303&language=en-FR

// url pour rechercher un film / series
// Mlti-Recherche :https://api.themoviedb.org/3/search/multi?api_key=d266759b1962e1ff4bdd13ccb23c0303&language=fr-FR&query=
//film :   https://api.themoviedb.org/3/search/movie?api_key=<<api_key>>&language=fr-FR&query=
//series : https://api.themoviedb.org/3/search/tv?api_key=<<api_key>>&language=fr-FR&query=

// url pour  film
//https://api.themoviedb.org/3/movie?api_key=d266759b1962e1ff4bdd13ccb23c0303&language=fr-FR 
// url pour series
//https://api.themoviedb.org/3/tv/76479?api_key=029df0ffb4e5d73a9377a6dca8bd2060&language=en-FR


//https://api.themoviedb.org/3/movie/550?api_key=029df0ffb4e5d73a9377a6dca8bd2060
//https://www.themoviedb.org/tv/60625-rick-and-morty
export default requests;