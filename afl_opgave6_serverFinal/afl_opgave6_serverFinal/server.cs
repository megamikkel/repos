using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace afl_opgave6_serverFinal
{
    internal class Program
    

    {
        static string dataSomString = "";
        static string tastaturInput = "";
        static void Main(string[] args)
        {
            // Oprettelse af variable serverAdresse
            // + oprettelse af serveradressens værdi, og port. 
            IPAddress serverAdresse = IPAddress.Parse("127.0.0.1");
            int portNummer = 5555;

            // Jeg instatiere TPCListener med navnet lytter.
            TcpListener lytter = new TcpListener(serverAdresse, portNummer);
            Console.WriteLine("Lytter Oprettet");
            // Her starter TCP Objektet. 
            lytter.Start();
            Console.WriteLine("Lytteren lytter");

            // Her acceptere vi objektet.
            TcpClient klient = lytter.AcceptTcpClient();
            Console.WriteLine("En orc har koblet sig op, sig noget orcish");

            // Her læses data fra klinenten/orc sekventielt. 
            NetworkStream indStrøm = klient.GetStream();

            // do-while-loop indtil quit.
            do
            {
                Console.WriteLine("Skriv noget til serveren Lok'Thar: ");
                if (Console.KeyAvailable == true)
                {
                    SkrivTilServer(indStrøm);
                }

                if (indStrøm.DataAvailable == true)
                {
                    LæsFraServeren(indStrøm, klient.ReceiveBufferSize);
                }

                byte[] dataSomBytes = new byte[klient.ReceiveBufferSize];
                int antalLæsteBytes = indStrøm.Read(dataSomBytes, 0, Convert.ToInt32(klient.ReceiveBufferSize));
                
                // sende 
                tastaturInput = Console.ReadLine();
                indStrøm.Write(dataSomBytes, 0, dataSomBytes.Length);

                dataSomString = Encoding.ASCII.GetString(dataSomBytes, 0, antalLæsteBytes);
                Console.WriteLine($"Her er hvad orcen skriver: \n {dataSomString}");
            } while (dataSomString.ToLower() != "quit");
        }
        static void LæsFraServeren(NetworkStream dataFætter, int bufferStørrelse)
        {
            // modtage
            byte[] dataSomBytes = new byte[bufferStørrelse];
            int antalLæsteBytes = dataFætter.Read(dataSomBytes, 0, Convert.ToInt32(bufferStørrelse));

        }
        static void SkrivTilServer(NetworkStream strømAfData)
        {
            // citere fra tastatur input.
            // Muligvis ToDo:
            Console.WriteLine("Skriv noget til serveren Lok'Thar: ");
            tastaturInput = Console.ReadLine();


            // laver string tastaturInput om til en array.
            byte[] data = Encoding.ASCII.GetBytes(tastaturInput);

            // levere data til dataStrøm/TCPClient. 
            strømAfData.Write(data, 0, data.Length);
        }
    }
}