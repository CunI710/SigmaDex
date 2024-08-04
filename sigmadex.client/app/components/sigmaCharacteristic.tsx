

interface Props {
    characteristics: Characteristic[];
}


export const SigmaCharacteristics = ({ characteristics }: Props) => {
    return (
        <div className="bg-sky-300 rounded-2xl text-2xl m-3 p-5 text-center grid grid-cols-2 gap-y-7">
            {characteristics.map((char: Characteristic) => (
                <div
                    key={char.name}
                    className="grid justify-center"
                >
                    <p
                        className='text-white'
                    >
                        {char.name}
                    </p>
                    <p>
                        {char.description}
                    </p>
                </div>
            ))}
        </div>
    );
};