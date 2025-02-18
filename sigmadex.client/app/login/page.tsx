"use client";

import { useEffect, useState } from "react";
import axios from "axios";
import Link from "next/link";


interface User {
    email: string;
    password: string;
}


export default function LoginPage() {

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    useEffect(() => {
        setError(" ");
    }, []);

    const handleClick = () => {
        if(email == "" || password == ""){
            setError("Введите email и пароль");
            return;
        }
        setError(" ");
        axios.post("http://localhost:5016/api/login/login",{email:email, password:password})
            .then(response => {
                localStorage.setItem("token", response.data);
                window.location.href = "/";
            })
            .catch(error => {
                setError(error);
                console.log(error);
            })
    };

    return (
        <div className="p-32 grid justify-center">
            <div className="bg-gradient-to-t from-green-50 to-blue-100 rounded-xl">
                <div className="p-10">
                <p className="my-5 text-2xl">Sign in</p>
                <p className="text-red-500">{error}</p>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)}/>
                    </div>
                    <div>
                        <input className="border-gray-700 border-b my-3 bg-inherit text-xl" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)}/>
                    </div>
                    <div>
                        <p> No account? <Link href={`/register`} className="text-blue-600">Create one! </Link></p>
                    </div>
                    <div className="grid justify-end mt-12">
                        <button onClick={handleClick} className="bg-blue-600 rounded-xl px-8 py-2 text-blue-200 text-xl hover:bg-blue-700 hover:text-blue-300">Log In</button>
                    </div>
                </div>
            </div>
        </div>
    )
}