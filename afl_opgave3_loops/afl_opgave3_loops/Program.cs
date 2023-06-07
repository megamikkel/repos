using System.ComponentModel.Design;

namespace afl_opgave3_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* for-loop kode.
            for (int myCounter = 0; myCounter < 100; myCounter++)
            {
                // Vi elimere tal der kan deles med 5.
                if (myCounter %5 !=0)
                Console.WriteLine(myCounter);
            }*/

            /* while-loop kode */
            int tæller = 0;

            while (tæller < 100)
            {
                if (tæller % 5 > 0)
                {
                    Console.Write(" ");
                }
                tæller += 1;

                Console.WriteLine(tæller);
            }

            /* for loop ned fra 100
            for (int myCounter = 100; myCounter > 0; myCounter--)
            {
                Console.WriteLine(myCounter);
            }*/

            /* for loop, 2 tabellen op til 100.
            for (int myCounter = 0; myCounter < 51; myCounter++)
            {
              
                Console.WriteLine(myCounter*2);
            }*/
           

           
           
        }
    }
}