using System;
using System.Net.Sockets;
using System.Text;

namespace afl_opgave6_klient_final
{
    internal class Program
    {
        static string tastaturInput = "";
        static string dataSomString = "";

        static void Main(string[] args)
        {
            TcpClient klient = new TcpClient();
            klient.Connect("127.0.0.1", 5555);

            NetworkStream dataStrøm = klient.GetStream();

            // Modtag velkomstbesked fra serveren
            byte[] buffer = new byte[1024];
            int antalLæsteBytes = dataStrøm.Read(buffer, 0, buffer.Length);
            dataSomString = Encoding.ASCII.GetString(buffer, 0, antalLæsteBytes);
            Console.WriteLine(dataSomString);

            do
            {
                // Send besked til serveren
                if (Console.KeyAvailable)
                {
                    SkrivTilServer(dataStrøm);
                }

                // Modtag besked fra serveren
                if (dataStrøm.DataAvailable)
                {
                    LæsFraServeren(dataStrøm);
                }

            } while (tastaturInput.ToLower() != "quit");

            // Luk forbindelsen til serveren
            klient.Close();
        }

        static void LæsFraServeren(NetworkStream dataFætter)
        {
            byte[] buffer = new byte[1024];
            int antalLæsteBytes = dataFætter.Read(buffer, 0, buffer.Length);
            dataSomString = Encoding.ASCII.GetString(buffer, 0, antalLæsteBytes);
            Console.WriteLine(dataSomString);
        }

        static void SkrivTilServer(NetworkStream strømAfData)
        {
            tastaturInput = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(tastaturInput);
            strømAfData.Write(data, 0, data.Length);
        }
    }
}
