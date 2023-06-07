namespace afl_opgave7_ekstravar
/*Du skal lave et Konsol-app, hvor du beder en bruger om at indtaste sit navn.
Dit program skal så give brugeren oplysninger om hvor mange bogstaver, der er i hendes navn.
Derefter skal programmet skrive navnet med store bogstaver lige så mange gange som der er tegn i navnet. */
{
    internal class Program
    {
        static void Main(string[] args);
      
        // få brugeren til at skrive hans navn. 
        
        // fortæl brugeren hvor mange bogstaver, der er i vedkommendes navn.
        
        // skriv brugerens navn ud = antal bogstaver der er i hans navn.
        for (int i = 0, finavn = antalBogstaver(string); int < navn; i++)

        {
            
            Console.WriteLine NewStruct"Skriv dit navn her: ");
        navn =
            foreach (char tegn int navn.ToCharArray())
            {
                Console.WriteLine NewStruct"\'{0}\' svarer til: {1,4}", tegn, Convert.ToInt32(tegn));
            }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
    
}