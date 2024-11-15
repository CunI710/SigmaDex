'use client';
import { SigmaCharacteristics } from '@/app/components/sigmaCharacteristic';
import { SigmaExamples } from '@/app/components/sigmaExamples';
import { TypeExamples } from '@/app/components/typeExamples';
import { Image } from 'antd';
import axios from 'axios';
import { useState, useEffect } from 'react';

export default function DynamicPage({ params }: { params: { id: number } }) {

  const id = params.id
  const [sigma, setSigma] = useState<Sigma>();
  const [characteristics, setCharacteristics] = useState<Characteristic[]>([]);
  const [prevExample, setPrevExamle] = useState<SigmaExample>();
  const [sigmaExample, setSigmaExample] = useState<SigmaExample>();
  const [nextExample, setNextExample] = useState<SigmaExample>();

  const addSigmaToList = (exampleId: number, func: Function) => {
    axios.get(`http://localhost:5016/api/sigma/example/${exampleId}`)
      .then(response => {
        func(response.data)
      })
      .catch(error => {
        console.log(error);
      })
  }

  useEffect(() => {
    axios.get(`http://localhost:5016/api/sigma/${id}`)
      .then(response => {
        setSigma(response.data);
      })
      .catch(error => {
        console.log(error);
      })
    addSigmaToList(sigma?.prevStep ?? 0, setPrevExamle);
    addSigmaToList(id, setSigmaExample);
    addSigmaToList(sigma?.nextStep ?? 0, setNextExample);
  }, []);


  return (
    <div className='p-20'>
      <div className='bg-white rounded-2xl p-5'>
        <h1 className='text-center text-3xl'>{sigma?.name}</h1>
        <div className='flex p-5 gap-8'>

          <div className='w-1/3'>
            <Image
              className='rounded-2xl'
              src="https://avatars.mds.yandex.net/get-shedevrum/11465050/original_b07a57a5bed111ee978dd659965eed18/orig"
            />
          </div>
          <div className='w-2/3'>
            <div className='text-2xl m-3 p-5'>
              <p>{sigma?.description}</p>
            </div>
            <SigmaCharacteristics characteristics={[
              { name: "average weight", description: sigma?.averageWeight ?? "" },
              { name: "average height", description: sigma?.averageHeight ?? "" },
              { name: "testosterone", description: sigma?.testosterone.toString() ?? "" },
              { name: "evolution level", description: sigma?.evolutionLevel.toString() ?? "" },
            ]} />
            <div>
              <p className='text-2xl p-3'>Types</p>
              <TypeExamples types={sigma?.types ?? []} />
            </div>
            <div>
              <p className='text-2xl p-3'>Weaknesses</p>
              <TypeExamples types={sigma?.weaknesses ?? []} />
            </div>
          </div>
        </div>
        <div className='grid justify-center'>
          <SigmaExamples sigmaExaples={sigma?.allEvolution ?? []}/>
          <p>{sigmaExample?.imageUrl}</p>
        </div>
      </div>
    </div>
  );
};
