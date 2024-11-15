'use client';
import { useEffect, useState } from "react";
import axios from "axios";
import { TypeExamples } from "../components/typeExamples";


export default function TypesPage() {

    const [types, setTypes]= useState<TypeExample[]>([]);

    useEffect( ()=>{
        axios.get("http://localhost:5016/api/sigmaType")
        .then(response=>{
            setTypes(response.data);
        })
        .catch(error =>{
            console.log(error);
        })
    },[]);

    return (
        <div>
            <TypeExamples types={types}/>
        </div>
    )   
}