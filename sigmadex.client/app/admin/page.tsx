"use client";

import Link from "next/link";

export default function AdminPage() {


    return (
        <div className="p-12">
            <div className="bg-gradient-to-t from-green-50 to-blue-100 rounded-xl shadow-xl p-5">
                <div>
                    <Link className="grid p-5 text-2xl" href={"/admin/sigma"}>Sigma</Link>
                </div>
            </div>
        </div>
    )
}