using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace afl_opgave6_klientFinal1
{
    internal class klient
    {
        static string tastaturInput = "";
        static string dataSomString = "";
        static void Main(string[] args)
        {


            TcpClient klient = new TcpClient();
            klient.Connect("192.168.1.33", 1042);

            //insæt syntax

            NetworkStream dataStrøm = klient.GetStream();

            do
            {
                if (Console.KeyAvailable == true)
                {   
                    SkrivTilServer(dataStrøm);
                }

                if (dataStrøm.DataAvailable == true)
                {
                    LæsFraServeren(dataStrøm, klient.ReceiveBufferSize);
                }

                // bliv ved indtil der skrives quite (do-while)

            } while (tastaturInput.ToLower() != "quit");

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
            //Console.WriteLine("Skriv noget til serveren Lok'Thar: ");
            tastaturInput = Console.ReadLine();


            // laver string tastaturInput om til en array.
            byte[] data = Encoding.ASCII.GetBytes(tastaturInput);

            // levere data til dataStrøm/TCPClient. 
            strømAfData.Write(data, 0, data.Length);
        }
    }
}