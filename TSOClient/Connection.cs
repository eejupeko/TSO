using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TSOClient
{
    class Connection
    {
        private int port;
        private string str = "Ei";
        private bool status = false;
        private string ip = "localhost";
        private string error = "";
        private bool errorCheck = false;
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;
        private Socket palvelin;
        private IPEndPoint ipep;
        private Socket asiakas;
        private IPEndPoint ipepa;
        public void setPort(int p)
        {
            this.port = p;
        }

        public void setStr(string s)
        {
            this.str = s;
        }

        public string getStr()
        {
            return this.str;
        }

        public bool getStatus()
        {
            return this.status;
        }

        public bool getErrorCheck()
        {
            return this.errorCheck;
        }

        public string getError()
        {
            return this.error;
        }
        public void Listen() 
        {
            try
            {
                palvelin.Close();
                asiakas.Close();
            } catch (Exception e)
            { }

            
            errorCheck = false;
            palvelin = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipep = new IPEndPoint(IPAddress.Any, port);
            palvelin.Bind(ipep);
            palvelin.Listen(0);
            this.str = "Terve";
            asiakas = palvelin.Accept();
            status = true;
            ipepa = (IPEndPoint)asiakas.RemoteEndPoint;

            NetworkStream ns = new NetworkStream(asiakas);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("100");
            sw.Flush();

            sw.Close();
            sr.Close();
            ns.Close();
        }

        public void Connect()
        {
            errorCheck = false;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ip, port);
            }
            catch (Exception e)
            {
                this.errorCheck = true;
                this.error = e.ToString();
            }
        }
    }
}
