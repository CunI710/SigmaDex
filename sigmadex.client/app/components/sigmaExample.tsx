import Card from "antd/es/card/Card";

interface Props {
    sigmaExaples: SigmaExample[];
}

export const SigmaExamples = ({ sigmaExaples }: Props) => {
    return (
        <div className="flex">
            {sigmaExaples.map((sigma: SigmaExample) => (
                <Card
                    key={sigma.id}
                    title={sigma.name}
                    className="w-40 m-2 hover:scale-105"
                    cover={<img className="h-40" alt="example" src="https://avatars.mds.yandex.net/get-shedevrum/11465050/original_b07a57a5bed111ee978dd659965eed18/orig"></img>}
                >
                    <div>
                        {sigma.types.map(type => (
                            <p>{type}</p>
                        ))}
                    </div>
                </Card>
            ))}
        </div>
    );
};