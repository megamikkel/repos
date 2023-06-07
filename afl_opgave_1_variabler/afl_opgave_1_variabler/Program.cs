namespace afl_opgave_1_variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hele humlen er at double kan inde holde kommatal, og
             derfor lave en mere præcis udregning end int. 
            Det er vigtigt at vi sætter resultat i double, da int ikke
            kan udregne med komma tal. 
            Det er ligeledes vigtigt at vi deklæære vores varibler tal 1 og tal 2,
            før deklære resultatet. Hvis resultat var før tal1 eller tal2,
            vil programmet fejl */
           
       
            int tal1 = 16;
            double tal2 = 5.1;
            double resultat = tal1 + tal2;
            

            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}