using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

using System.IO;

namespace Client
{
    class Connection
    {
        private NetworkStream serverWriteStream; //Stream - incoming
        private TcpClient server; //To talk back to the server
        private BinaryWriter serverWriter; //To write to the server

        private NetworkStream serverListenStream; //Stream - incoming        
        private TcpListener listener; //To listen to the clinets  

        public Connection()
        {

        }

        public void Send(String msg)
        {

            this.server = new TcpClient();
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int sendingPort = 6000;

            try
            {
                this.server.Connect(serverIP, sendingPort);

                if (this.server.Connected)
                {

                    this.serverWriteStream = server.GetStream();

                    this.serverWriter = new BinaryWriter(serverWriteStream);
                    Byte[] tempStr = Encoding.ASCII.GetBytes(msg);

                    this.serverWriter.Write(tempStr);
                    Console.WriteLine("  Data: " + msg + " is written to " + serverIP + " on " + sendingPort);
                    this.serverWriter.Close();
                    this.serverWriteStream.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Connecting failed.");
            }
            finally
            {
                this.server.Close();
            }

        }

        public void Listen()
        {
            Socket connection = null;
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int recievingPort = 7000;

            try
            {
                this.listener = new TcpListener(serverIP, recievingPort);
                this.listener.Start();

                while (true)
                {

                    connection = listener.AcceptSocket();

                    if (connection.Connected)
                    {
                        this.serverListenStream = new NetworkStream(connection);

                        List<Byte> inputStr = new List<byte>();

                        int asw = 0;
                        while (asw != -1)
                        {
                            asw = this.serverListenStream.ReadByte();
                            inputStr.Add((Byte)asw);
                        }

                        String msg = Encoding.UTF8.GetString(inputStr.ToArray());

                        this.serverListenStream.Close();

                        Console.WriteLine(msg);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection Failed");
            }
            finally
            {
                if (connection != null)
                    if (connection.Connected)
                        connection.Close();
            }
        }

    }
}
