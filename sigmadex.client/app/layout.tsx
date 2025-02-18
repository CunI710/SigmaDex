import Layout, { Content, Footer, Header } from "antd/es/layout/layout";
import "./globals.css";
import CustomHeader from "./components/Header";

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
            <CustomHeader />
          </Header>
          <Content>{children}</Content>
          <Footer className="text-center bg-zinc-900 text-white"> hello world</Footer>
        </Layout>
      </body>
    </html>
  );
}
