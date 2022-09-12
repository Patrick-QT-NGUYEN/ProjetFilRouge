import React from "react";
import "./VideoHomeConnecter.scss";
import { useParams } from "react-router-dom";


function VideoHomeConnecter() {
  
  let { id } = useParams();
  // Nz5CnNHnpO8
  // ?rel=0&showinfo=0&vq=720;autoplay=1
  //let id = "8lZki_Z35N0";
  console.log(id)
  return (
    <div className="video">
      <iframe
        src={`https://www.youtube.com/embed/${id}`}
        title="video"
        frameBorder="0"
        allowFullScreen
      ></iframe>
    </div>
  );
}

export default VideoHomeConnecter;
