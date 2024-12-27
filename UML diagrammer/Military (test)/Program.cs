namespace Military
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier("Gertrud", 11, "Private");

            Officer officer = new Officer("Gertrud", 11, "Private", 100);

            Console.WriteLine(officer); //giv officer og solder en ToString, så vi kan kalde alle details op 
           

        }
    }
}
