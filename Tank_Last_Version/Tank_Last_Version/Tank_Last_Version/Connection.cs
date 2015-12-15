using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Tank_Last_Version
{
    class Connection
    {
        private NetworkStream writeStream; //Stream - incoming
        private TcpClient tcpClient; //To talk back to the server
        private BinaryWriter serverWriter; //To write to the server
        private NetworkStream listenStream; //Stream - incoming        
        private TcpListener listener; //To listen to the clinets 

        private Parser parser;

        public Connection(Parser parser)
        {
            this.parser = parser;
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
                        this.listenStream = new NetworkStream(connection);
                        List<Byte> inputStr = new List<byte>();

                        int eof = 0;
                        while (eof != -1)
                        {
                            eof = this.listenStream.ReadByte();
                            inputStr.Add((Byte)eof);
                        }

                        String msg = Encoding.UTF8.GetString(inputStr.ToArray());

                        parser.UpdateMap(msg);

                        this.listenStream.Close();
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


        public bool Send(String msg)
        {

            this.tcpClient = new TcpClient();
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int sendingPort = 6000;

            try
            {
                this.tcpClient.Connect(serverIP, sendingPort);

                if (this.tcpClient.Connected)
                {

                    this.writeStream = tcpClient.GetStream();

                    this.serverWriter = new BinaryWriter(writeStream);
                    Byte[] tempStr = Encoding.ASCII.GetBytes(msg);

                    this.serverWriter.Write(tempStr);
                    //Console.WriteLine("  Data: " + msg + " is written to " + serverIP + " on " + sendingPort);                    
                    this.serverWriter.Close();
                    this.writeStream.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Connecting failed. : " + e.Message);
                return false;
            }
            finally
            {
                this.tcpClient.Close();
            }
            return true;

        }
    }
}
