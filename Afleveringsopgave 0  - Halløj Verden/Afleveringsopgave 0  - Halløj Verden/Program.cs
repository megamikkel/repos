namespace Afleveringsopgave_0____Halløj_Verden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // hvis der er skrevet nogle argumenter skriver jeg halløj + første argument.
                Console.WriteLine($"Halløj {args[0]}!");
            }
            else
            {
                Console.WriteLine("Halløj, verden!");
            }
        }
            
            
         
    }
}