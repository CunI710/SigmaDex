"use client";

import { useEffect, useState } from "react";
import axios from "axios";
import Link from "next/link";


export default function RegisterPage() {

    const [sigmas, setSigmas] = useState<SigmaExample[]>([]);
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [repeatPassword, setRepeatPassword] = useState("");
    const [error, setError] = useState("");

    useEffect(() => {
        setError(" ");
    }, []);

    const handleClick = () => {
        if(name == "" || email == "" || password == "" || repeatPassword == ""){
            setError("Заполните все поля");
            return;
        }
        if(password!=repeatPassword){
            setError("Пароли не совпадают");
        }
        setError(" ");
        console.log("asdsad");
        axios.post("http://localhost:5016/api/login/register",{name:name, email:email, password:password})
            .then(response => {
                console.log("asdsad");
                window.location.href = "/login";
            })
            .catch(error => {
                setError(error.response.data);
                console.log(error);
            })
    }

    return (
        <div className="p-20 grid justify-center">
            <div className="bg-gradient-to-t from-green-50 to-blue-100 rounded-xl">
                <div className="p-10">
                    <p className="my-5 text-2xl">Create account</p>
                    <p className="text-red-500">{error}</p>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)}/>
                    </div>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="User name" value={name} onChange={(e) => setName(e.target.value)}/>
                    </div>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)}/>
                    </div>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="Repeat Password" value={repeatPassword} onChange={(e) => setRepeatPassword(e.target.value)}/>
                    </div>
                    <div>
                        <p> Have account? <Link href={`/login`} className="text-blue-600">Log in! </Link></p>
                    </div>
                    <div className="grid justify-end mt-12">
                        <button onClick={handleClick} className="bg-blue-600 rounded-xl px-8 py-2 text-blue-200 text-xl hover:bg-blue-700 hover:text-blue-300">Create</button>
                    </div>
                </div>
            </div>
        </div>
    )
}