using System.Net.Sockets;
using System.Text;

namespace afl_opgave6_klient1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataSomString = "";
            string tastaturInput = "";

            TcpClient klient = new TcpClient();
            klient.Connect("127.0.0.1", 4444);

            NetworkStream dataStrøm = klient.GetStream();

            // do-while loop. 
            do
            {
                Console.WriteLine("Skriv noget til Serveren: ");
                tastaturInput = Console.ReadLine();

                byte[] data = Encoding.ASCII.GetBytes(tastaturInput);
                dataStrøm.Write(data, 0, data.Length);

            } while (tastaturInput.ToLower() != "quit");
        }
    }
}