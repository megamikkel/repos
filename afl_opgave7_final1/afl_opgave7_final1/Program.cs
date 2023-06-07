namespace afl_opgave7_final1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Få brugeren til at indtaste navn, og læs det.
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();

            // analyser hvor langt navnet/string er via. legnth.
            int antalBogstaver = navn.Length;
            Console.WriteLine("Der er {0} tegn i {1}.", antalBogstaver, navn);
            
            // udskriv nanvet i store bogstaver
            Console.WriteLine(navn.ToUpper());
            // udskriv navnet ligeså mange gange som det har bogstaver, og gør det i stre bogstaver
            for (int i = 0; i < antalBogstaver; i++)
            {
                Console.WriteLine(navn.ToUpper());
            }

            // giv bogstavet en tal værdi via. Convert.ToInt32. via koden som er givet.
            foreach (char tegn in navn.ToCharArray())
            {
                Console.WriteLine("'{0}' svarer til: {1}", tegn, Convert.ToInt32(tegn));
            }

            Console.ReadKey();
        }
    }
    
}