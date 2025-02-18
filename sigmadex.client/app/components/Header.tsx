"use client";

import Link from "next/link";
import axios from 'axios';
import { Menu } from "antd";
import { useEffect, useState } from "react";


export default function CustomHeader() {

    const [token, setToken] = useState<string | null>(null);
    const [user, setUser] = useState<User>();

    const items = [
        { key: "home", label: <Link href={"/"}>Home</Link> },
        { key: "sigmadex", label: <Link href={"/sigmadex"}>Sigmadex</Link> },
        ...(token ? [
            (user?.roles.includes("Admin") ?
            { key: "admin", label: <Link href={"/admin"}>Admin page</Link>}:
            { key: "empty", label: <Link href={""} className="grid justify-end"></Link>}),
            { key: "name", label: <Link href={`/user/${user?.id}`} className="grid justify-end">{user?.name}</Link>, style: { marginLeft: "auto" }}
        ]
            : [
                { key: "login", label: <Link href={"/login"} className="grid justify-end">Log in</Link>, style: { marginLeft: "auto" } }
            ]
        ),
    ]

    useEffect(() => {
        // Проверяем токен при загрузке страницы
        const savedToken = localStorage.getItem("token");
        if (savedToken) {
            setToken(savedToken);
            axios.get(`http://localhost:5016/api/user/info`, {
                headers: {
                  Authorization: `Bearer ${savedToken}`, // Добавляем в заголовок
                }})
                .then(response => {
                    setUser(response.data)
                })
                .catch(error => {
                    console.log(error);
                    localStorage.removeItem("token");
                    setToken(null);
                })
        }
    }, []);

    return (
        <Menu
            theme="dark"
            mode="horizontal"
            items={items}
        >
        </Menu>
    );
}