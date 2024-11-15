import Link from "next/link";

interface Props {
    types: TypeExample[];
}

export const TypeExamples = ({ types }: Props) => {
    return (
        <div className="grid grid-cols-4 p-3 gap-x-10 gap-y-7">
            {types?.map((type: TypeExample) => (

                <Link href={`/type/${type.id}`} key={type.id}>
                        <div
                            className="rounded-2xl bg-red-400 p-2 text-xl text-white text-center"
                        >
                            {type.name}
                        </div>
                </Link>
            ))}
        </div>
    );
};