using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace afl_opgave6_server1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dataSomString = "";
            int antalLæsteBytes;

            IPAddress serverAdresse = IPAddress.Parse("127.0.0.1");


            int portNO = 4444;

            TcpListener lytter = new TcpListener(serverAdresse, portNO);
            Console.WriteLine("Lytter oprettet");

            lytter.Start();
            Console.WriteLine("Lytteren lytter");

            TcpClient klient = lytter.AcceptTcpClient();
            Console.WriteLine("En klient har oprettet forbindelse");

            // Data modtagelse syntax.
            NetworkStream indStrøm = klient.GetStream();

            // Array der lager data.
            byte[] dataSomBytes = new byte[klient.ReceiveBufferSize];

            int antalLæsteBytes = indStrøm.Read(dataSomBytes, 0, Convert.ToInt32(klient.ReceiveBufferSize));

            string dataSomString = Encoding.ASCII.GetString(dataSomBytes, 0, antalLæsteBytes);
            Console.WriteLine($"Her er hvad klienten skriver:\n{dataSomString}");
        }

        
    }
}