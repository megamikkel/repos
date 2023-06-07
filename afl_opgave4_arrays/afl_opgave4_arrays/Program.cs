namespace afl_opgave4_arrays
{
    internal class Program
    {
        static int TerningKast()
        {
            Random tilfædighedsGenerator = new Random();
            return tilfædighedsGenerator.Next(1, 7);
        }
        static void Main(string[] args)
        {
            // 120 Kast
            //int terningVærdi, antalKast = 120;
            //int[] udfaldsSum = new int[6];
            /*
            for (int tæller = 0; tæller < antalKast; tæller++)
            {
                terningVærdi = TerningKast();
                udfaldsSum[terningVærdi - 1]++;
                Console.WriteLine(terningVærdi);
            }
            for (int indeks = 0; indeks < 6; indeks++)
            {
                Console.WriteLine($"Antal {indeks + 1}'ere: {udfaldsSum[indeks]}");
            } 

            /* kast med 6000. Max fortæller hvilken værdid der er slået flest gange
             * Min fortæller værdien med færreste (hyppighdesberegning)
             * Sum er i alt værdien af den slået værdi*/

            int terningVærdi, antalKast = 6000;
            int[] udfaldsSum = new int[6];

            for (int tæller = 0; tæller < antalKast; tæller++)
            {
                terningVærdi = TerningKast();
                udfaldsSum[terningVærdi - 1]++;
                Console.WriteLine(terningVærdi);
            }
            for (int indeks = 0; indeks < 6; indeks++)
            {
                Console.WriteLine($"Antal {indeks + 1}'ere: {udfaldsSum[indeks]}");
                Console.WriteLine();
                Console.WriteLine("største hyppighed: " + udfaldsSum.Max());
                Console.WriteLine("laveste hyppighed: " + udfaldsSum.Min());
                Console.WriteLine("Totalt antal kast: " + udfaldsSum.Sum());
            }
        }

            
           /* string[] personer = new string[] {"Lasse", "Elina", "Tian", "Sebastian", "Dennis" };
            string[] handlinger = new string[] {"stjæler mederne fra julemandens kane", "drikker røde sodavand", "pakker gaver ind", "pakker kattekillinger ind", "spiser vaniljekranse" };
            string[] motiver = new string[] {"julen står for døren", "der er ild i juletræet", "sneen daler blidt ned", "julefrokosten gik over gevir"};

            Random randomGenerator = new Random();

            string person1, handling, motiv, person2;

            bool vilFortsætte = true;
            while(vilFortsætte == true)
            {
                person1 = personer[randomGenerator.Next(personer.Length)];
                person2 = personer[randomGenerator.Next(personer.Length)];
                handling = handlinger[randomGenerator.Next(handlinger.Length)];
                motiv = motiver[randomGenerator.Next(motiver.Length)];
                Console.WriteLine($"{person1} er sammen med {person2}. \nDe {handling}, fordi {motiv}.");

                Console.WriteLine("Vil du prøve igen (j/n)?)");
                    if(Console.ReadLine().ToUpper() != "J")
                {
                    vilFortsætte = false;
                }
            }
        }*/




    }
}