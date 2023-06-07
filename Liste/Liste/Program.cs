namespace Liste
{
    internal class Program
    {
        static List<string> navneListe = new List<string>() { "Kasper", "Oscar", "Mikkel" };
        static void Main(string[] args)
        {
            navneListe.Add("Tore");
            navneListe.AddRange(new List<string>{ "Magnus","Casper"});
            navneListe.Sort();
            UdskrivNavne();
        }
        static void  UdskrivNavne()
        {
            foreach (string  navn in navneListe)
            {
                Console.WriteLine(navn);
            }
        }
    }
}