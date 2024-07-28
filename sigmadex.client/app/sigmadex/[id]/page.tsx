'use client';
import { useRouter } from 'next/router';

export default function DynamicPage({params}:{params:{id:number}}) {
    const id = params.id;

  return (
    <div>
      <h1>Динамическая страница</h1>
      <p>Параметр: {id}</p>
    </div>
  );
};
