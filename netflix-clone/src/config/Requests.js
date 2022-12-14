// https://api.themoviedb.org/3
// cle API ==> d266759b1962e1ff4bdd13ccb23c0303

//const API_KEY = "d266759b1962e1ff4bdd13ccb23c0303"; key dilan
const API_KEY = "029df0ffb4e5d73a9377a6dca8bd2060";

const baseURL = "https://api.themoviedb.org/3";

const requests = {
  fetchTrending: `${baseURL}/trending/all/week?api_key=${API_KEY}&language=en-FR`,
  fetchNetflixOriginals: `${baseURL}/discover/tv?api_key=${API_KEY}&with_networks=213`,
  fetchTopRated: `${baseURL}/movie/top_rated?api_key=${API_KEY}&language=en-FR`,
  fetchActionMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_genres=28`,
  fetchComedyMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=35`,
  fetchHorrorMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=27`,
  fetchRomanceMovies: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=10749`,
  fetchDocumentaries: `${baseURL}/discover/movie?api_key=${API_KEY}&with_generes=99`,
}
//https://api.themoviedb.org/3/movie/550?api_key=029df0ffb4e5d73a9377a6dca8bd2060
export default requests;