import { Tag } from "antd";
import Card from "antd/es/card/Card";
import Link from "next/link";

interface Props {
    sigmaExaples: SigmaExample[];
}

export const SigmaExamples = ({ sigmaExaples }: Props) => {
    return (
        <div className="grid grid-cols-5 p-10 gap-x-10 gap-y-7">
            {sigmaExaples.map((sigma: SigmaExample) => (

                <Link href={`/sigmadex/${sigma.id}`} key={sigma.id}>
                        <Card
                            hoverable
                            key={sigma.id}
                            title={sigma.name}
                            className="hover:scale-105 "
                            cover={<img className="h-40" alt="example" src="https://avatars.mds.yandex.net/get-shedevrum/11465050/original_b07a57a5bed111ee978dd659965eed18/orig"></img>}
                        >
                            <div className="grid grid-cols-2">
                                {sigma.types.map((type: string) => (
                                    <Tag
                                        key={type}
                                        color="red"
                                        className="p-1 text-center border-0 rounded-xl"
                                    >
                                        {type}
                                    </Tag>
                                ))}
                            </div>
                        </Card>
                </Link>
            ))}
        </div>
    );
};