import React from "react";
import CancelIcon from '@mui/icons-material/Cancel';
import "./QuickViewHomeConnecter.scss"
import BannerHomeConnecter from '../BannerHomeConnecterComponent/BannerHomeConnecter';
import VideoHomeConnecter from '../VideoHomeConnecterComponent/VideoHomeConnecter';
import { LocalPlay } from "@mui/icons-material";

function QuickViewHomeConnecter({ bannerStyles, movie, popup, popupStatus }) {
    return (
      <div className={`quickView ${popupStatus && "open"}`}>
        <div className="quickView__banner" style={bannerStyles}>
          <div className="quickView__content">
            <h3 className="quickView__title">
              {movie?.title || movie?.name || movie?.original_title}
            </h3>
            <p>{movie?.overview}</p>
            {/* <p>{movie.id.LocalPlay()}</p> */}
            {/* <p>{movie?.VideoHomeConnecter()}</p> */}
            <p>{movie?.overview}</p>
            <p>{movie?.overview}</p>
            <p>{movie?.overview}</p>
            <p>{movie?.overview}</p>
            <p>{movie?.overview}</p>
          </div>
        </div>
        <button className="quickView__close" onClick={popup}>
          <CancelIcon fontSize="large" />
        </button>
      </div>
    )
  }
  
  export default QuickViewHomeConnecter;