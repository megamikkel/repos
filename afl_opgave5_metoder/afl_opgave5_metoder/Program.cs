namespace afl_opgave5_metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* Første lomme regner uden symboler
            Console.WriteLine("Tryk 1 for plus Tryk 2 for minus Tryk 3 for gange Tryk 4 for dividere");
            string vælg = Console.ReadLine();
            int vælgSomInt = Convert.ToInt32(vælg);

            Console.WriteLine("Skriv det første tal");
            string tal1 = Console.ReadLine();
            int tal1SomInt = Convert.ToInt32(tal1);

            Console.WriteLine("Skriv det andet tal");
            string tal2 = Console.ReadLine();
            int tal2SomInt = Convert.ToInt32(tal2);

            if (vælgSomInt == 1)
            {
                int print = Plus(tal1SomInt, tal2SomInt);
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }

            if (vælgSomInt == 2)
            {
                int print = Minus(tal1SomInt, tal2SomInt);
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }

            if (vælgSomInt == 3)
            {
                int print = Gange(tal1SomInt, tal2SomInt);
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }
            else if (vælgSomInt == 4)
            {
                int print = Dividere(tal1SomInt, tal2SomInt);
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }*/
            // Lommeregner med symbol
            Console.WriteLine("Tryk + for plus Tryk - for minus Tryk * for gange Tryk / for dividere");
            string vælg = Console.ReadLine();


            Console.WriteLine("Skriv det første tal");
            string talSomstring = Console.ReadLine();
            int tal1 = Convert.ToInt32(talSomstring);

            Console.WriteLine("Skriv det andet tal");
            talSomstring = Console.ReadLine();
            int tal2 = Convert.ToInt32(talSomstring);

            if (vælg == "+")
            {
                string print = Plus(tal1, tal2).ToString();
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }

            if (vælg == "-")
            {
                string print = "" + Minus(tal1, tal2);
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }

            if (vælg == "*")
            {
                string print = Convert.ToString( Gange(tal1, tal2) );
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }
            else if (vælg == "/")
            {
                // ToDo: vælg en måde at lave int'en fra Divedere() om til en string.
                string print = Dividere2(tal1, tal2);
                print = Convert.ToString( Dividere(tal1, tal2) );
                Console.WriteLine("Resultatet er " + print);
                Console.ReadLine();
            }

        }
        public static int Plus(int tal1, int tal2)
        {
            return tal1 + tal2;

        }
        public static int Minus(int tal1, int tal2)
        {
            return tal1 - tal2;
        }
        public static int Gange(int tal1, int tal2)
        {
            return tal1 * tal2;
        }
         static int Dividere(int tal1, int tal2)
        {
            return tal1 / tal2;
        }
        static string Dividere2(int tal1, int tal2)
        {
            return Convert.ToString(tal1 / tal2);
        }
    }
}
