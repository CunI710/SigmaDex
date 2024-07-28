'use client';
import { SigmaExamples } from '@/app/components/sigmaExample';
import { Image } from 'antd';
import axios from 'axios';
import { useState,useEffect } from 'react';

export default function DynamicPage({ params }: { params: { id: number } }) {
  
  const id = params.id
  const [sigma,setSigma]= useState<SigmaExample>();

  useEffect(()=>{
    axios.get(`http://localhost:5016/api/sigma/${id}`)
        .then(response=>{
            setSigma(response.data);
        })
        .catch(error =>{
            console.log(error);
        })
  },[]);


  return (
    <div className='p-20'>
      <div className='bg-white rounded-2xl'>
        <h1 className='text-center text-3xl'>{sigma?.name}</h1>
        <div className='flex'>

        <div className='w-1/3'>
          <Image
            src="https://avatars.mds.yandex.net/get-shedevrum/11465050/original_b07a57a5bed111ee978dd659965eed18/orig"
          />
        </div>
        <div className='2/3'>
          <p>hello</p>
          <p>Параметр: {id}</p>
        </div>
        </div>
      </div>
    </div>
  );
};
