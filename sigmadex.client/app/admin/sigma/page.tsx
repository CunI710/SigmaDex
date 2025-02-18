"use client";

import { useEffect, useState } from "react";
import { DeleteOutlined, EditOutlined, PlusCircleOutlined } from "@ant-design/icons";
import Link from "antd";
import axios from "axios";

export default function AdminSigmaPage() {


    const [sigmas, setSigmas] = useState<Sigma[]>([]);
    const [selectedSigma, setSelectedSigma] = useState<Sigma>();
    const [addWIsOpen, setAddWIsOpen] = useState(false);
    const [viewWIsOpen, setViewWIsOpen] = useState(false);
    const [editWIsOpen, setEditWIsOpen] = useState(false);
    const [deleteWIsOpen, setDeleteWIsOpen] = useState(false);

    useEffect(() => {
        axios.get("http://localhost:5016/api/sigma")
            .then(response => {
                setSigmas(response.data);
            })
            .catch(error => {
                console.log(error);
            })

        // axios.get("http://localhost:5016/api/sigmatype/example")
        //     .then(response => {
        //         setSigmas(response.data);
        //     })
        //     .catch(error => {
        //         console.log(error);
        //     })
    }, []);


    return (
        <div>
            {/* <button
                onClick={() => setIsOpen(true)}
                className="px-4 py-2 bg-blue-500 text-white rounded-lg"
            >
                Открыть модальное окно
            </button> */}

            {/* Модальное окно */}
            {addWIsOpen && (
                <div className="text-xl fixed inset-0 flex items-center justify-center bg-black bg-opacity-50">
                    <div className="bg-white p-6 rounded-lg shadow-lg w-96">
                        <h2 className="text-3xl font-bold mb-4">Модальное окно</h2>
                        <p className="mb-4">Это контент модального окна.</p>
                        <div className="p-2 border-b border-gray-800">
                            <input className="w-full" type="text" placeholder="Name" />
                        </div>
                        <div className="p-2 border-b border-gray-800">
                            <input className="w-full" type="text" placeholder="ImageUrl" />
                        </div>
                        <div className="text-right m-2">
                            <button
                                onClick={() => setAddWIsOpen(false)}
                                className="px-4 py-2 bg-red-500 text-white rounded-lg"
                            >
                                Закрыть
                            </button>
                        </div>
                    </div>
                </div>
            )}
            {viewWIsOpen && (
                <div className="text-xl fixed inset-0 flex items-center justify-center bg-black bg-opacity-50">
                    <div className="bg-white p-6 rounded-lg shadow-lg w-96">
                        <h2 className="text-3xl font-bold mb-4">Модальное окно</h2>
                        <p className="mb-4">Это контент модального окна.</p>
                        <div>
                            <p>id: {selectedSigma?.id}</p>
                            <p>name: {selectedSigma?.name}</p>
                            <p>description: {selectedSigma?.description}</p>
                            <p>imageUrl: {selectedSigma?.imageUrl}</p>
                            <p>averageHeight: {selectedSigma?.averageHeight}</p>
                            <p>averageWeight: {selectedSigma?.averageWeight}</p>
                            <p>testosterone: {selectedSigma?.testosterone}</p>
                            <p>evolutionLevel: {selectedSigma?.evolutionLevel}</p>
                            <p>nextStep: {selectedSigma?.nextStep}</p>
                            <p>prevStep: {selectedSigma?.prevStep}</p>
                            <p>types: {selectedSigma?.types.map(t => (<span>{t.name}, </span>))}</p>
                            <p>weaknesses: {selectedSigma?.weaknesses.map(w => (<span>{w.name}, </span>))}</p>
                            <p>allEvolution: {selectedSigma?.allEvolution.map(ae =>
                            (<button className="bg-blue-700 text-blue-400 p-2 rounded-xl" onClick={() => setSelectedSigma(sigmas.find(s => s.id == ae.id))} key={ae.id}>{ae.id}. {ae.name}</button>
                            ))}
                            </p>
                        </div>
                        <div className="text-right">
                            <button
                                onClick={() => setViewWIsOpen(false)}
                                className="px-4 py-2 bg-red-500 text-white rounded-lg"
                            >
                                Закрыть
                            </button>
                        </div>
                    </div>
                </div>
            )}
            <div className="bg-blue-600 py-8 px-24">
                <div className="grid grid-cols-2 text-2xl">
                    <div className="text-blue-100"><span>Sigma</span></div>
                    <div className="text-end text-blue-300">
                        <button onClick={() => setAddWIsOpen(true)}><PlusCircleOutlined /> <span>Добавить</span></button>
                    </div>
                </div>
            </div>
            <div className="p-12">
                <div className="bg-gradient-to-t from-green-50 to-blue-100 rounded-xl shadow-xl p-5">
                    <div>
                        <table className="w-full table grid-">
                            <thead className="text-2xl text-left">
                                <tr>
                                    <th className="p-5">Id</th>
                                    <th className="p-5">Name</th>
                                    <th className="p-5">Image</th>
                                    <th className="p-5">ImageUrl</th>
                                    <th className="p-5">Types</th>
                                </tr>
                            </thead>
                            <tbody className="text-xl">
                                {sigmas.map((sigma, index) => (
                                    <tr key={sigma.id} onClick={() => setSelectedSigma(sigmas.find(s => s.id == sigma.id))}>
                                        <td onClick={() => setViewWIsOpen(true)} className="p-5 w-16">{sigma.id}</td>
                                        <td onClick={() => setViewWIsOpen(true)} className="p-5">{sigma.name}</td>
                                        <td onClick={() => setViewWIsOpen(true)} className="p-5 w-32"><img src={sigma.imageUrl} height={40} width={40} /></td>
                                        <td onClick={() => setViewWIsOpen(true)} className="p-5">{sigma.imageUrl}</td>
                                        <td className="p-5">{
                                            sigma.types.map((type, index) => (
                                                <span key={type.id}>{type.name}, </span>
                                            ))}</td>
                                        <td className="p-5 text-yellow-200 w-24"><button onClick={() => setEditWIsOpen(true)} className="bg-yellow-700 p-2 rounded-xl"><EditOutlined /></button></td>
                                        <td className="p-5 text-red-200 w-24"><button onClick={() => setDeleteWIsOpen(true)} className="bg-red-700 p-2 rounded-xl"><DeleteOutlined /></button></td>
                                    </tr>
                                ))}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    )
}