"use client";

import { useEffect, useState } from "react";
import { SigmaExamples } from "../components/sigmaExamples";
import axios from "axios";


export default function SigmadexPage() {

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