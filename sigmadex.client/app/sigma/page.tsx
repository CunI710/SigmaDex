
import { useEffect, useState } from "react";
import { SigmaExamples } from "../components/sigmaExample";
import { getAllSigmaExamples } from "../services/sigma";
import axios from "axios";

    
export default function SigmadexPage(sigmaId:number) {

    const [sigmas,setSigmas]= useState<SigmaExample[]>([]);

    useEffect( ()=>{
        axios.get("http://localhost:5016/api/sigma/example")
        .then(response=>{
            setSigmas(response.data);
        })
        .catch(error =>{
            console.log(error);
        })
    },[]);

    return (
        <div>
            <SigmaExamples sigmaExaples={sigmas}/>
        </div>
    )
}