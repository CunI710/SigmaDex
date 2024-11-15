'use client';
import { SigmaCharacteristics } from '@/app/components/sigmaCharacteristic';
import { SigmaExamples } from '@/app/components/sigmaExamples';
import { TypeExamples } from '@/app/components/typeExamples';
import { Image } from 'antd';
import axios from 'axios';
import Link from 'next/link';
import { useState, useEffect } from 'react';

export default function TypePage({ params }: { params: { id: number } }) {

  const id = params.id
  const [type, setType] = useState<Type>();
  const [sigmas, setSigmas] = useState<SigmaExample[]>([]);

  useEffect(() => {
    axios.get(`http://localhost:5016/api/sigmatype/${id}`)
      .then(response => {
        setType(response.data);
      })
      .catch(error => {
        console.log(error);
      })
      setSigmas(type?.sigmas??[])
  }, []);


  return (
    <div className='p-20'>
      <div className='bg-white rounded-2xl p-5'>
        <div>
          <h1 className='text-center text-3xl'>{type?.name}</h1>
          <Link href={"/type"} className='flex justify-self-end'>Все типы</Link>
        </div>
        <div>
            <SigmaExamples sigmaExaples={sigmas}/>
        </div>
      </div>
    </div>
  );
};
