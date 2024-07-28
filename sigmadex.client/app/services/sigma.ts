import axios from "axios";
import { List } from "postcss/lib/list";
export interface SigmaRequest{
    name:string;
    description:string;
    imageUrl:string;
    averageWeight:string;
    averageHeight:string;
    testosterone:number;
    evolutionLevel:number;
    typeIds:number[];
    weaknesseIds:number[];
    nextStepId:number;
    prevStepId:number;
}

export const createSigma = async (sigma:SigmaRequest)=>{
    axios.post(`http://localhost:5016/api/sigma`,{sigma})
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
}