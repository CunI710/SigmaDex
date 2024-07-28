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

export const getAllSigmaExamples = async ()=>{
    axios.get(`http://localhost:5016/api/sigma/example`)
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
}
export const getSigmaExample = async (id:number)=>{
    axios.get(`http://localhost:5016/api/sigma/example/${id}`)
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
}
export const getAllSigmas = async ()=>{
    axios.get(`http://localhost:5016/api/sigma`)
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
}
export const getSigma = async (id:number)=>{
    axios.get(`http://localhost:5016/api/sigma/${id}`)
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
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
export const deleteSigma = async (id:number)=>{
    axios.delete(`http://localhost:5016/api/sigma/${id}`)
    .then(response=>{
        return response.data;
    })
    .catch(error =>{
        console.log(error);
    })
}