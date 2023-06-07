using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace afl_opgave6_server_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oprettelse af Server IP
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            int portNumber = 5555;

            // Oprettelse af TCP lytter
            TcpListener listener = new TcpListener(serverAddress, portNumber);
            listener.Start();
            Console.WriteLine("Afventer Eventyrlig Figur...");

            // accept af client
            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine("Orc kom dumpende.");

            // oprettelse af NetworkStream object for klient connection
            NetworkStream stream = client.GetStream();

            // send velkomstbesked til klienten
            string velkomstBesked = "Velkommen til serveren!";
            byte[] velkomstbeskedBytes = Encoding.ASCII.GetBytes(velkomstBesked);
            stream.Write(velkomstbeskedBytes, 0, velkomstbeskedBytes.Length);

            // do-while loop, indtil modtagelse af beskedf fra client
            byte[] buffer = new byte[1024];
            int bytesRead;
            while (true)
            {
                // Check om der er data tilgængelig på stream.
                if (stream.DataAvailable)
                {
                    // læst data
                    bytesRead = stream.Read(buffer, 0, buffer.Length);

                    // konvertere data til string
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // print beskeden
                    Console.WriteLine("Orcen skriver: " + message);

                    // er der ikke en besked, så quit.
                    if (message.ToLower() == "quit")
                    {
                        break;
                    }
                }

                // check om der er mulighed for at skrive
                if (Console.KeyAvailable)
                {
                    // læs hvad jeg skriver
                    string input = Console.ReadLine();

                    // konverter input til byte array
                    byte[] data = Encoding.ASCII.GetBytes(input);

                    // Send the data to the client
                    stream.Write(data, 0, data.Length);

                    // Check for input ellers "quit"
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }
                }
            }

            // luk server og l
            stream.Close();
            client.Close();
            listener.Stop();
        }
    }
}
