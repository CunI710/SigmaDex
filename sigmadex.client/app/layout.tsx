import Layout, { Content, Footer, Header } from "antd/es/layout/layout";
import "./globals.css";
import { Menu } from "antd";
import Link from "next/link";

const items = [
  { key: "home", label: <Link href={"/"}>Home</Link> },
  { key: "sigmadex", label: <Link href={"/sigmadex"}>Sigmadex</Link> },
  { key: "login", label: <Link href={"/login"} className="grid justify-end">Log in</Link>, style:{marginLeft:"auto"} }
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
          <Footer className="text-center bg-zinc-900 text-white"> hello world</Footer>
        </Layout>
      </body>
    </html>
  );
}
