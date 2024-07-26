import Layout, { Content, Footer, Header } from "antd/es/layout/layout";
import "./globals.css";
import { Menu } from "antd";
import Link from "next/link";

const items = [
  { key: "home", label: <Link href={"/"}>Home</Link> },
  { key: "sigmadex", label: <Link href={"/sigmadex"}>Sigmadex</Link> }
]

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>
        <Layout style={{ minHeight: "100vh" }}>
          <Header>
            <Menu
              theme="dark"
              mode="horizontal"
              items={items}
            />
          </Header>
          <Content>{children}</Content>
          <Footer className="text-center"> Hellloo Wooorldasd</Footer>
        </Layout>
      </body>
    </html>
  );
}
