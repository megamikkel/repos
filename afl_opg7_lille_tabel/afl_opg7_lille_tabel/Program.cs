namespace afl_opg7_lille_tabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int num = (i - 1) * 10 + j;
                    Console.Write("{0}\t", num);
                }
                Console.WriteLine();
            }
        }
    }
}

        
    


    
